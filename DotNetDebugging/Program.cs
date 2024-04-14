using System.Diagnostics;
int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum;
//Find The Logic Error using debug you will find the Answer in Solve.txt
    for (int i = 2; i < n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }
//Anthore way to Debug
//You can use the Next funcation to debug the program
//use This will Print if condition is not qual
// Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
//use This will Print if condition is qual
//Debug.WriteLineIf(n2==0,"This will Print if the condition is qual")
    return n == 0 ? n1 : n2;
}