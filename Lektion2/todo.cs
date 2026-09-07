using System.Net.Mime;

public class todo
{

    public static void Main(string[] args) {
        string sourcePath = "Todo_list.txt";

        if (!File.Exists(sourcePath)) {
            File.Create("Todo_list.txt").Close();
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
                break;
        }
    }
}