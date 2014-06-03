import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter the coordinates of A: ");
        int ax = input.nextInt();
        int ay = input.nextInt();
        System.out.print("Enter the coordinates of B: ");
        int bx = input.nextInt();
        int by = input.nextInt();
        System.out.print("Enter the coordinates of C: ");
        int cx = input.nextInt();
        int cy = input.nextInt();

        int area = Math.abs((ax * (by - cy) + bx * (cy - ay) + cx * (ay - by)) / 2);
        System.out.println("The area of the triangle is: " + area);
    }
}
