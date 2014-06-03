import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class DaysBetweenTwoDates {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String firstDateAsString = input.nextLine();
        String secondDateAsString = input.nextLine();
        LocalDate firstDate = LocalDate.parse(firstDateAsString, DateTimeFormatter.ofPattern("d-MM-uuuu"));
        LocalDate secondDate = LocalDate.parse(secondDateAsString, DateTimeFormatter.ofPattern("d-MM-uuuu"));
        long difference = ChronoUnit.DAYS.between(firstDate, secondDate);
        System.out.println("The difference between the two dates is " + difference + " days");
    }
}
