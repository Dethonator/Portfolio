using System;
namespace CardLibraryMk2
{
    [Serializable]
    public enum PlayerState
    {
        Inactive,
        Active,
        MustDiscard,
        Winner,
        Loser
    }
}