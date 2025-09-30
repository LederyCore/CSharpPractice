



public class Programmers181943
{



    public string Solution(string my_string, string overwrite_string, int s)
    {
        string result = string.Empty;
        char[] my = my_string.ToCharArray();
        char[] overwrite = overwrite_string.ToCharArray();
        for (int i = 0; i < overwrite_string.Length; i++)
        {
            my[i + s] = overwrite[i];
        }

        for (int i = 0; i < my.Length; i++)
        {
            result = result + my[i];
        }


        return result;
    }
}