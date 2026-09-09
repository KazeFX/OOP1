string currentDirectory = Directory.GetCurrentDirectory();

string sourcePath = Path.Combine(currentDirectory, "../../../File/", "robin.txt");
string destinationPath = Path.Combine(currentDirectory, "../../../File/", "robin_summary.txt");

string[] sourceSum = File.ReadAllLines(sourcePath);

List<string> sourceWithFiveLines = new();

for (int i = 0; i < 4 && i < sourceSum.Length; i++)
{
    sourceWithFiveLines.Add(sourceSum[i]);
}

File.WriteAllLines(destinationPath, sourceWithFiveLines);