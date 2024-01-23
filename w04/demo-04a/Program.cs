using demo_04a;

string selection = "";
Queue<GradeTask> graderQueue = new Queue<GradeTask>();

while (selection != "3") {
    Console.WriteLine($"Queue: {string.Join(",", graderQueue)}");
    Console.WriteLine("Options: ");
    Console.WriteLine("1. Add a new project to grade ");
    Console.WriteLine("2. Grade next project");
    Console.WriteLine("3. Quit ");

    selection = Console.ReadLine()!;

    if (selection == "1") {
        Console.WriteLine("Course: ");
        string course = Console.ReadLine()!;

        Console.WriteLine("Project: ");
        string project = Console.ReadLine()!;

        Console.WriteLine("Student ID: ");
        string studentId = Console.ReadLine()!;

        GradeTask task = new GradeTask(course, project, studentId);
        // TODO
    }
    else if (selection == "2") {
        // TODO
    }

    Console.WriteLine("Goodbye!");
}