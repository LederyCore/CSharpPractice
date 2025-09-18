using System;




public class Programmers181947
{
    public void Solution()
    {
        string[] str = Console.ReadLine().Split(' ');

        int a = int.Parse(str[0]);
        int b = int.Parse(str[1]);


        Console.WriteLine(str[0] + " + " + str[1] + " = " + (a + b));
    }
}