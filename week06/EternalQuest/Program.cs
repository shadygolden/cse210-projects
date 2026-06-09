class Program
{
    static void Main(string[] args)
    {
        /*
        Creativity:
        Added a running score system that is saved
        and loaded with goals. Eternal goals display
        with an infinity symbol [∞].
        */

        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            manager.DisplayScore();

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select Choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;

                case 2:
                    manager.ListGoals();
                    break;

                case 3:
                    manager.RecordEvent();
                    break;

                case 4:
                    manager.SaveGoals();
                    break;

                case 5:
                    manager.LoadGoals();
                    break;
            }
        }
    }
}