// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Yempo_Console;

//Display Hello World
ConsumeHelloWorld objHelloWorld = new ConsumeHelloWorld();
objHelloWorld.HelloWorld();
Console.WriteLine("");

//Display Person by Id - replace int parameter
Console.WriteLine("Get Person by Id");
ConsumePersonById objPersonById = new ConsumePersonById();
objPersonById.GetPersonById(2);
Console.WriteLine("");

//Display Person by Id - replace int parameter
Console.WriteLine("Get all Persons");
ConsumePersons objPersons = new ConsumePersons();
objPersons.GetPersons();

Console.Read();