namespace Föreläsning1;

class Program
{
    static void Main(string[] args)
    {
        Tool[] toolCatalog = new Tool[]
        {
            new Tool { Name = "C#", Description = "Basic programming", Difficulty = 5 },
            new Tool { Name = "git", Description = "Source control", Difficulty = 5 },
            new Tool { Name = "SQL", Description = "Relation database", Difficulty = 5 },
            new Tool { Name = "debugging", Description = "Debugging", Difficulty = 5 },
            new Tool { Name = "Javascript", Description = "Poop", Difficulty = 5}
        };

        List<Student> students = new List<Student>();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" __   .__                                                    .__              .__          __                       \n|  | _|  | _____    ______ _____________ __ __  _____   _____|__| _____  __ __|  | _____ _/  |_  ___________  ____  \n|  |/ /  | \\__  \\  /  ___//  ___/\\_  __ \\  |  \\/     \\ /  ___/  |/     \\|  |  \\  | \\__  \\\\   __\\/  _ \\_  __ \\/    \\ \n|    <|  |__/ __ \\_\\___ \\ \\___ \\  |  | \\/  |  /  Y Y  \\\\___ \\|  |  Y Y  \\  |  /  |__/ __ \\|  | (  <_> )  | \\/   |  \\\n|__|_ \\____(____  /____  >____  > |__|  |____/|__|_|  /____  >__|__|_|  /____/|____(____  /__|  \\____/|__|  |___|  /\n     \\/         \\/     \\/     \\/                    \\/     \\/         \\/                \\/                       \\/ ");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("[1] Add student");
            Console.WriteLine("[2] Take attendance");
            Console.WriteLine("[3] Run lecture (Choose Tool)");
            Console.WriteLine("[4] Show student list");
            Console.WriteLine("[5] Show individual student details");
            Console.WriteLine("[6] Reset attendance list");
            Console.WriteLine("[7] Exit");
            Console.Write("Option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ClassroomHelper.AddStudent(students);
                    break;
                case 2:
                    ClassroomHelper.MarkAttendance(students);
                    break;
                case 3:
                    ClassroomHelper.RunLesson(students, toolCatalog);
                    break;
                case 4:
                    ClassroomHelper.PrintRoster(students);
                    Console.WriteLine("Press any key to continue");
                    break;
                case 5:
                    Console.WriteLine("5 show individual student details");
                    break;
                case 6:
                    ClassroomHelper.ResetAttendance(students);
                    break;
                case 7:
                    Console.WriteLine("7 Exit");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}

