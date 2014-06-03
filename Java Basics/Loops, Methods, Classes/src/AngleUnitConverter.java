import java.util.Locale;
import java.util.Scanner;

public class AngleUnitConverter {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner input = new Scanner(System.in);

        int numberOfConversions = input.nextInt();
        input.nextLine();

        for (int i = 0; i < numberOfConversions; i++) {
            String[] conversion = input.nextLine().split(" ");
            double value = Double.parseDouble(conversion[0]);
            switch (conversion[1]) {
                case "deg":
                    System.out.printf("%.6f rad", degreesToRadians(value)).println();
                    break;
                case "rad":
                    System.out.printf("%.6f deg", radiansToDegrees(value)).println();
                    break;
                default:
                    System.out.println("Unknown or invalid units");
                    break;
            }
        }
    }

    public static double radiansToDegrees(double radians) {
        return radians * 180.0 / Math.PI;
    }

    public static double degreesToRadians(double degrees) {
        return degrees * Math.PI / 180.0;
    }
}
