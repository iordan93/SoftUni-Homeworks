import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.util.Locale;
import java.util.Scanner;
import java.util.TreeSet;

public class OrderOfProducts {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        BigDecimal totalSum = new BigDecimal(0);
        TreeSet<Product> products = new TreeSet<Product>();
        try {
            Scanner fileScanner = new Scanner(new File("src/Products.txt"));
            while (fileScanner.hasNext()) {
                String name = fileScanner.next();
                BigDecimal price = fileScanner.nextBigDecimal();
                products.add(new Product(name, price));
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }

        try {
            Scanner fileScanner = new Scanner(new File("src/Order.txt"));
            while (fileScanner.hasNext()) {
                double quantity = fileScanner.nextDouble();
                String name = fileScanner.next();
                for (Product product : products) {
                    if (product.getName().equals(name)) {
                        totalSum = totalSum.add(product.getPrice().multiply(new BigDecimal("" + quantity)));
                    }
                }
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }

        try {
            PrintWriter outputWriter = new PrintWriter(new File("src/OrderOfProductsOutput.txt"));
            DecimalFormat formatter = new DecimalFormat("#0.00");
            outputWriter.println(formatter.format(totalSum));
            outputWriter.close();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }
}