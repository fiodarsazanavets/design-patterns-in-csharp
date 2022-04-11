using Prototype_Demo;

var object1 = new CloneableObject("Title 1");

Console.WriteLine($"Object 1 title: {object1.Title}");
Console.WriteLine($"Object 1 data: {object1.Data}");

var object2 = (CloneableObject)object1.Clone();

Console.WriteLine($"Object 2 title: {object2.Title}");
Console.WriteLine($"Object 2 data: {object2.Data}");

Console.ReadKey();