
public class todo
{
    public static void Main(string[] args) {
        string sourcePath = "Todo_list.txt";

        if (!File.Exists(sourcePath)) 
        {
            File.Create("Todo_list.txt").Close();
        }

        switch (args[0])
        {
            case "add":
                if (args.Length < 2)
                {
                    Console.WriteLine("No such command.");
                    break;
                }

                File.AppendAllLines(sourcePath, [args[1]]);
                break;

            case "done":
                if (args.Length < 2)
                {
                    Console.WriteLine("No task with that number.");
                    break;
                }

                string[] todoList = File.ReadAllLines(sourcePath);
                int taskCompleted = int.Parse(args[1]);

                if (taskCompleted < 1 || taskCompleted >= todoList.Length)
                {
                    Console.WriteLine("No task with that number.");
                    break;
                }

                int index = taskCompleted-1;
                todoList[index] = $"DONE - {todoList[index]}";
                File.WriteAllLines(sourcePath, todoList);
                break;

            case "remove":
                if (args.Length < 2)
                {
                    Console.WriteLine("No such task to remove.");
                    break;
                }

                string[] todoListForRemoval = File.ReadAllLines(sourcePath);
                int removeTask = int.Parse(args[1]);

                if (removeTask < 1 || removeTask > todoListForRemoval.Length)
                {
                    Console.WriteLine("No such task to remove.");
                    break;
                }

                int indexToRemove = removeTask-1; 
                todoListForRemoval[indexToRemove] = "";
                string[] newList = new string[todoListForRemoval.Length-1];

                int j = 0;
                for (int i = 0; i < todoListForRemoval.Length;i++)
                {
                    if (!todoListForRemoval[i].IsWhiteSpace())
                    {
                        newList[j] = todoListForRemoval[i];
                    }
                }

                File.WriteAllLines(sourcePath, newList);
                break;
        }
    }
}