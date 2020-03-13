package by.naty.triangle.app;

import by.naty.triangle.exception.NotValidDataException;

import java.util.Scanner;

import static by.naty.triangle.validation.TypeDefinition.checkTypeOfTriangle;
import static by.naty.triangle.validation.Validation.isCorrectNumber;

class InputData {

    static void start() {
        System.out.println("Добро пожаловать!");
        System.out.println("Программа определяет тип треугольника.");
        System.out.println("Необходимо ввести 3 целых положительных числа в диапазоне от 1 до 1073741823.");
        System.out.println("  Треугольник существует, если сумма любых двух сторон больше третьей.");
        System.out.println("    Равносторонний - треугольник, у которого все стороны равны.");
        System.out.println("    Равнобедренный - треугольник, у которого 2 стороны равны.");
        System.out.println("    Неравностороний - треугольник, у которого все стороны различны.");
        while (true) {
            System.out.print("Введите сторону а: ");
            int a = inputSideOfTriangle();

            System.out.print("Введите сторону b: ");
            int b = inputSideOfTriangle();

            System.out.print("Введите сторону c: ");
            int c = inputSideOfTriangle();

            checkTypeOfTriangle(a, b, c);
        }
    }

    private static int inputSideOfTriangle() {
        while (true) {
            Scanner scan = new Scanner(System.in);
            String number = scan.nextLine();
            try {
                isCorrectNumber(number);
                return Integer.parseInt(number);
            } catch (NotValidDataException e) {
                System.out.println(e.getMessage());
            }
        }
    }
}
