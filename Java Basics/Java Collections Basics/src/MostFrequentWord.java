import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] words = input.nextLine().split("\\W+");
        TreeMap<String, Integer> frequencies = new TreeMap<>();
        int maxCount = 0;
        for (String word : words) {
            String wordToLowerCase = word.toLowerCase();
            if (!frequencies.containsKey(wordToLowerCase)) {
                frequencies.put(wordToLowerCase, 1);
            } else {
                frequencies.put(wordToLowerCase, frequencies.get(wordToLowerCase) + 1);
            }

            int currentCount = frequencies.get(wordToLowerCase);
            if (currentCount > maxCount) {
                maxCount = currentCount;
            }
        }

        for (Map.Entry<String, Integer> entry : frequencies.entrySet()) {
            if (entry.getValue() == maxCount) {
                System.out.printf("%s -> %d times", entry.getKey(), entry.getValue()).println();
            }
        }
    }
}
