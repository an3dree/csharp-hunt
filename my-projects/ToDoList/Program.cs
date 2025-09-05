// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to andrev task manager!");
Console.WriteLine("Lets input your first task");
Console.WriteLine("Please, choose a option from the menu below:");
Console.WriteLine("1 - List all tasks");
Console.WriteLine("2 - List to do tasks");
Console.WriteLine("3 - Create a new task");
Console.WriteLine("4 - Mark a task as done");
Console.WriteLine();
Console.WriteLine("6 - Delete a task");
//var task1Title = Console.ReadLine();
var task1Title = "titulo";

List<TaskItem> tasks = new List<TaskItem>();
int taskId = tasks.Count + 1;
Console.WriteLine(taskId);
tasks.Add(
        new TaskItem(task1Title, taskId)
                );

Console.Write("|ID|\t|Title|\t\t|Description|\t|Is Done?|\n");
Console.Write(" 1\t Teste");
Console.Write(tasks[0].Id.ToString());
Console.Write(tasks[0].Title);
//void ShowTasks(){}
//void AddNewTask(){}
//void DeleteTask(){}
//void MarkTaskDone(){}

public class TaskItem
{
        public int Id {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public bool IsDone {get; set;}

        public TaskItem(string title, int id)
        {
                Title = title;
                Id = id;
        }

        public TaskItem(string title, string description, bool isDone)
        {
                Title = title;
                Description = description;
                IsDone = isDone;

        }
}
