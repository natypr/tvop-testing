/*
package by.naty.triangle.validation;

import by.naty.triangle.exception.NotValidDataException;
import org.junit.Test;

import static by.naty.triangle.validation.Validation.isNotEmptyString;
import static org.junit.Assert.*;

public class ValidationTest {

    @Test
    public void isCorrectNumber() {
    }

    @Test
    public void whenIsNotEmptyString_thenAssertionSucceeds() throws NotValidDataException {
        assertTrue(isNotEmptyString("erw"));
        assertTrue(isNotEmptyString("35"));
    }

    @Test
    public void whenExceptionThrown_thenAssertionSucceeds() {
        Exception exception = assertThrows(NumberFormatException.class, () -> {
            Integer.parseInt("1a");
        });

        String expectedMessage = "For input string";
        String actualMessage = exception.getMessage();

        assertTrue(actualMessage.contains(expectedMessage));
    }


    @Test(expected = NotValidDataException.class)
    public void whenExceptionThrown_thenExpectationSatisfied() {
        String test = null;
        test.length();
    }

}
*/
