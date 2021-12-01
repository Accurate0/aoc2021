var lines = File.ReadAllLines(Environment.GetCommandLineArgs()[1]).Select(line => Int32.Parse(line));

// task 1
int val = lines.First();

Console.WriteLine("Problem 1: {0}",
    lines.Select(num =>
    {
        int old = val;
        val = num;

        return num > old;
    }).Count(x => x)
);

// task 2
int oldWindow = lines.Take(3).Sum();
int windowIndex = 0;

Console.WriteLine("Problem 2: {0}",
    Enumerable.Range(0, (int)Math.Ceiling(lines.Count() / 3.0) * 3).Select(_ =>
    {
        int newWindow = lines.Skip(windowIndex).Take(3).Sum();
        int old = oldWindow;
        oldWindow = newWindow;
        windowIndex++;

        return newWindow > old;
    }).Count(x => x)
);
