import java.util.Scanner;

public class SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] items = input.nextLine().split(" ");

        System.out.print(items[0]);
        for (int i = 1; i < items.length; i++) {
            if (items[i].equals(items[i - 1])) {
                System.out.print(" " + items[i]);
            } else {
                System.out.println();
                System.out.print(items[i]);
            }
        }
    }
}
