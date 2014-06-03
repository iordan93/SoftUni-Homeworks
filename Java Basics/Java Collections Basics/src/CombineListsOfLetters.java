import java.util.ArrayList;
import java.util.Scanner;

public class CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] firstAsStringArray = input.nextLine().split(" ");
        String[] secondAsStringArray = input.nextLine().split(" ");
        ArrayList<Character> first = new ArrayList<>();
        ArrayList<Character> second = new ArrayList<>();
        for (String string : firstAsStringArray) {
            first.add(string.charAt(0));
        }

        for (String string : secondAsStringArray) {
            second.add(string.charAt(0));
        }

        // The easiest way to combine the lists is to remove all elements from one that are present in the other
        // and then add the two lists together
        second.removeAll(first);
        first.addAll(second);

        for (Character element : first) {
            System.out.print(element + " ");
        }
    }
}
