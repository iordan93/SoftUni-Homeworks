import java.util.Scanner;

public class CountOfBitsOne {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Please enter a number: ");
        int number = input.nextInt();

        System.out.printf("There are %d bits one", Integer.bitCount(number));
    }
}
