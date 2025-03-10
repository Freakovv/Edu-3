import java.util.Random;
import java.util.concurrent.*;

public class DiningPhilosophers {
    private static final int NUM_PHILOSOPHERS = 5;
    private static final int MAX_MEALS = 5; // Ограничение
    private static final Semaphore eatingLimit = new Semaphore(2);
    private static final Fork[] forks = new Fork[NUM_PHILOSOPHERS];
    private static final Random random = new Random();

    private static final String RED = "\u001B[31m";
    private static final String GREEN = "\u001B[32m";
    private static final String DEF = "\u001B[0m";

    static long startTime = System.currentTimeMillis();

    public static void main(String[] args) {
        for (int i = 0; i < NUM_PHILOSOPHERS; i++) {
            forks[i] = new Fork();
        }

        ExecutorService executorService = Executors.newFixedThreadPool(NUM_PHILOSOPHERS);

        for (int i = 0; i < NUM_PHILOSOPHERS; i++) {
            final int philosopherId = i;
            executorService.execute(() -> {
                        long maxDuration = 50000;
                        int mealsEaten = 0;
                        while (true) {
                            if (System.currentTimeMillis() - startTime > maxDuration) {
                                System.out.println("Время философа " + philosopherId + " на покушать закончилось");
                                break;
                            }
                            try {
                                think(philosopherId);
                                if (tryEat(philosopherId)) {
                                    eat(philosopherId, ++mealsEaten);
                                    putForks(philosopherId);
                                }
                            } catch (InterruptedException e) {
                                Thread.currentThread().interrupt();
                            }
                            System.out.println("Философ " + philosopherId + " завершил еду.");
                        }
                        ;
                    });

        }

        executorService.shutdown();
        try {
            executorService.awaitTermination(50, TimeUnit.MINUTES);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("Все философы закончили есть.");
    }

    private static void think(int id) throws InterruptedException {
        System.out.println("Философ " + id + " размышляет...");
        Thread.sleep(random.nextInt(500) + 500);
    }


    private static boolean tryEat(int id) throws InterruptedException {
        Fork leftFork = forks[id];
        Fork rightFork = forks[(id + 1) % NUM_PHILOSOPHERS];

        synchronized (leftFork) {
            if (!leftFork.pickUp()) {
                Thread.sleep(random.nextInt(500) + 500);
                return false;
            }
            synchronized (rightFork) {
                if (!rightFork.pickUp()) {
                    leftFork.putDown();
                    Thread.sleep(random.nextInt(500) + 500);
                    return false;
                }
                eatingLimit.acquire();
                return true;
            }
        }
    }





    private static void eat(int id, int mealsEaten) throws InterruptedException {
        System.out.println(RED + "Философ " + id + " ест... (приём пищи #" + mealsEaten + ")" + DEF);
        Thread.sleep(5000);
    }

    private static void putForks(int id) {
        Fork leftFork = forks[id];
        Fork rightFork = forks[(id + 1) % NUM_PHILOSOPHERS];

        rightFork.putDown();
        leftFork.putDown();
        eatingLimit.release();

        System.out.println(GREEN + "Философ " + id + " закончил есть и положил вилки." + DEF);
    }
}