// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
    
int fluentCount = 5;
int stateCount = (int)Math.Pow(2, fluentCount);
int[][] state = new int[stateCount][];
int t = 0;
string s = "";
for (int i = 0; i < stateCount; i++)
{
    state[i] = new int[fluentCount];
    for (int j = 0; j < fluentCount; j++)
    {
        t = i;
        t %= ((int)Math.Pow(2, j + 1));
        t /= ((int)Math.Pow(2, j));
        state[i][j] = t;
        s += t;
    }
    Console.WriteLine(s);
    s = "";
}