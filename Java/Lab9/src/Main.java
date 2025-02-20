import Task1.*;
import Task2.*;
import Task3.*;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws InterruptedException {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("\nВыберите задание:");
            System.out.println("1 - Задание 1 (Состояния потока)");
            System.out.println("2 - Задание 2 (Два потока по очереди)");
            System.out.println("3 - Задание 3 (Производитель и потребитель)");
            System.out.println("0 - Выход");

            int choice = scanner.nextInt();

            if (choice == 0) {
                System.out.println("Выход...");
                break;
            }

            switch (choice) {
                case 1:
                    executeTask1();
                    break;
                case 2:
                    executeTask2();
                    break;
                case 3:
                    executeTask3();
                    break;
                default:
                    System.out.println("Неверный ввод, попробуйте снова.");
            }
        }
        scanner.close();
    }

    private static void executeTask1() throws InterruptedException {
        System.out.println("Задание 1");

        ThreadStates thread = new ThreadStates("MyThread");
        System.out.println("Состояние потока перед стартом: " + thread.getState());
        thread.start();

        System.out.println("Состояние потока после запуска: " + thread.getState());

        Thread.sleep(1000);
        System.out.println("Состояние потока во время сна: " + thread.getState());

        thread.join();
        System.out.println("Состояние потока после завершения: " + thread.getState());
    }


    private static void executeTask2() {
        System.out.println("Задание 2");

        ThreadPrint thread1 = new ThreadPrint("Thread-1", true);
        ThreadPrint thread2 = new ThreadPrint("Thread-2", false);

        thread1.start();
        thread2.start();

        try {
            thread1.join();
            thread2.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("Оба потока завершились. Возвращаемся в меню...");
    }

    private static void executeTask3() {
        System.out.println("Задание 3");

        Buffer buffer = new Buffer();
        Producer producer = new Producer(buffer);
        Consumer consumer = new Consumer(buffer);

        producer.start();
        consumer.start();

        try {
            producer.join();
            consumer.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }

        System.out.println("Производитель и потребитель завершили работу. Возвращаемся в меню...");
    }
}