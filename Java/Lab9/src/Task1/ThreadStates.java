package Task1;

public class ThreadStates extends Thread {

    public ThreadStates(String name) {
        super(name);
    }

    public void run() {
        System.out.printf("%s старт... \n", getName()); // Можно просто getName()
        System.out.println("Состояние потока: " + Thread.currentThread().getState());
        try {
            Thread.sleep(500);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        System.out.printf("%s завершение... \n", getName());
    }
}
