package Task3;

import java.util.Random;

public class Producer extends Thread {
    private final Buffer buffer;
    private final Random random = new Random();

    public Producer(Buffer buffer) {
        this.buffer = buffer;
    }

    @Override
    public void run() {
        int a = 0;
        try {
            int value = 1;
            while (a < 10) {
                buffer.produce(value++);
                a++;
            }
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
