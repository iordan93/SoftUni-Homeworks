import java.util.Scanner;

public class LongestIncreasingSequence {
    public static void main(String[] args) {
        // This is a combination of the previous algorithms - to print all increasing sequences
        // and to find the longest increasing sequence
        Scanner input = new Scanner(System.in);
        String[] numbersAsStrings = input.nextLine().split(" ");
        int[] numbers = new int[numbersAsStrings.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(numbersAsStrings[i]);
        }

        int currentSequenceStart = 0;
        int currentSequenceLength = 1;
        int bestSequenceStart = 0;
        int bestSequenceLength = 1;

        System.out.print(numbers[0]);
        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i] > numbers[i - 1]) {
                currentSequenceLength++;
                System.out.print(" " + numbers[i]);
            } else {
                currentSequenceLength = 1;
                currentSequenceStart = i;
                System.out.println();
                System.out.print(numbers[i]);
            }

            if (currentSequenceLength > bestSequenceLength) {
                bestSequenceLength = currentSequenceLength;
                bestSequenceStart = currentSequenceStart;
            }
        }

        System.out.println();
        System.out.print("Longest:");
        for (int i = bestSequenceStart; i < bestSequenceStart + bestSequenceLength; i++) {
            System.out.print(" " + numbers[i]);
        }
    }
}
