import Task1.*;
import Task2.*;
import Task3.*;

public class Main {
    public static void main(String[] args) {
        System.out.println("Задание 1");


        ThreadStates thread = new ThreadStates("MyThread");
        System.out.println("Состояние потока перед стартом: " + thread.getState());
        thread.start();
        System.out.println("Состояние потока перед стартом: " + thread.getState());

        try {
            thread.join(); // Ждём завершения потока
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("Состояние потока после завершения: " + thread.getState());

        System.out.println("Задание 2:");
        ThreadPrint threadPrint = new ThreadPrint("MyThread");
        threadPrint.start();

        System.out.println("Задание 3:");

        Buffer buffer = new Buffer();  // Общий буфер

        Producer producer = new Producer(buffer);  // Создаем производителя
        Consumer consumer = new Consumer(buffer);  // Создаем потребителя

        producer.start();  // Запуск потока производителя
        consumer.start();  // Запуск потока потребителя
    }
}
