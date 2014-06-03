import java.util.Scanner;

public class GenerateThreeLetterWords {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the letters: ");
        char[] letters = input.nextLine().toCharArray();

        getCombinations(letters, "");
        System.out.println();
    }

    public static void getCombinations(char[] letters, String currentCombination) {

        if (currentCombination.length() == 3) {
            System.out.print(currentCombination + " ");

        } else {
            for (char letter : letters) {
                getCombinations(letters, currentCombination + letter);
            }
        }
    }
}
