namespace MyUtilities 
{
    public static class StringUtils 
    {
        public static string ToUpper(string s) 
        {
        string output = ""; 
        for (int i = 0; i < s.Length; i++)  
         {  
            
            if (s[i] >= 'a' && s[i] <= 'z')  
            {  
               output += (char)(s[i] - 'a' + 'A');  
            }  
            else  
               output += s[i];  
         }  
         return output;  
        }

        public static string ToLower(string s) 
        { /*I'm so confused...I hope this works*/
            string output = ""; 
        for (int i = 0; i < s.Length; i++)  
         {  
            
            if (s[i] >= 'A' && s[i] <= 'Z')  
            {  
               output += (char)(s[i] - 'A' + 'a');  
            }  
            else  
               output += s[i];  
         }  
         return output;  
        }

        public static int Length(string s) 
        {
            int z = s.Length;
            return z;
        }

        public static string Reverse(string s) 
        {
            foreach(int letter in s)
            {

            }

        }

        public static int CountVowels() 
        {

        }

        public static int CountConsonants() 
        {

        }

        public static bool HasLetter() 
        {

        }

        public static bool HasWord() 
        {

        }

        public static string ClodsireOverride() 
        {

        }

        public static bool HasLetters() 
        {

        }

        public static bool IsSussy() 
        {

        }






    }
}