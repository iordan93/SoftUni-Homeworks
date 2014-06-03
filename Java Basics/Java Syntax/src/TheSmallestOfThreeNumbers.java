import java.util.Locale;
import java.util.Scanner;

public class TheSmallestOfThreeNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the three numbers: ");
        double first = input.nextDouble();
        double second = input.nextDouble();
        double third = input.nextDouble();

        System.out.println("The smallest number is: " + Math.min(Math.min(first, second), third));
    }
}
