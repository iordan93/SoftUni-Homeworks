import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int numberOfItems = input.nextInt();

        // Clears the buffer (which contains a line break) after the integer
        input.nextLine();

        String[] items = new String[numberOfItems];
        for (int i = 0; i < numberOfItems; i++) {
            items[i] = input.nextLine();
        }

        Arrays.sort(items);
        System.out.println(String.join(System.getProperty("line.separator"), items));
    }
}
