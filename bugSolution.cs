public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Initialize the property before using it
        MyProperty = 5; 
        int value = MyProperty;
        Console.WriteLine(value); // Output will be 5

        //Now the calculation will produce the expected result
        int result = MyProperty * 10;
        Console.WriteLine(result); // Output will be 50
    }
} 

//Alternative solution using null-coalescing operator for nullable types
public class MyClass2 {
    public int? MyNullableProperty { get; set; }
    public void MyMethod2() {
        int result = (MyNullableProperty ?? 0) * 10; //Use default value 0 if null
        Console.WriteLine(result); //Output will be 0 if MyNullableProperty is null
    }
}