import java.text.NumberFormat;
import java.util.Locale;
import java.util.ResourceBundle;

public class FullReport {
    public static void main(String[] args) {
        Employee[] employees = {
                new Employee("Petrovich Petr", 1234.50),
                new Employee("Alekseevich Aleksey", 2345.75),
                new Employee("Yaroslavov Yarik", 3456.00)
        };

        printFullReport(new Locale("en", "US"), employees);
        printFullReport(new Locale("ru", "RU"), employees);
    }

    public static void printFullReport(Locale locale, Employee[] employees) {
        ResourceBundle bundle = ResourceBundle.getBundle("report", locale);
        String title = bundle.getString("report.title");
        NumberFormat currencyFormat = NumberFormat.getCurrencyInstance(locale);

        double exchangeRate = 80.0;

        System.out.println(title);
        for (Employee emp : employees) {
            double salaryInLocalCurrency = emp.salary;

            if (locale.getCountry().equals("RU")) {
                salaryInLocalCurrency = emp.salary * exchangeRate;
            }

            String formattedSalary = currencyFormat.format(salaryInLocalCurrency);
            System.out.printf("%-20s %10s%n", emp.fullname, formattedSalary);
        }
        System.out.println();
    }
}
