using ShapesBTasks;

Console.WriteLine("Tests for your tasks");

Console.WriteLine("Task1");
Console.Write("a = 1, ");
Tasks.Task1(1);

Console.Write("a = 3, ");
Tasks.Task1(3);

Console.Write("a = 5, ");
Tasks.Task1(5);


Console.WriteLine("Task2");
Console.Write("r = 3, ");
Tasks.Task2(3);

Console.Write("r = 7, ");
Tasks.Task2(7);

Console.Write("r = 5, ");
Tasks.Task2(5);


Console.WriteLine("Task3");
Console.Write("a = 3, b = 2, c = 4, ");
Tasks.Task3(3,2,4);

Console.Write("a = 7, b = 1, c = 1, ");
Tasks.Task3(7,1,1);

Console.Write("a = 5, b = 2, c = 8, ");
Tasks.Task3(5,2,8);

Console.ReadKey();