import java.util.Random;
import java.util.concurrent.Semaphore;

class Philosopher implements Runnable {
    private final int id;
    private final Fork leftFork;
    private final Fork rightFork;
    private final Semaphore eatingLimit;
    private final Random random = new Random();
    private int mealsEaten = 0;



    public Philosopher(int id, Fork leftFork, Fork rightFork, Semaphore eatingLimit) {
        this.id = id;
        this.leftFork = leftFork;
        this.rightFork = rightFork;
        this.eatingLimit = eatingLimit;
    }

    @Override
    public void run() {
        try {
            while (!Thread.currentThread().isInterrupted()) {
                think();
                if (tryEat()) {
                    eat();
                    putForks();
                }
            }
        } catch (InterruptedException e) {
            System.out.println("Философ " + id + " завершил выполнение. Всего съел: " + mealsEaten);
        }
    }

    private void think() throws InterruptedException {
        System.out.println("Философ " + id + " размышляет...");
        Thread.sleep(random.nextInt(1000));
    }

    private boolean tryEat() throws InterruptedException {
        eatingLimit.acquire(); // Ограничиваем до 2 едящих философов
        synchronized (leftFork) {
            if (!leftFork.pickUp()) {
                eatingLimit.release();
                return false;
            }
            synchronized (rightFork) {
                if (!rightFork.pickUp()) {
                    leftFork.putDown();
                    eatingLimit.release();
                    return false;
                }
                return true;
            }
        }
    }

    private void eat() throws InterruptedException {
        mealsEaten++;
        System.out.println("Философ " + id + " ест... (приём пищи #" + mealsEaten + ")");
        Thread.sleep(random.nextInt(1000));
    }

    private void putForks() {
        rightFork.putDown();
        leftFork.putDown();
        eatingLimit.release();
    }
}