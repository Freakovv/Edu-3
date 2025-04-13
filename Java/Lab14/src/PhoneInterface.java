import javax.swing.*;
import java.awt.*;

public class PhoneInterface {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Телефонный интерфейс");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(400, 500);
            frame.setLayout(new BorderLayout());
            frame.add(createPhoneInterface());
            frame.setVisible(true);
        });
    }

    private static JPanel createPhoneInterface() {
        JPanel panel = new JPanel(new BorderLayout());

        // Текстовое поле
        JTextArea textArea = new JTextArea(10, 20);
        textArea.setLineWrap(true);
        JScrollPane textScroll = new JScrollPane(textArea);
        panel.add(textScroll, BorderLayout.NORTH);

        // Панель с кнопками сверху
        JPanel topButtons = new JPanel(new FlowLayout(FlowLayout.CENTER, 5, 5));
        String[] topLabels = {"Кнопка 1", "Меню", "Кнопка 2"};
        for (String label : topLabels) {
            JButton button = new JButton(label);
            topButtons.add(button);
        }
        panel.add(topButtons, BorderLayout.CENTER);

        // Панель клавиатуры с растягивающимися кнопками
        JPanel keypad = new JPanel(new GridLayout(4, 3)); // Равномерное распределение кнопок
        String[] keys = {"1", "2 ABC", "3 DEF", "4 GHI", "5 JKL", "6 MNO",
                "7 PQRS", "8 TUV", "9 WXYZ", "*", "0", "#"};
        for (String key : keys) {
            JButton btn = new JButton(key);
            btn.setPreferredSize(new Dimension(100, 100)); // Пример фиксированного размера кнопки
            keypad.add(btn);
        }
        panel.add(keypad, BorderLayout.SOUTH);

        return panel;
    }
}
