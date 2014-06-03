import java.util.HashSet;

public class FullHouseWithJokers {
    private static final String[] faces = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
    private static final String[] suits = new String[]{"♣", "♦", "♥", "♠"};
    private static final String joker = "*";

    public static void main(String[] args) {
        // The same task as the previous one, except we now generate 32 combinations with jokers for each full house
        int count = 0;
        String[] currentCombination = new String[5];
        for (int firstCard = 0; firstCard < faces.length; firstCard++) {
            for (int secondCard = 0; secondCard < faces.length; secondCard++) {
                if (firstCard != secondCard) {
                    for (int firstSuit = 0; firstSuit < suits.length; firstSuit++) {
                        for (int secondSuit = firstSuit + 1; secondSuit < suits.length; secondSuit++) {
                            for (int thirdSuit = secondSuit + 1; thirdSuit < suits.length; thirdSuit++) {
                                for (int fourthSuit = 0; fourthSuit < suits.length; fourthSuit++) {
                                    for (int fifthSuit = fourthSuit + 1; fifthSuit < suits.length; fifthSuit++) {
                                        for (int combination = 0; combination <= Math.pow(2, 5) - 1; combination++) {
                                            int currentIndex = combination;
                                            for (int jokerIndex = 0; jokerIndex < 5; jokerIndex++) {
                                                if (currentIndex % 2 == 1) {
                                                    currentCombination[jokerIndex] = "*";
                                                    currentIndex /= 2;
                                                }
                                            }

                                            System.out.print("(" + String.join(" ", currentCombination) + ") ");
                                            currentCombination[4] = faces[firstCard] + suits[firstSuit];
                                            currentCombination[3] = faces[firstCard] + suits[secondSuit];
                                            currentCombination[2] = faces[firstCard] + suits[thirdSuit];
                                            currentCombination[1] = faces[secondCard] + suits[fourthSuit];
                                            currentCombination[0] = faces[secondCard] + suits[fifthSuit];
                                            count++;
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        System.out.println();
        System.out.println(count + " full houses");
    }
}
