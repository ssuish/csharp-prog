﻿// ===========================================================
// Object Oriented Programming with C# 
/*
    Links for reference: 
    - https://zetcode.com/lang/csharp/oopi/
    - https://zetcode.com/lang/csharp/oopii/
    - https://zetcode.com/lang/csharp/methods/
    - https://zetcode.com/lang/csharp/properties/
    - https://zetcode.com/lang/csharp/structures/
    - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes-and-structs
*/
// ===========================================================

// Object Attributes and Instances
var person = new Person("ABC");
Console.WriteLine(person.Name);
// Expected: ABC

var person2 = new Person("DEF");
Console.WriteLine(person2.Name);
// Expected: DEF

// with Constructor Chaining
var person3 = new Person("GHI", 30);
Console.WriteLine($"{person3.Name} is {person3.Age} years old");
// Expected: GHI is 30 years old

// with method overriding
Console.WriteLine(person3.ToString());
// Expected: GHI is 30 years old

// Object Initializer with empty constructor
var person4 = new Person { Name = "JKL", Age = 40 };
Console.WriteLine($"{person4.Name} is {person4.Age} years old");
// Expected: JKL is 40 years old

// Calling expression-bodied constructor
var Job = new Job("Someone", 1200);
Console.WriteLine(Job.ToString());
// Expected: Someone is 1200 dollars