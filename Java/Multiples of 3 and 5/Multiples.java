import java.util.stream.*;

public class Multiples{

//Instance Variables
    private int integerOne;
    private int integerTwo;

//Constructor

    public Multiples(int first, int second){
        if(first > 0 && first < 1000){
            integerOne = first;
        }
        else{
            integerOne = 1;
        }

        if(second > 0 && second < 1000){
            integerTwo = second;
        }
        else{
            integerTwo = 1;
        }
}

//Getters (Redundant but here for conventional class structure)
    public int getIntegerOne(){
        return integerOne;
    }

    public int getIntegerTwo(){
        return integerTwo;
    }

//Calculate Method
    public void calculate(){
       int numbers = IntStream.rangeClosed(1,1000)
       .filter((a)->a%integerOne==0|a%integerTwo==0)
       .sum();

        System.out.println("\nThe sum of all multiples of " + integerOne + " and " + integerTwo + " up to 1000 is " + numbers + ".");
    } 
}