using ConsoleAppForNothing;

Console.WriteLine(StaticClass.GetName());
//Console.WriteLine(NotStaticClass.GetName());

var notStatic = new NotStaticClass();
Console.WriteLine(notStatic.GetName());

Console.ReadKey();