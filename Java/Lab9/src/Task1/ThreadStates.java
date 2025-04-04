package Task1;

public class ThreadStates extends Thread {

    public ThreadStates(String name) {
        super(name);
    }

    public void run() {
        System.out.printf("%s старт... \n", getName());
        try {
            Thread.sleep(5000); 
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        System.out.printf("%s завершение... \n", getName());
    }
}
