import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.math.BigDecimal;
import java.util.*;

public class ListOfProducts {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        File file = new File("src/ListOfProductsInput.txt");
        ArrayList<Product> products = new ArrayList<Product>();
        try {
            Scanner fileScanner = new Scanner(file);
            while (fileScanner.hasNext()) {
                String name = fileScanner.next();
                BigDecimal price = fileScanner.nextBigDecimal();
                products.add(new Product(name, price));
            }
        } catch (FileNotFoundException e) {
            System.out.println("Error");
        }

        Collections.sort(products);
        try {
            PrintWriter pw = new PrintWriter(new File("src/ListOfProductsOutput.txt"));
            for (Product product : products) {
                pw.println(product.toString());
            }
            pw.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }
}