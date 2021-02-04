import java.util.ArrayList;
import java.util.Scanner;

public class Question
{
    // instance variables
    final String question;
    ArrayList<String> whichGirl = new ArrayList<>();
    final int[][] scores;
    
    //constructor
    public Question(String question, String[] whichGirl, int[][] scores)
    {
        this.question = question;
        this.scores = scores;
        
        //ArrayList population
        for(int x=0; x < whichGirl.length; x++){
            this.whichGirl.add(whichGirl[x]);
        }
    }
    
    public int ask(String girlName){
        System.out.println(question);
        Scanner response = new Scanner(System.in);
        
        int count = 0;
        int scoreGiven = 0;
        int answer = 0;
        
        //try-catch and if-else statements to protect against invalid input
        try{
            answer = response.nextInt();
        }
        catch(Exception e){
        }
        
        if(answer > scores[0].length){
           System.out.println("That doesn't make any sense. You are not making a good impression here.");
           scoreGiven--;
        }
        else if(answer <= 0){
           System.out.println("That doesn't make any sense. You are not making a good impression here.");
           scoreGiven--;
        }
        else{
             //enhanced for loop to award score based on answer
    OUTER:  for(int score:scores[whichGirl.indexOf(girlName)]){
            
                //if-else statement to find correct score
                if(count == answer){
                    scoreGiven = score;
                    break OUTER;
                }              
                count++;
            }
        }
        return scoreGiven;
    }
}