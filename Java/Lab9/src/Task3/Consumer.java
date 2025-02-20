package Task3;

import java.util.Random;

public class Consumer extends Thread {
    private final Buffer buffer;
    private final Random random = new Random();

    public Consumer(Buffer buffer) {
        this.buffer = buffer;
    }

    @Override
    public void run() {
        int a = 0;
        try {
            while (a < 10) {
                buffer.consume();
                a++;
            }
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
