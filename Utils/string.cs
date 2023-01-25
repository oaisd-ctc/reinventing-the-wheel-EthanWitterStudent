namespace MyUtilities 
/*They have to be under 1 namespace */
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

        /* public static string Reverse(string s) 
        {
            /*To be continued*/ 
            
           /* for(int i = s.Length; i > 0; i--)
            {
                
            }

        } */

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

        /* public static bool HasLetter(string s, string t) 
        {
           
        }  */

        public static bool HasWord(string s) 
        {
            if (s == null)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public static string ClodsireOverride(string s) 
        {
            string ClodsireSupremacy = "Clodsire";
            return ClodsireSupremacy;
        }

        public static bool HasLetters(string s) 
        { /*Does this work? ....probably not, same issue as HasLetter*/
             if (s == null)
            {
                return false;
            }
            else if (s == "1" || s == "2" || s == "3" || s == "4" || s == "5" || s == "6" || s == "7" || s == "8" || s == "9" || s == "0")
            {
                return false;
            }
            else 
            {
                return true;
            }

        }

       public static bool IsSussy(string s) 
    { /*...Gosh I hope this works*/
        foreach (char letter in s)
        {
            if (letter == 'a' || letter == 'm' || letter == 'o' || letter == 'g' || letter == 'u' || letter == 's')
            {
                return true;
            }
            else if (letter == 'A' || letter == 'M' || letter == 'O' || letter == 'G' || letter == 'U' || letter == 'S')
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
      return false;
    } 
    }
}