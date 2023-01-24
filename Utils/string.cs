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
            /*To be continued*/
            
            for(int i = s.Length; i > 0; i--)
            {
                
            }

        }

        public static int CountVowels(string s) 
        {   
            int vowel = 0;
            for(int i = 0; i<s.Length; i++)
            {
                if(s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    vowel++;
                }
            }
            return vowel; 
        }

        public static int CountConsonants(string s) 
        {
             int consonant = 0;
            for(int i = 0; i<s.Length; i++)
            {
                if(s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
                {
                    consonant++;
                }
            }
            return consonant; 
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