/* 
Program to find the sum of all multiples of any two positive integers below 1000
I have used an immutable class set-up, the io.Console class to obtain user input and an IntStream to perform the calculation
*/

import java.io.*;

public class Program{
    
    //Main method
    public static void main(String []args){
        
        //Variable declaration
        int first;
        int second;

        //Obtaining user input to determine which two numbers to use
        Console console = System.console();

        console.writer().print("\nThis program will calculate the sum of all multiples of two positive integers up to 1000.");
        console.flush();

        do{
        console.writer().print("\nPlease enter the first integer:");
        console.flush();
        first = getInput(console.readLine());
        }
        while(first <= 0);
        
        do{
        console.writer().print("\nPlease enter the second integer:");
        console.flush();
        second = getInput(console.readLine());
        }
        while(second <= 0);

        //Creation of Multiples instance
        Multiples multiples = new Multiples(first, second);

        //Running the method to calculate the answer
        multiples.calculate();
    }

    //Definition of method for taking/filtering user input
    public static int getInput(String input){
        int result;
        
        try{
            result = Integer.valueOf(input);
        }
        catch(NumberFormatException e){
            result = 0;
        }
        
        if(result <= 0 || result > 1000){
            System.out.println("\nInvalid input. Please choose a positive integer between 1 and 1000.");
        }
        
        return result;
    }
}