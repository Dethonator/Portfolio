import java.util.Scanner;

public class Milkbar {
	public static void main(String[] args) {
		int total = 0;
		Scanner myResponse = new Scanner(System.in);
		for (int answer = 1; answer != 0; ){

		System.out.println("What can I get you?");
		System.out.println("Input 1 for Strawberry Milkshake costing £1");
		System.out.println("Input 2 for Banana Milkshake costing £2");
		System.out.println("Input 3 for Chocolate Milkshake costing £3");
		System.out.println("OR");
		System.out.println("Input 0 when you are finished and I'll give you your bill");

		answer = myResponse.nextInt();  // Read user input

		if(answer == 0) {
			System.out.println("Your bill for today comes to £" + total);
		}
		
		else {

			switch(answer) {

				case 1:
					System.out.println("Strawberry Milkshake.");
					total += 1;
					break;	

				case 2:
					System.out.println("Banana Milkshake.");
					total += 2;
					break;

				case 3:
					System.out.println("Chocolate Milkshake.");
					total += 3;
					break;

			}
		}
		}
	}
}