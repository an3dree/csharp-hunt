// See https://aka.ms/new-console-template for more information
using System.Text.Json;


string path = "./workspace/dotnet/csharp-hunt/my-projects/ToDoList/tasks.json";

        List<TaskItem> tasks = new List<TaskItem>();
if (File.Exists(path))
{
        string fileContent = File.ReadAllText(path);
        Console.WriteLine($"File loaded: {fileContent}");
        List<TaskItem> loadedTasks = JsonSerializer.Deserialize<List<TaskItem>>(fileContent);
        foreach (TaskItem task in loadedTasks)
        {
               tasks.Add(task); 
        }

}

int userOption = 0;

do
{
        Console.WriteLine();
        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
        
        Console.WriteLine("Welcome to andrev task manager!");

        Console.WriteLine("Please, choose a option from the menu below:");
        Console.WriteLine("1 - List all tasks");
        Console.WriteLine("2 - List to do tasks");
        Console.WriteLine("3 - Create a new task");
        Console.WriteLine("4 - Mark a task as done");
        Console.WriteLine("5 - Edit a task");
        Console.WriteLine("6 - Delete a task");
        Console.WriteLine("7 - Exit the program");
        Console.WriteLine();
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");

        var userInput = Console.ReadLine();
        userOption = int.Parse(userInput);
        Console.WriteLine(userOption);
        switch (userOption){
                case 1:
                        ShowTasks();
                        break;
                case 2:
                        ShowToDoTasks();
                        break;
                case 3:
                        AddNewTask();
                        break;
                case 4:
                        MarkTaskDone();
                        break;
                case 5:
                        EditTask();
                        break;
                case 6:
                        DeleteTask();
                        break; 
}

} while (userOption != 7);



Console.WriteLine("Thank you for using andrev task manager!");


var data = JsonSerializer.Serialize(tasks);

File.WriteAllText(path, data);



// end of main class

void ShowTasks(){

        Console.Write("|ID|\t|Title|\t\t|Description|\t|Is Done?|\n");
        Console.WriteLine(" -- \t ----- \t\t --------- \t -------");
        foreach (TaskItem task in tasks)
        {
                Console.Write($"{task.Id}\t");
                Console.Write($"{task.Title}\t\t");
                Console.Write($"{task.Description}\t");
                Console.Write($"{task.IsDone}");        
                Console.WriteLine();
        }
}

void ShowToDoTasks()
{                
        Console.Write("|ID|\t|Title|\t\t|Description|\t|Is Done?|\n");
        
        Console.WriteLine(" -- \t ----- \t\t --------- \t -------");
        foreach (TaskItem task in tasks) 
        {
                if(!task.IsDone)
                {
                        Console.Write(task.Id);
                        Console.Write(task.Title);
                        Console.Write(task.Description);
                }
        }
        Console.WriteLine();
}

void AddNewTask()
{
        var taskId = tasks.Count + 1;
        Console.WriteLine("Lets add a new task");
        Console.WriteLine("Type the title of the task");
        var taskTitle = Console.ReadLine();
        Console.WriteLine("Tell the description of the task");
        var taskDesc = Console.ReadLine();

        tasks.Add(new TaskItem(taskId, taskTitle, taskDesc, false));
        Console.WriteLine($"Task added: Title: {taskTitle}, ID: {taskId}");
        Console.WriteLine();
}

void DeleteTask()
{
        Console.WriteLine("Lets remove a task from the list");
        Console.WriteLine("Please, type the ID of the task");
        int taskId = int.Parse(Console.ReadLine());
        TaskItem taskToRemove = tasks.Single(t => t.Id == taskId);
        tasks.Remove(taskToRemove);

        Console.WriteLine($"Task with ID: {taskId} was removed");
}

void EditTask()
{
        Console.WriteLine("Lets edit Title and Description of a task");
        Console.WriteLine("Please, type the ID of the task");

        int taskId = int.Parse(Console.ReadLine());

        TaskItem taskToEdit = tasks.Single(t => t.Id == taskId);
        Console.WriteLine("Please inform the new title of the task:");
        string newTitle = Console.ReadLine();
        Console.WriteLine("Please inform the new description of the task");
        string newDesc = Console.ReadLine();

        taskToEdit.Title = newTitle;
        taskToEdit.Description = newDesc;

        Console.WriteLine("Not implemented yet");
        Console.WriteLine($"Task with ID: {taskId} sucessfull updated");
}

void MarkTaskDone()
{

        Console.WriteLine("Not implemented yet");
}

public class TaskItem
{
        public int Id {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public bool IsDone {get; set;}

        public TaskItem(){}

        public TaskItem(int id, string title)
        {
                Title = title;
                Id = id;
        }

        public TaskItem(int id, string title, string description, bool isDone)
        {
                Id = id;
                Title = title;
                Description = description;
                IsDone = isDone;

        }
}
