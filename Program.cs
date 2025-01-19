Console.WriteLine("Hello! Welcome to Singleton Pattern Example");

var instance1 = SimpleSingletonExample.Instance;
var instance2 = SimpleSingletonExample.Instance;

if (instance1.Equals(instance2))
{
    Console.WriteLine("Both instances are the same");
}
else
{
    Console.WriteLine("Both instances are different");
}