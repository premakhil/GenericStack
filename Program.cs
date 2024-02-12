// See https://aka.ms/new-console-template for more information

using GenericsAssignment;

bool flag = true;

    Console.WriteLine("Enter the type of stack.");
    Console.WriteLine("1. Integer Stack");
    Console.WriteLine("2. Character Stack");
    Console.WriteLine("3. Double Stack");
    Console.WriteLine("4. Bool Stack");

    var res = Console.ReadLine();



    switch (res)
    {
        case "1": 
            GenericStack<int> IntStack = new GenericStack<int>();
            Menu<int> IntMenu = new Menu<int>(IntStack);
            IntMenu.BeginMenu();
            break;
        case "2":
            GenericStack<char> CharStack = new GenericStack<char>();
            Menu<char> CharMenu = new Menu<char>(CharStack);
            CharMenu.BeginMenu();
        break;
        case "3":
            GenericStack<double> DoubleStack = new GenericStack<double>();
            Menu<double> DoubleMenu = new Menu<double>(DoubleStack);
            DoubleMenu.BeginMenu();
        break;
        case "4":
            GenericStack<bool> BoolStack = new GenericStack<bool>();
            Menu<bool> BoolMenu = new Menu<bool>(BoolStack);
            BoolMenu.BeginMenu();
        break;
    }






//Console.WriteLine(s.Peek());