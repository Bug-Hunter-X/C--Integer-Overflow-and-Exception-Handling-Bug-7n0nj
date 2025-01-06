public class MyClass {
    public int MyMethod(int a, int b) {
        if (a == 0 || b == 0) {
            return 0; // Handle division by zero
        }
        return a / b; // Potential integer overflow
    }
}