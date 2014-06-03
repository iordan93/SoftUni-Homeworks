import java.util.Locale;
import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner input = new Scanner(System.in);
        System.out.print("Please enter the three numbers: ");
        int firstNumber = input.nextInt();
        double secondNumber = input.nextDouble();
        double thirdNumber = input.nextDouble();

        String firstNumberAsHex = Integer.toHexString(firstNumber).toUpperCase();
        String firstNumberAsBinary = String.format("%10s", Integer.toBinaryString(firstNumber)).replace(' ', '0');

        System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", firstNumberAsHex, firstNumberAsBinary, secondNumber, thirdNumber);
    }
}
