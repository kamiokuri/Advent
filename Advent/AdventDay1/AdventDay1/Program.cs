
string[] readings = (System.IO.File.ReadAllLines(@"C:\Advent\Submarine Depth Readings.txt"));
int readingsLength = readings.Length;
int[] depths = new int[readingsLength];
for (int i = 0; i < readingsLength; i++)
{
    depths[i] = int.Parse(readings[i]);
}
int count = 0;
for (int i = 1; i < readingsLength; i++)
{
    if (depths[i] > depths[i - 1])
        count++;
}
Console.WriteLine(count);

int count2 = 0;
for (int i = 3; i < readingsLength; i++)
{
    if (depths[i] > depths[i - 3])
        count2++;
}
Console.WriteLine(count2);
