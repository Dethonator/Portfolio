import java.util.Random;
import java.util.ArrayList;
import java.util.Collections;

public class SpeedDating{
   
   //instantiation of Girl objects
   static Girl Ethel = new Girl("Ethel", 82, "Short, white perm and glasses.",
   "A knitted cardigan and a golden brooch shaped almost like an upside-down V.");
   
   static Girl Gloria = new Girl("Gloria", 37, "Tall and slender with long blonde hair.", "A blue dress.");
   
   static Girl Petunia = new Girl("Petunia", 29, "Medium height and build, shoulder-length brunette and glasses.", "A long hooded brown robe.");
   
   static Girl Barbara = new Girl("Barbara", 43, "Short and stocky, medium length ponytail and glasses.", "A formal ladies suit and trousers.");
   
   static Girl Jessica = new Girl("Jessica", 24, "Tall, curvy, long red hair and red lipstick.", "A long red dress.");
   
   //instantiation of Question objects
   static Question Q1 = new Question("\nStar Trek or Star Wars?\n\n1. Star Trek\n2. Star Wars\n3. Both have a place in my heart\n4. Neither",
                                     new String[] {"Ethel", "Petunia", "Jessica"},
                                     new int[][] {{2, 1, 2, -2}, {2, 1, 1, -1}, {-1, 0, -2, 1}});
                                     
   static Question Q2 = new Question("\nWhat's your tipple?\n\n1. Beer\n2. Cider\n3. Wine\n4. I don't drink",
                                     new String[] {"Ethel", "Gloria", "Jessica", "Barbara"},
                                     new int[][] {{2, 1, 1, -2}, {1, 2, 2, -1}, {0, 1, 2, -1}, {0, 0, 0, 2}});
                                     
   static Question Q3 = new Question("\nDo you prefer a night out clubbing or a quiet night in on the sofa?\n\n1. Night out\n2. Night in",
                                     new String[] {"Gloria", "Jessica", "Barbara"},
                                     new int[][] {{1, 1}, {2, -1}, {-1, 2}});
                                     
   static Question Q4 = new Question("\nWhat is the airspeed velocity of an unladen swallow?\n\n1. 24 miles per hour\n2. I don't know\n3. What do you mean? African or European swallow?",
                                     new String[] {"Ethel", "Gloria", "Petunia"},
                                     new int[][] {{-1, 0, 2}, {1, 1, 0}, {1, 0, 2}});
                                     
   static Question Q5 = new Question("\nDinosaurs or Dragons?\n1. Dinosaurs\n2. Dragons",
                                     new String[] {"Ethel", "Petunia", "Jessica", "Barbara"},
                                     new int[][] {{1, 2}, {1, -1}, {-1, 0}, {0, -2}});                                    
  
   static Question Q6 = new Question("\nIf he's not the messiah, what is he?\n\n1. What are you on about?\n2. Just a man\n3. A very naughty boy!",
                                     new String[] {"Ethel", "Gloria", "Petunia"},
                                     new int[][] {{-2, 0, 2}, {0, 1, -1}, {-1, 0, 2}});  
                                     
   static Question Q7 = new Question("\nWhat is your favourite type of music?\n1. Classical\n2. Jazz\n3. Rock\n4. Pop\n5. I like a bit of everything",
                                     new String[] {"Ethel", "Gloria", "Petunia", "Jessica", "Barbara"},
                                     new int[][] {{1, 1, 2, -2, -1}, {0, 0, -1, 2, 1}, {1, 0, 2, -2, -1}, {-1, 2, 0, 1, 1},{2, 1, -2, 0, 0}});                                    
                                     
   static Question Q8 = new Question("\nDo you like to cook?\n1. Yes, lots\n2. Sometimes\n3. No, that's your job\n4. I get takeaways",
                                     new String[] {"Ethel", "Petunia", "Jessica", "Barbara"},
                                     new int[][] {{1, 1, -2, 0}, {0, 0, -1, 2}, {1, 1, -1, 0}, {2, 1, -2, -1}});                                    
                                     
   static Question Q9 = new Question("\nWhat's your most valued office item?\n1. Hole punch\n2. Clipboard\n3. Fountain pen\n4. Stapler",
                                     new String[] {"Gloria", "Petunia", "Barbara"},
                                     new int[][] {{0, 0, 1, -1}, {1, 0, 0, 0}, {0, 2, 2, 0}});
                                     
   static Question Q10 = new Question("\nWhat is your favourite reality tv show?\n1. Britain's got talent\n2. The X factor\n3. I'm a celebrity, get me out of here!\n4. I don't watch reality tv",
                                     new String[] {"Gloria", "Jessica", "Barbara"},
                                     new int[][] {{0, 0, 1, 0}, {2, 2, 2, -2}, {0, -1, -1, 2}});  
                                     
   //instantiation of ArrayLists of girls and questions
   static ArrayList<Girl> girls = new ArrayList<>();
   static ArrayList<Question> questions = new ArrayList<>();

    static{
     girls.add(Ethel);
     girls.add(Gloria);
     girls.add(Petunia);
     girls.add(Jessica);
     girls.add(Barbara);
     
     questions.add(Q1);
     questions.add(Q2);
     questions.add(Q3);
     questions.add(Q4);
     questions.add(Q5);
     questions.add(Q6);
     questions.add(Q7);
     questions.add(Q8);
     questions.add(Q9);
     questions.add(Q10);
    }
   
   //main method
   
  public static void main(String args[]){
       
       //introductory message
       System.out.println("Welcome to Speed Dating!");
       System.out.println("You are about to meet five ladies, each of which have three questions for you.");
       
       //randomisation of girls
       
       Collections.shuffle(girls);
       
       //main program loop
       for(Girl girl: girls){
           System.out.println("\nName: "+girl.name+"\n"+"Age: "+girl.age+"\n"+"Appearance: "+girl.appearance+"\n"+"Wearing: "+girl.clothes);
           
           //randomisation of questions for each girl
           Collections.shuffle(questions);
           
           int x = 0;
           
     JUSTTHREE: for(Question question: questions){
                
                    if(question.whichGirl.contains(girl.name)){
                        girl.rating += question.ask(girl.name);
                        x++;
                        if(x==3) break JUSTTHREE;
                    }
                    
                    else continue;
                    
                }
            }

    //report of results
       System.out.println("Here is the impression you made with the ladies. If you scored above a 6, they may well be interested in seeing you again.\n");
       
       for(Girl girlAgain:girls){
           if(girlAgain.rating < 0){
               girlAgain.rating = 0;
            }
           System.out.println(girlAgain.name+" gave you a rating of "+girlAgain.rating);
        }
  }
}