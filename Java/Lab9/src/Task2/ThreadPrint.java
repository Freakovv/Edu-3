package Task2;

public class ThreadPrint extends Thread {
    private static final Object lock = new Object();  // объект для синхронизации
    private static boolean isFirstTurn = true;        // для чередования потоков
    private final boolean isFirst;                    // какой поток первый

    public ThreadPrint(String name, boolean isFirst) {
        super(name);
        this.isFirst = isFirst;
    }

    @Override
    public void run() {
        for (int i = 0; i < 5; i++) {
            synchronized (lock) {
                while (isFirst != isFirstTurn) {
                    try {
                        lock.wait();
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }

                System.out.println(Thread.currentThread().getName());
                isFirstTurn = !isFirstTurn; // смена очереди
                lock.notifyAll();
            }

            try {
                Thread.sleep(1500);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
