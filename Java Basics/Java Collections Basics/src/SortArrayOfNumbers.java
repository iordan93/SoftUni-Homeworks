import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int count = input.nextInt();
        input.nextLine();
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++) {
            numbers[i] = input.nextInt();
        }

        Arrays.sort(numbers);

        StringBuilder output = new StringBuilder();
        for (int i : numbers) {
            output.append(i + " ");
        }

        System.out.println(output.toString().trim());
    }
}
