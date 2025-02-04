public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass()
    {
        // Initialize the property in the constructor
        MyProperty = 10;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // This will print 10
    }
}