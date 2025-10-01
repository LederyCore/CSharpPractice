




using System.Text;

public class Programmers181941
{


    public string Solution(char[] arr)
    {
        var sb = new StringBuilder();

        foreach(var c in arr )
        {
            sb.Append(c);
        }

        return sb.ToString();
    }
}