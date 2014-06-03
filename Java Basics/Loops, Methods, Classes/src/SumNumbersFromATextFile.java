import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class SumNumbersFromATextFile {
    public static void main(String[] args) {
        try {
            long sum = 0;
            Scanner fileScanner = new Scanner(new File("src/SumNumbers.txt"));
            while (fileScanner.hasNext()) {
                sum += fileScanner.nextInt();
            }

            System.out.println(sum);
        } catch (FileNotFoundException ex) {
            System.out.println("Error");
        }
    }
}
