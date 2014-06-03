import java.util.Scanner;
import java.util.TreeSet;

public class ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] words = input.nextLine().split("\\W+");
        TreeSet<String> wordsSorted = new TreeSet<>();
        for (String word : words) {
            wordsSorted.add(word.toLowerCase());
        }

        for (String word : wordsSorted) {
            System.out.print(word + " ");
        }
    }
}
