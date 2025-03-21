package com.example;

public class Main {
    public static void main(String[] args) {
        Tester tester1 = new Tester("Джон", "Джонов", 5, "Продвинутый", 2000.0);
        Tester tester2 = new Tester("Роза", "Смит", 3);
        Tester tester3 = new Tester("Алиса", "Джонсон");

        tester1.printInfo();
        tester2.printInfo(true);
        tester3.printInfo("New employee");

        // статический
        Tester.printCompanyInfo();
    }
}