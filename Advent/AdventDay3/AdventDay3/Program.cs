string[] binaryList = System.IO.File.ReadAllLines(@"C:\Advent\Day3Input.txt");
int length = binaryList[0].Length;
string binary = "";
string reverseBinary = "";
for (int i = 0; i < length; i++) {
    int tempCount = 0;
    
    for (int j = 0; j < binaryList.Length; j++)
    {
        string temp = binaryList[j];

        if (temp[i] == '1')
        {
            tempCount++;
        }
        else tempCount--;
    }
    if (tempCount > 0)
    {
        binary += '1';
        reverseBinary += '0';
    }
    else 
    {
        binary += '0';
        reverseBinary += '1';
    }
}
Console.WriteLine("First Answer: " + Convert.ToInt32(binary, 2) * Convert.ToInt32(reverseBinary, 2));

List<int> One = new List<int>();
List<int> Zero = new List<int>();
for (int i = 0; i < binaryList.Length; i++)
{
    string temp = binaryList[i];

    if (temp[0] == '1')
    {
        One.Add(i);
    }
    else Zero.Add(i);
}

List<int> Majority;
List<int> Minority;
if (One.Count >= Zero.Count)
{
    Majority = One;
    Minority = Zero;
}
else
{
    Majority = Zero;
    Minority = One;
}



int count = 1;
bool end = false;
while (!end)
{
    One = new List<int>();
    Zero = new List<int>();
    foreach (int val in Majority)
    {
        string temp = binaryList[val];

        if (temp[count] == '1')
        {
            One.Add(val);
        }
        else if (temp[count] == '0')
        {
            Zero.Add(val);
        }
    }
    if (One.Count >= Zero.Count)
    {
        Majority = One;
    }
    else
    {
        Majority = Zero;
    }
    count++;
    if( Majority.Count == 1)
    {
        end = true;
    } 

}


count = 1;
end = false;
while (!end)
{
    One = new List<int>();
    Zero = new List<int>();
    foreach (int val in Minority)
    {
        string temp = binaryList[val];

        if (temp[count] == '1')
        {
            One.Add(val);
        }
        else if (temp[count] == '0')
        {
            Zero.Add(val);
        }
    }
    if (One.Count >= Zero.Count)
    {
        if(Zero.Count == 0)
        {
            Minority = One;
            end = true;
        }
        else Minority = Zero;
    }
    else
    {
        if (One.Count == 0)
        {
            Minority = Zero;
            end = true;
        }
        else Minority = One;
    }
    count++;
}

Console.WriteLine("Second Answer: " + Convert.ToInt32(binaryList[Majority[0]], 2) * Convert.ToInt32(binaryList[Minority[0]], 2));
