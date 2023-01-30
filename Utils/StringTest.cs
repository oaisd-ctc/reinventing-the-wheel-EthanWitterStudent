using Xunit;
using MyUtilities;

    public class StringTests 
    {
       public static void StringTesting()
       {
        Assert.Equal("WAWAWEEWA", StringUtils.ToUpper("wawaweewa"));
        Assert.Equal("wawaweewa", StringUtils.ToLower("WAWAWEEWA"));
        Assert.Equal(3, StringUtils.Length("Cat"));
        Assert.Equal("god", StringUtils.Reverse("dog"));
        Assert.Equal(2, StringUtils.CountVowels("Apple"));
        Assert.Equal(3, StringUtils.CountConsonants("Apple"));
        Assert.Equal(false, StringUtils.HasLetter("Barbeque", "Federal Tax Evasion"));
        Assert.Equal(true, StringUtils.HasLetter("Barbeque", "Bar"));
        Assert.Equal(false, StringUtils.HasWord(""));
        Assert.Equal("Clodsire", StringUtils.ClodsireOverride("Emily took the kids"));
        Assert.Equal(false, StringUtils.HasLetters("69"));
        Assert.Equal(false, StringUtils.IsSussy("Red did it"));
       }
       

    }

