package by.naty.triangle.validation;

public class TypeDefinition {

    private static boolean isTriangle(int a, int b, int c) {
        return (a + b > c) && (a + c > b) && (c + b > a);
    }

    private static boolean isIsoscelesTriangle(int a, int b, int c) {
        return ((a == b) || (a == c) || (b == c));
    }

    private static boolean isEquilateralTriangle(int a, int b, int c) {
        return a == c && a == b;
    }

    public static void checkTypeOfTriangle(int a, int b, int c) {
        if (isTriangle(a, b, c)) {
            if (isIsoscelesTriangle(a, b, c)) {
                if (isEquilateralTriangle(a, b, c)) {
                    System.out.println("Треугольник равносторонний.");
                } else {
                    System.out.println("Треугольник равнобедренный.");
                }
            } else {
                System.out.println("Треугольник неравносторонний.");
            }
        } else {
            System.out.println("Треугольник с данными сторонами не существует. " +
                    "Сумма любых двух сторон должна быть больше третьей.");
        }
    }
}
