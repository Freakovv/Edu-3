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

        notifyAll(); // будим потребителей
        Thread.sleep(1000);
    }



    public synchronized void consume() throws InterruptedException {
        while (buffer.isEmpty()) {
            wait();
        }

        int value = buffer.removeLast();
        System.out.println("Потребитель забрал: " + value);

        notifyAll(); // будим производителей
        Thread.sleep(1000);
    }
}
