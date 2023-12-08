using System;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string data)
        {
            string newData = data.ToLower();
            char[] normal = newData.ToCharArray();


            char[] reversed = new char[newData.Length];
            int x = 0;

            for (int i = newData.Length - 1; i > -1; i--)
            {
                reversed[x] = normal[i];
                x++;
            }

            string j = new string(reversed);
      
            return newData == j;
            
        }


    }
}

