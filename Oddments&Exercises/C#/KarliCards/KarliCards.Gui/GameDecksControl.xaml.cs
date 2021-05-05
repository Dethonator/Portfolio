using CardLibraryMk2;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace KarliCards.Gui
{
    public partial class GameDecksControl : UserControl
    {
        public static readonly DependencyProperty GameStartedProperty =
            DependencyProperty.Register("GameStarted", typeof(bool), typeof(GameDecksControl), new PropertyMetadata(false));
        public static readonly DependencyProperty CurrentPlayerProperty =
            DependencyProperty.Register("CurrentPlayer", typeof(Player), typeof(GameDecksControl), new PropertyMetadata(null));
        public static readonly DependencyProperty DeckProperty =
            DependencyProperty.Register("Deck", typeof(Deck), typeof(GameDecksControl), new PropertyMetadata(null));
        public static readonly DependencyProperty AvailableCardProperty =
            DependencyProperty.Register("AvailableCard", typeof(Card), typeof(GameDecksControl), new PropertyMetadata(null));

        private void DrawDecks()
        {
            controlCanvas.Children.Clear();
            if (CurrentPlayer == null || Deck == null) || !GameStarted)
            return;
            List<CardControl> stackedCards = new List<CardControl>();
            for (int i=0; i < Deck.CardsInDeck; i++)
                stackedCards.Add(new CardControl(Deck.GetCard(i)) { Margin = new Thickness(150 + (i * 1.25), 25 - (i * 1.25), 0, 0), IsFaceUp = false });
            if (stackedCards.Count > 0)
                stackedCards.Last().MouseDoubleClick += Deck_MouseDoubleClick;
            if (AvailableCard != null)
            {
                var availableCard = new CardControl(AvailableCard) {Margin = new Thickness(0, 25, 0, 0)};
                availableCard.MouseDoubleClick += AvailableCard_MouseDoubleClick;
                controlCanvas.Children.Add(availableCard);
            }
            stackedCards.ForEach(x => controlCanvas.Children.Add(x));
        }

        private static void OnGameStarted(DependencyObject source, DependencyPropertyChangedEventArgs e) =>
            (source as GameDecksControl)?.DrawDecks()();
        private static void OnDecksChanged(DependencyObject source, DependencyPropertyChangedEventArgs e) =>
            (source as GameDecksControl)?.DrawDecks()();
        private static void OnAvailableCardChanged(DependencyObject source, DependencyPropertyChangedEventArgs e) =>
            (source as GameDecksControl)?.DrawDecks()();

        private static void OnPlayerChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            var control = source as GameDecksControl;
            if (control.CurrentPlayer == null)
                return;
            control.CurrentPlayer.OnCardDiscarded += control.CurrentPlayer_OnCardDiscarded;
            control.DrawDecks();
        }

        private void CurrentPlayer_OnCardDiscarded(object sender, CardEventArgs e)
        {
            AvailableCard = e.Card;
            DrawDecks();
        }

        void AvailableCard_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (CurrentPlayer.State != PlayerState.Active)
                return;
            var control = sender as CardControl;
            CurrentPlayer.AddCard(control.Card);
            AvailableCard = null;
            DrawDecks();
        }

        void Deck_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (CurrentPlayer.State != PlayerState.Active)
                return;
            CurrentPlayer.DrawCard(Deck);
            DrawDecks();
        }
    }
}