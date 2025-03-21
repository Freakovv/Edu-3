package com.example;

public class Tester {
    private String name;
    private String surname;
    private int expirienceInYears;
    private String englishLevel;
    private double salary;

    public Tester(String name, String surname, int expirienceInYears, String englishLevel, double salary) {
        this.name = name;
        this.surname = surname;
        this.expirienceInYears = expirienceInYears;
        this.englishLevel = englishLevel;
        this.salary = salary;
    }

    public Tester(String name, String surname, int expirienceInYears) {
        this(name, surname, expirienceInYears, "Средний", 1000.0);
    }

    public Tester(String name, String surname) {
        this(name, surname, 1);
    }

    public void printInfo() {
        System.out.println("Имя: " + name + ", Фамилия: " + surname);
    }

    public void printInfo(boolean includeSalary) {
        printInfo();
        if (includeSalary) {
            System.out.println("Зарплата: " + salary);
        }
    }

    public void printInfo(String additionalInfo) {
        printInfo();
        System.out.println("Дополнительная информация: " + additionalInfo);
    }

    public static void printCompanyInfo() {
        System.out.println("Компания: Mihail solution labs");
    }
}