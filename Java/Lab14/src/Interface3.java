import javax.swing.*;
import javax.swing.tree.DefaultMutableTreeNode;
import java.awt.*;

public class Interface3 {
    public static void main(String[] args) {
        JFrame frame = new JFrame("Интерфейс 3");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(600, 400);

        // панель с метками
        JPanel topPanel = new JPanel(new GridLayout(2, 4));
        for (int i = 0; i < 7; i++) {
            topPanel.add(new JLabel("Метка " + i));
        }

        // файлы
        DefaultMutableTreeNode root = new DefaultMutableTreeNode("JTree");
        DefaultMutableTreeNode childRoot = new DefaultMutableTreeNode("папка с цветами");
        root.add(childRoot);
        childRoot.add(new DefaultMutableTreeNode("цвет1"));
        childRoot.add(new DefaultMutableTreeNode("цвет2"));
        root.add(new DefaultMutableTreeNode("спорт"));
        root.add(new DefaultMutableTreeNode("еда"));
        JTree tree = new JTree(root);
        JScrollPane treeScroll = new JScrollPane(tree);

        // слайдер
        JSlider slider = new JSlider(JSlider.VERTICAL);

        // панель со слайдером
        JPanel leftPanel = new JPanel();
        leftPanel.setLayout(new BoxLayout(leftPanel, BoxLayout.Y_AXIS));
        leftPanel.add(slider);

        // панель с деревом файлов
        JPanel centerPanel = new JPanel(new BorderLayout());
        centerPanel.add(treeScroll, BorderLayout.CENTER);

        // панель с текстовыми полями
        JPanel rightPanel = new JPanel(new GridLayout(8, 1));
        for (int i = 1; i <= 8; i++) {
            rightPanel.add(new JTextField("Текстовое поле " + i));
        }

        // панель с чекбоксом, радиобаттоном, кнопкой и текстовым полем
        JPanel bottomPanel = new JPanel();
        bottomPanel.add(new JCheckBox("Выбор 1"));
        bottomPanel.add(new JRadioButton("Выбор 2"));
        bottomPanel.add(new JButton("Кнопка"));
        bottomPanel.add(new JTextField("Текстовое поле"));

        // компоновка
        frame.setLayout(new BorderLayout());
        frame.add(topPanel, BorderLayout.NORTH);
        frame.add(leftPanel, BorderLayout.WEST);
        frame.add(centerPanel, BorderLayout.CENTER);
        frame.add(rightPanel, BorderLayout.EAST);
        frame.add(bottomPanel, BorderLayout.SOUTH);

        frame.setVisible(true);
    }
}
