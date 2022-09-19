
string commandList = System.IO.File.ReadAllText(@"C:\Advent\SubmarineCommands.txt");
string[] entries = commandList.Split(' ', '\n');

int x = 0;
int y = 0; //inverted for depth


for (int i = 0; i < entries.Length - 1; i+=2)
{
    if (entries[i] == "up")
    {

        y -= int.Parse(entries[i + 1]);
    }
    else if (entries[i] == "down")
    {

        y += int.Parse(entries[i + 1]);
    }
    else
    {
        x += int.Parse(entries[i+ 1]);
    }

}

Console.WriteLine("Final Product = " + x * y);

x = 0;
y = 0;
int aim = 0;
for (int i = 0; i < entries.Length - 1; i += 2)
{
    if (entries[i] == "up")
    {
        aim -= int.Parse(entries[i + 1]);
    }
    else if (entries[i] == "down")
    {
        aim += int.Parse(entries[i + 1]);
    }
    else
    {
        x += int.Parse(entries[i + 1]);
        y += int.Parse(entries[i + 1]) * aim;
    }


}
Console.WriteLine("Final Product for part 2 = " + x * y);
