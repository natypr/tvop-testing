package by.naty.triangle.validation;

import by.naty.triangle.exception.NotValidDataException;

public class Validation {

    private static boolean isNotEmptyString(String strNumber) throws NotValidDataException {
        if (strNumber.isEmpty()) {
            throw new NotValidDataException("Строка пустая. " +
                    "Введите целое положительное число в диапазоне от 1 до 1073741823.");
        } else {
            return true;
        }
    }

    private static boolean isNumber(String strNumber) throws NotValidDataException {
        try {
            Integer.parseInt(strNumber);
        } catch (NumberFormatException | NullPointerException e) {
            throw new NotValidDataException("Некорректные данные. " +
                    "Введите целое положительное число в диапазоне от 1 до 1073741823.");
        }
        return true;
    }

    private static boolean isPositiveNumber(int number) throws NotValidDataException {
        if (number < 1) {
            throw new NotValidDataException("Число не положительное. " +
                    "Введите целое положительное число в диапазоне от 1 до 1073741823.");
        } else {
            return true;
        }
    }

    private static boolean isLimitedNumber(int number) throws NotValidDataException {
        int numberCorrectMax = (2147483647 - 1) / 2;
        if (number > numberCorrectMax) {
            throw new NotValidDataException("Число превышает допустимый диапазон. " +
                    "Введите целое положительное число в диапазоне от 1 до 1073741823.");
        } else {
            return true;
        }
    }

    public static boolean isCorrectNumber(String strNumber) throws NotValidDataException {
        boolean isNotEmpty = isNotEmptyString(strNumber);
        boolean isNumber = isNumber(strNumber);
        if (isNotEmpty && isNumber) {
            int number = Integer.parseInt(strNumber);
            boolean isPositive = isPositiveNumber(number);
            boolean isLimited = isLimitedNumber(number);
            if (isPositive && isLimited) {
                return true;
            }
        }
        throw new NotValidDataException("Число некорректно.");
    }
}
