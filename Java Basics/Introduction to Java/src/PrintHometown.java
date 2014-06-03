import java.util.Scanner;

public class PrintHometown {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter your hometown: ");
        String hometown = input.nextLine();
        System.out.printf("Your hometown is %s", hometown).println();
    }
}
