import java.util.Scanner;

public class CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] words = input.nextLine().split("\\W+");
        String wordToSearch = input.nextLine();

        int wordCounter = 0;
        for (String word : words) {
            if (wordToSearch.toLowerCase().equals(word.toLowerCase())) {
                wordCounter++;
            }
        }

        System.out.println(wordCounter);
    }
}
