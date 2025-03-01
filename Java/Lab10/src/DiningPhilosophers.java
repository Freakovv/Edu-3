import java.util.Random;

class Fork {
    private boolean isTaken = false;

    public synchronized boolean pickUp() {
        if (!isTaken) {
            isTaken = true;
            return true;
        }
        return false;
    }

    public synchronized void putDown() {
        isTaken = false;
    }
}

class Philosopher extends Thread {
    private final int id;
    private final Fork leftFork;
    private final Fork rightFork;
    private final Random random = new Random();
    private final long startTime;
    private final long duration;

    public Philosopher(int id, Fork leftFork, Fork rightFork, long startTime, long duration) {
        this.id = id;
        this.leftFork = leftFork;
        this.rightFork = rightFork;
        this.startTime = startTime;
        this.duration = duration;
    }

    private void think() throws InterruptedException {
        System.out.println("Философ " + id + " размышляет...");
        Thread.sleep(random.nextInt(1000));
    }

    private void eat() throws InterruptedException {
        System.out.println("Философ " + id + " ест...");
        Thread.sleep(random.nextInt(1000));
    }

    @Override
    public void run() {
        try {
            while (System.currentTimeMillis() - startTime < duration) {
                think();

                synchronized (leftFork) {
                    if (!leftFork.pickUp()) continue;
                    synchronized (rightFork) {
                        if (!rightFork.pickUp()) {
                            leftFork.putDown();
                            continue;
                        }

                        eat();
                        rightFork.putDown();
                    }
                    leftFork.putDown();
                }
            }
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
        }
        System.out.println("Философ " + id + " завершил выполнение.");
    }
}

public class DiningPhilosophers {
    public static void main(String[] args) {
        int philosophersCount = 5;
        long duration = 5000; // Время работы в миллисекундах
        long startTime = System.currentTimeMillis();

        Fork[] forks = new Fork[philosophersCount];
        for (int i = 0; i < philosophersCount; i++) {
            forks[i] = new Fork();
        }

        Philosopher[] philosophers = new Philosopher[philosophersCount];
        for (int i = 0; i < philosophersCount; i++) {
            philosophers[i] = new Philosopher(i, forks[i], forks[(i + 1) % philosophersCount], startTime, duration);
            philosophers[i].start();
        }

        for (Philosopher philosopher : philosophers) {
            try {
                philosopher.join();
            } catch (InterruptedException e) {
                Thread.currentThread().interrupt();
            }
        }

        System.out.println("Завершение симуляции.");
    }
}
