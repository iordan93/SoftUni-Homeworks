import java.util.Scanner;

public class CountOfEqualBitPairs {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a number: ");
        int number = input.nextInt();
        int pairsCount = 0;
        for (; number >> 1 != 0; number >>= 1) {
            int currentBit = number & 1;
            int nextBit = (number >> 1) & 1;

            if (currentBit == nextBit) {
                pairsCount++;
            }
        }

        System.out.printf("There are %d equal bit pairs", pairsCount);
    }
}
