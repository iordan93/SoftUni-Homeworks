import java.util.Locale;
import java.util.Scanner;

public class PointsInsideTheHouse {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the coordinates of the point: ");
        double x = input.nextDouble();
        double y = input.nextDouble();

        boolean isRightOfLeftRoof = ((12.5 - 17.5) * (y - 3.5) - (8.5 - 3.5) * (x - 17.5)) <= 0;
        boolean isLeftOfRightRoof = ((22.5 - 17.5) * (y - 3.5) - (8.5 - 3.5) * (x - 17.5)) >= 0;
        boolean isInRoof = isRightOfLeftRoof && isLeftOfRightRoof && y <= 8.5;

        boolean isInLeftRectangle = x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5;
        boolean isInRightRectangle = x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5 ;

        if (isInRoof || isInLeftRectangle || isInRightRectangle) {
            System.out.println("Inside");
        } else {
            System.out.println("Outside");
        }
    }
}
