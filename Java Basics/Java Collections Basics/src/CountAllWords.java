import java.util.Scanner;

public class CountAllWords {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String text = input.nextLine();

        // Words are delimited by non-letter characters
        String[] words = text.split("\\W+");
        System.out.println(words.length);
    }
}
