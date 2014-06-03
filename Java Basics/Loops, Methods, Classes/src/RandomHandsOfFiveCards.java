import com.sun.org.apache.xpath.internal.functions.FuncSubstring;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class RandomHandsOfFiveCards {
    private static final String[] faces = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
    private static final String[] suits = new String[]{"♣", "♦", "♥", "♠"};

    public static void main(String[] args) {
        ArrayList<String> cards = generateCards();
        Scanner input = new Scanner(System.in);
        int numberOfHands = input.nextInt();

        for (int i = 0; i < numberOfHands; i++) {
            generateRandomHand(cards);
        }
    }

    private static ArrayList<String> generateCards() {
        ArrayList<String> cards = new ArrayList<>();
        for (String face : faces) {
            for (String suit : suits) {
                cards.add(face + suit);
            }
        }

        return cards;
    }

    private static void generateRandomHand(ArrayList<String> cards) {
        Collections.shuffle(cards);
        System.out.println(String.join(" ", cards.subList(0, 5)));
    }
}
