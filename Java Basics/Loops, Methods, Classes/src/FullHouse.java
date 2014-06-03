public class FullHouse {
    private static final String[] faces = new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
    private static final String[] suits = new String[]{"♣", "♦", "♥", "♠"};

    public static void main(String[] args) {
        int count = 0;
        for (int firstFace = 0; firstFace < faces.length; firstFace++) {
            for (int secondFace = 0; secondFace < faces.length; secondFace++) {
                if (firstFace != secondFace) {
                    for (int firstSuit = 0; firstSuit < suits.length; firstSuit++) {
                        for (int secondSuit = firstSuit + 1; secondSuit < suits.length; secondSuit++) {
                            for (int thirdSuit = secondSuit + 1; thirdSuit < suits.length; thirdSuit++) {
                                for (int fourthSuit = 0; fourthSuit < suits.length; fourthSuit++) {
                                    for (int fifthSuit = fourthSuit + 1; fifthSuit < suits.length; fifthSuit++) {
                                        System.out.print("(" + faces[firstFace] + suits[firstSuit] + " " +
                                                faces[firstFace] + suits[secondSuit] + " " +
                                                faces[firstFace] + suits[thirdSuit] + " " +
                                                faces[secondFace] + suits[fourthSuit] + " " +
                                                faces[secondFace] + suits[fifthSuit] + ") ");

                                        count++;
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
