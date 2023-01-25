namespace MyUtilities 
/*They have to be under 1 namespace */
{
    public static class StringUtils 
    {   /*Note: Summaries are ABOVE their respective functions*/

        ///<summary>
        ///Captilizes an entire string
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///output, the capitalized version of s
        ///</returns>
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
        
        ///<summary>
        ///Changes an entire string to lowercase
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///output, the lower-cased version of s
        ///</returns>
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

        ///<summary>
        ///Provides the length of a given string as a number
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///z, the length of s
        ///</returns>
        public static int Length(string s) 
        {
            int z = s.Length;
            return z;
        }

        ///<summary>
        ///Reverses the order of a string
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///NotSoup, a reversed version of s
        ///</returns>
        public static string Reverse(string s) 
        {    
        char[] NotSoup = new char[s.Length];
        int iTheSecond = 0;
        for(int i = s.Length - 1; i >= 0; i--) {
            NotSoup[iTheSecond] = s[i];
            iTheSecond++;
        }

        return new string(NotSoup); 
        } 

        ///<summary>
        ///Provides the amount of vowels in a given string as a number
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///vowel, the number of vowels in s
        ///</returns>
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

        ///<summary>
        ///Provides the amount of consonants in a given string as a number
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///consonant, the number of consonants in s
        ///</returns>
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

        ///<summary>
        ///Searches string s for string t
        ///</summary>
        ///<param name="s"> The string being searched
        ///<param name="t"> The string being searched for
        ///<returns>
        ///True if t is found in s, otherwise False
        ///</returns>
         public static bool HasLetter(string s, string t) 
        {
           for(int i = 0; i < s.Length; i++) 
           {
            if (s[i] == t[0])
            {
                for(int g = 0; g <= t.Length; g++)
                {
                    if (t[g] == s[i]+g)
                    {
                        continue;
                    }
                    else if (g == t.Length)
                    {
                        return true; 
                    }
                    else 
                    {
                        break; 
                    }
                }
            }
            else 
            {
             continue; 
            }
           }
          return false; 
        }  

        ///<summary>
        ///Checks to see if s has content
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///False if s is found Null, otherwise True
        ///</returns>
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

        ///<summary>
        ///Clodsire
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///ClodsireSupremacy, a string simply reading "Clodsire"
        ///</returns>
        public static string ClodsireOverride(string s) 
        {
            string ClodsireSupremacy = "Clodsire";
            return ClodsireSupremacy;
        }
        
        ///<summary>
        ///Checks to see if s has content AND doesn't have numbers
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///False if s is found Null OR contains numbers, otherwise True
        ///</returns>
        public static bool HasLetters(string s) 
        { /*Does this work? ....probably not, same issue as HasLetter*/
          /*Update: this will likely need to be reworked*/
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

        ///<summary>
        ///Checks to see if s is sussy baka
        ///</summary>
        ///<param name="s"> The string going in
        ///<returns>
        ///True if s contains the letters A, M, O, G, U, or S, otherwise False
        ///</returns>
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
                continue;
            }
        }
      return false;
    } 
    }
}