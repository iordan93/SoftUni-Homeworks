import java.util.Scanner;

public class SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the first number in the range: ");
        int start = input.nextInt();
        System.out.print("Enter the last number in the range: ");
        int end = input.nextInt();

        for (int i = start; i <= end; i++) {
            String reversedNumber = new StringBuilder(Integer.toString(i)).reverse().toString();
            if (Integer.toString(i).equals(reversedNumber)) {
                System.out.print(i + " ");
            }
        }

        System.out.println();
    }
}
