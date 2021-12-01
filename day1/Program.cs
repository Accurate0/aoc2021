var lines = File.ReadAllLines(Environment.GetCommandLineArgs()[1]).Select(line => Int32.Parse(line));

// task 1
int val = lines.First();
Console.WriteLine(@$"Problem 1: {lines.Select(num =>
{
    int old = val;
    val = num;
    return num > old;
}).Count(x => x)}");

// task 2
int oldWindow = lines.Take(3).Sum();
int windowIndex = 0;
int count = 0;

for (int i = 0; i < (int)Math.Ceiling(lines.Count() / 3.0) * 3; i++)
{
    int newWindow = lines.Skip(windowIndex).Take(3).Sum();
    windowIndex++;
    if (newWindow > oldWindow)
    {
        count++;
    }

    oldWindow = newWindow;
}

Console.WriteLine($"Problem 2: {count}");
