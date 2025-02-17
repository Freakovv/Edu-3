package Task3;

public class Buffer {
    private int[] buffer = new int[10];
    private int count = 0;
    public synchronized void produce(int value) throws InterruptedException {
        // производитель ждёт
        while (count == buffer.length) {
            wait();
        }


        buffer[count] = value;
        count++;

        System.out.println("Производитель добавил: " + value);

        // будим потребителя
        notify();
    }

    public synchronized int consume() throws InterruptedException {
        // потребитель ждёт
        while (count == 0) {
            wait();
        }

        // забираем
        int value = buffer[count - 1];
        count--;

        System.out.println("Потребитель забрал: " + value);

        // будим производителя
        notify();
        return value;
    }
}