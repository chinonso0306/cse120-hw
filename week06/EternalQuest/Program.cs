static void Main(string[] args)
{
    GoalManager manager = new GoalManager();

    while (true)
    {
        Console.WriteLine("\n1. Create Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Show Score");
        Console.WriteLine("5. Quit");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            // Create goal logic
        }
        else if (choice == "2")
        {
            manager.DisplayGoals();
        }
        else if (choice == "3")
        {
            manager.DisplayGoals();
            Console.Write("Select goal: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            manager.RecordEvent(index);
        }
        else if (choice == "4")
        {
            manager.DisplayScore();
        }
        else if (choice == "5")
        {
            break;
        }
    }
}