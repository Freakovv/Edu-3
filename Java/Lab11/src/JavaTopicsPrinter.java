import java.util.Locale;
import java.util.ResourceBundle;

public class JavaTopicsPrinter {
    public static void main(String[] args) {
        printTopics(new Locale("en", "US"));
        printTopics(new Locale("ru", "RU"));
    }


    private static void printTopics(Locale locale) {
        ResourceBundle bundle = ResourceBundle.getBundle("topics", locale);
        System.out.println("Темы на языке " + locale.getDisplayLanguage(locale) + ":");
        for (String key : bundle.keySet()) {
            System.out.println(bundle.getString(key));
        }
        System.out.println();
    }
}
