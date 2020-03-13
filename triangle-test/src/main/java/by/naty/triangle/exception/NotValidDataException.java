package by.naty.triangle.exception;

public class NotValidDataException extends Exception {

    public NotValidDataException() {
    }

    public NotValidDataException(String message) {
        super(message);
    }

    public NotValidDataException(String message, Throwable cause) {
        super(message, cause);
    }

    public NotValidDataException(Throwable cause) {
        super(cause);
    }
}
