import java.util.Scanner;

public class LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] items = input.nextLine().split(" ");
        int currentSequenceStart = 0;
        int currentSequenceLength = 1;
        int bestSequenceStart = 0;
        int bestSequenceLength = 1;
        for (int i = 1; i < items.length; i++) {

            if (items[i].equals(items[i - 1])) {
                currentSequenceLength++;
            } else {
                currentSequenceLength = 1;
                currentSequenceStart = i;
            }

            if (currentSequenceLength > bestSequenceLength) {
                bestSequenceLength = currentSequenceLength;
                bestSequenceStart = currentSequenceStart;
            }
        }

        for (int i = bestSequenceStart; i < bestSequenceStart + bestSequenceLength; i++) {
            System.out.print(items[i] + " ");
        }
    }
}
