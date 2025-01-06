using System;

public class MyClass {
    public int MyMethod(int a, int b) {
        if (b == 0) {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        try {
            return checked(a / b); // Checked arithmetic to detect overflow
        } catch (OverflowException ex) {
            throw new Exception("Integer overflow occurred during division: " + ex.Message, ex);
        }
    }
}