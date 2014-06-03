import com.itextpdf.text.*;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;
import com.itextpdf.text.pdf.fonts.otf.TableHeader;
import javafx.scene.control.Cell;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class GenerateDeckOfCards {
    private static final String OUTPUT_FILE_PATH = "DeckOfCards.pdf";

    public static void main(String[] args) {
        Document document = new Document();

        try {
            PdfWriter.getInstance(document, new FileOutputStream(OUTPUT_FILE_PATH));

            document.open();

            PdfPTable table = new PdfPTable(4);
            table.getDefaultCell().setFixedHeight(120);
            table.setHorizontalAlignment(Element.ALIGN_CENTER);

            BaseFont baseFont = BaseFont.createFont("arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font blackFont = new Font(baseFont, 50, 0, BaseColor.BLACK);
            Font redFont = new Font(baseFont, 50, 0, BaseColor.RED);

            String face;
            char suit = '\0';
            boolean isRed = false;

            for (int i = 2; i <= 14; i++) {
                switch (i) {
                    case 10:
                        face = "10";
                        break;
                    case 11:
                        face = " J";
                        break;
                    case 12:
                        face = " Q";
                        break;
                    case 13:
                        face = " K";
                        break;
                    case 14:
                        face = " A";
                        break;
                    default:
                        face = " " + i;
                        break;
                }
                for (int j = 1; j <= 4; j++) {
                    switch (j) {
                        case 1:
                            suit = '♣';
                            isRed = false;
                            break;
                        case 2:
                            suit = '♦';
                            isRed = true;
                            break;
                        case 3:
                            suit = '♠';
                            isRed = false;
                            break;
                        case 4:
                            suit = '♥';
                            isRed = true;
                            break;
                    }

                    table.addCell(new Paragraph(face + " " + suit, isRed ? redFont : blackFont));
                }
            }

            document.add(table);
            document.close();
        } catch (DocumentException e) {
            System.out.println("The document cannot be created.");
            return;
        } catch (FileNotFoundException e) {
            System.out.println("The output file was not found.");
            return;
        } catch (IOException e) {
            System.out.println("The font file was not found.");
        }

        System.out.println("Look for the file \"DeckOfCards.pdf\" in the project folder.");
    }
}
