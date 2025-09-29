





public class Programmers181944
{

    public void Solution()
    {
        int number;

        number = Int32.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is even");
        }
        else
        {
            Console.WriteLine(number + " is odd");
        }
    }
}