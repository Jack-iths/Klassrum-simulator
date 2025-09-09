using System.Runtime.CompilerServices;

namespace Föreläsning1;

public static class ClassroomHelper
{
    public static void AddStudent(List<Student> students)
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter starting level: ");
        int level = int.Parse(Console.ReadLine());

        Student studentToAdd = new Student
        {
            Name = name,
            ProgrammingLevel = level,
            IsPresent = false,
            Tools = new List<Tool>()
        };
        students.Add(studentToAdd);
        Console.WriteLine($"Student {name} has been added to the list");
    }
    public static void PrintRoster(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students in the list");
            return;
        }
        Console.WriteLine("       _               _ _     _        \r\n  /\\ /\\ | __ _ ___ ___| (_)___| |_ __ _ \r\n / //_/ |/ _` / __/ __| | / __| __/ _` |\r\n/ __ \\| | (_| \\__ \\__ \\ | \\__ \\ || (_| |\r\n\\/  \\/|_|\\__,_|___/___/_|_|___/\\__\\__,_|\r\n                                        ");
        
        for (int i = 0; i < students.Count; i++)
        {          
            Console.WriteLine($"{i+1}. {students[i].Name} Level: {students[i].ProgrammingLevel} Present {students[i].IsPresent}");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    public static void RunLesson(List<Student> students, Tool[] toolList)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students was found, Press any key to continue");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Choose todays topic");
        for (int i = 0; i < toolList.Length; i++)
        {
            Tool t = toolList[i];
            Console.WriteLine($"[{i+1}]. {t.Name} {t.Difficulty} {t.Description} ");

        }
        Console.Write("Choose: ");
        int choice = int.Parse(Console.ReadLine());

        Tool chosenTool = toolList[choice - 1];
        int level = 5;
        int presentCount = 0;

        foreach(Student s in students)
        {
            if (s.IsPresent)
            {
                presentCount ++;
                s.ProgrammingLevel += level;

                s.LearnTool(chosenTool);
            }
        }
        if (presentCount > 0)
        {
            Console.WriteLine($"Lecture is finished in {chosenTool.Name}, {presentCount} taught. All students status has been updated");
        } else
        {
            Console.WriteLine("No students attended.");
        }

    }


    public static void MarkAttendance(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students in the list, Press any key to continue");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Is the student present? (Yes/No)");
        for (int i = 0; i < students.Count; i++)
        { 
            Console.Write($"{i+1} {students[i].Name}: ");
            string response = Console.ReadLine();
            students[i].IsPresent = (response == "yes" || response == "Yes" || response == "YES");
        }
        Console.WriteLine("Attendance updated, Press any key to continue");
        Console.ReadKey();
    }
    public static void ResetAttendance(List<Student> students)
    {
        foreach (Student student in students)
        {
         student.IsPresent = false;
        }
        Console.WriteLine("Attendence cleared");
        Console.ReadKey();
    }
}