using System;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char n in str) {
          if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u') vowelCount++;
        }

        return vowelCount;
    }
}
