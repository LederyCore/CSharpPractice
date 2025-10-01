using System.Text;



public class Programmers181940
{
    public string Solution(string[] my_string, int k)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < k; i++)
        {
            sb.Append(my_string);
        }

        return sb.ToString();
    }
}