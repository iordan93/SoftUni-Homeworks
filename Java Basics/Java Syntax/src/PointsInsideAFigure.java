import java.util.Locale;
import java.util.Scanner;

public class PointsInsideAFigure {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the coordinates of the point to check: ");
        double x = input.nextDouble();
        double y = input.nextDouble();

        boolean isInFirstRectangle = x >= 12.5 && x <= 22.5 && y >= 6 && y <= 8.5;
        boolean isInSecondRectangle = x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5;
        boolean isInThirdRectangle = x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5;

        boolean isInFigure = isInFirstRectangle || isInSecondRectangle || isInThirdRectangle;
        System.out.println(isInFigure ? "Inside" : "Outside");
    }
}
