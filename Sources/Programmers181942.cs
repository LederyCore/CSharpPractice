




public class Programmers181942
{


    public string Solution(string str1, string str2)
    {
        string result = string.Empty;
        for (int i = 0;  i < str1.Length; i++)
        {
            result = result + str1[i] + str2[i];
        }

        return result;
    }
}