package Task3;

import java.util.ArrayList;
import java.util.List;

public class Buffer {
    private final List<Integer> buffer = new ArrayList<>();
    private final int capacity = 5;

    public synchronized void produce(int value) throws InterruptedException {
        while (buffer.size() == capacity) {
            wait();
        }

        buffer.add(value);
        System.out.println("Производитель добавил: " + value);

        notifyAll(); // Будим потребителей
        Thread.sleep(1000);
    }

    public synchronized int consume() throws InterruptedException {
        while (buffer.isEmpty()) {
            wait();
        }

        int value = buffer.remove(buffer.size() - 1);
        System.out.println("Потребитель забрал: " + value);

        notifyAll(); // Будим производителей
        Thread.sleep(1000);
        return value;
    }
}
