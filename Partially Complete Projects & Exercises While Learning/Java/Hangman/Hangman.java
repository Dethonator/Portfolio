import java.util.Random;
import java.util.Scanner;
import java.util.ArrayList;

public class Hangman{

static ArrayList<String> words = new ArrayList<>();
static{ 
    words.add("FLOBADOB");
    words.add("BLIBBLOB");
    words.add("BLEEB");
    words.add("SEDIMENT");
    words.add("FLATULENCE");
    words.add("NIBBLE");
}

static Random number;
static String wordChoice;
static StringBuilder progress = new StringBuilder();
static int count;
static int lives;


public static void main(String args[]){

    System.out.println("\nWelcome to Hangman!\n");
    
    while(true){
            
        System.out.println("MAIN MENU");
        System.out.println("1 - Start Game");
        System.out.println("2 - Add New Words");
        System.out.println("3 - View Existing Word Library");
        System.out.println("4 - Exit");
 
        number = new Random();
        wordChoice = words.get(number.nextInt(words.size()));
        count = 0;
        lives = 5;
        
        Scanner menuChoice = new Scanner(System.in);
        String menuNum = menuChoice.nextLine();
    
        switch(menuNum) {
        
        case "1":
        
            System.out.println("Let the game commence! You have "+lives+" lives remaining. Your word to guess is...\n");
            int wordLength = wordChoice.length();
            
            for(int x=1; x<=wordLength; x++){
                progress.append("-");
            }

            do{
                System.out.println(progress+"\n");
                System.out.println("Please choose a letter");
                Scanner letterGuess = new Scanner(System.in);
                String letter = letterGuess.nextLine();
    
                if(wordChoice.indexOf(letter.toUpperCase())>=0 & progress.indexOf(letter.toUpperCase())==-1){
       
                    System.out.println("Correct!");
                    System.out.println("You have "+lives+" lives remaining.");
        
                    progress.insert(wordChoice.indexOf(letter.toUpperCase()),letter.toUpperCase());
                    progress.deleteCharAt(wordChoice.indexOf(letter.toUpperCase())+1);
                    count++;
        
                    for(int x=1; x<=wordChoice.length(); x++){
                        if(wordChoice.indexOf((letter.toUpperCase()), wordChoice.indexOf(letter.toUpperCase())+x)>=0){
                        progress.insert(wordChoice.indexOf(letter.toUpperCase(), wordChoice.indexOf(letter.toUpperCase())+x),letter.toUpperCase());
                        progress.deleteCharAt(wordChoice.indexOf(letter.toUpperCase(), wordChoice.indexOf(letter.toUpperCase())+x)+1);
                        count++;
                    }
                }
            }
    
                else if(progress.indexOf(letter.toUpperCase())!=-1){
                    System.out.println("You have already found that letter! Be careful with your lives! I will let you off on this occasion!");
                }
        
                else{
                    lives--;
                    System.out.println("Incorrect.");
                    
                    if(lives!=1){
                        System.out.println("You have "+lives+" lives remaining.");
                    }
                    else{
                        System.out.println("You have "+lives+" life remaining.");
                    }   
                }
            }   
            while(progress.indexOf("-")!=-1 & lives > 0);
    
            if(lives == 0){
                System.out.println("You have run out of lives! Better luck next time!\n");
            }
            else{
                System.out.println("The word you were looking for was "+progress);
                System.out.println("Congratulations! You win!\n");
            }
            
            progress.delete(0, progress.length());
            break;
        
        case "2":
                       
            System.out.println("\nPlease enter the word you would like to add.");
            Scanner wordSelection = new Scanner(System.in);
            String newWord = wordSelection.nextLine();
            
            if(words.contains(newWord.toUpperCase())){
                System.out.println("That word has already been added. Please choose another.\n");
            }
            else if(newWord.trim().equals("") || newWord.contains(" ")){
                System.out.println("Invalid word. Please try again.\n");
            }
            else{
                words.add(newWord.toUpperCase());
                System.out.println(newWord.toUpperCase()+" added.\n");
            }
           
            break;
             
        case "3": 
        
            System.out.println("Word Library:\n");
            for(String word: words){
                System.out.println(word);
            }
            System.out.println("");
            break;
            
        case "4":
        
            System.exit(0);
            
        default:
        
            System.out.println("Selection not recognised. Please try again.\n");
            break;
        
    }
    }
  }
}    