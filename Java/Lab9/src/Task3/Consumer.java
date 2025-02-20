package Task3;

public class Consumer extends Thread {
    private final Buffer buffer;

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
