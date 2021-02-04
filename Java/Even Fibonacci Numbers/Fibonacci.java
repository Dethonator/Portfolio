import java.util.*;

public class Fibonacci{
    //ArrayList to store each term of the sequence
    ArrayList<Integer> fibonacciSequence = new ArrayList<>();

    //Constructor
    public Fibonacci(int upTo){
        
        fibonacciSequence.add(1);
        fibonacciSequence.add(2);
        
        for(int x = fibonacciSequence.get(0), y = fibonacciSequence.get(1), n = 0; n < upTo;){
        n = x + y;
        x = y;
        y = n;
        if(n % 2 == 0)
        fibonacciSequence.add(n);
        }
        
        //removal of non-even first term
        fibonacciSequence.remove(0);     
    }
}