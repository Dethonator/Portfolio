public class Program{
    public static void main(String args[]){
        System.out.println("This program will calculate the sum of all even numbers in the Fibonacci sequence (starting with 1 and 2) below 4,000,000.");
        Fibonacci fibonacci = new Fibonacci(4000000);
        
        //sum variable declaration
        int sum = 0;

        //for-each statement to calculate sum
        for(Integer term : fibonacci.fibonacciSequence){
            sum += term;
        }
        System.out.println("The sum is " + sum);
    }
}