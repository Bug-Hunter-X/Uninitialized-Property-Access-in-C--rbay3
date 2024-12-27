public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property that hasn't been initialized will result in a default value (0 for int)
        int value = MyProperty; 
        Console.WriteLine(value); // Output will be 0

        // However, if you use the property in a calculation without checking for null or default values, it might lead to unexpected results or exceptions.
        int result = MyProperty * 10; // Potential issue if MyProperty is expected to have a specific value
        Console.WriteLine(result); //Output will be 0
    }
}