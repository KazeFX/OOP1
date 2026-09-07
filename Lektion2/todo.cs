using System.Net.Mime;
using System.Xml;

public class todo
{

    public static void Main(string[] args) {
        string sourcePath = "Todo_list.txt";

        if (!File.Exists(sourcePath)) {
            File.Create("Todo_list.md").Close();
        }
        

        switch (args[0])
        {
            case "add":
                string input;
                File.AppendAllText(sourcePath, args[1]);
                if (args[2] != null && args[2] == "--due")
                {
                    File.AppendAllText(sourcePath, $"  tills {args[3]}");
                }
                File.AppendAllLines(sourcePath, ["\n"]);
            break;

            case "done":
                string[] todoList = File.ReadAllLines(sourcePath);
                int taskCompleted = int.Parse(args[1]);
                todoList[taskCompleted] = $"~~{todoList[taskCompleted]}~~";
                File.AppendAllLines(sourcePath, todoList);
                break;

            case "remove":
                string[] todoList2 = File.ReadAllLines(sourcePath);
                int removeTask = int.Parse(args[1]);
                todoList2[removeTask] = "";
                break;
        }
    }
}