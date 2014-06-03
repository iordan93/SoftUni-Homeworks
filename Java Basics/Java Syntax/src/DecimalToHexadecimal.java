import java.util.Scanner;

public class DecimalToHexadecimal {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a decimal number: ");
        int number = input.nextInt();
        System.out.println("The number in hexadecimal format is: " + Integer.toHexString(number).toUpperCase());
    }
}
