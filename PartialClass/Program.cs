// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//normal tuple

var a = ("nitin", 1, "hello", 5);


Console.WriteLine(a.Item1);
Console.WriteLine(a.Item2); 
Console.WriteLine(a.Item3); 
Console.WriteLine(a.Item4);



//named tuple
var b = (name: "nitin", age: 12);



//tuple Deconstruction
var (name, age, designation )= ("nitin", 12, "Coprate");