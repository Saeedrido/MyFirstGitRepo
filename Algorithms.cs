using System;

namespace Company.ClassLibrary1;

public class Algorithms
{

  public static List<int> GetVowelPosition(string s)
  {
    List<int> vowelsPosition = new List<int>();

    char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

    for (int i = 0; i < s.Length; i++)
    {
      foreach (var item in vowels)
      {
        if (s[i] == item)
        {
          vowelsPosition.Add(i);
        }
      }

    }
    return vowelsPosition;
  }

  // Question 2.
  public static string ShiftLetters(string inputString)
  {
    char[] newChars = new char[inputString.Length];

    for (int i = 0; i < inputString.Length; i++)
    {
      char currentChar = inputString[i];

      if (currentChar >= 'a' && currentChar <= 'z')
      {
        newChars[i] = currentChar == 'z' ? 'a' : (char)(currentChar + 1);
      }
      else if (currentChar >= 'A' && currentChar <= 'Z')
      {
        newChars[i] = (currentChar == 'Z') ? 'A' : (char)(currentChar + 1);
      }
      else
      {
        newChars[i] = currentChar;
      }
    }
    return new string(newChars);
  }

  // Question 3.
  public static string TransFormCase(string inputString)
  {
    char[] newChars = new char[inputString.Length];

    for (int i = 0; i < inputString.Length; i++)
    {
      char currentChar = inputString[i];

      if (currentChar >= 'a' && currentChar <= 'z')
      {
        newChars[i] = (currentChar == 'z') ? 'a' : (char)(currentChar - 32);
      }
      else if (currentChar >= 'A' && currentChar <= 'Z')
      {
        newChars[i] = (currentChar == 'Z') ? 'A' : (char)(currentChar + 32);
      }
      else
      {
        newChars[i] = currentChar;
      }
    }
    return new string(newChars);
  }


  // Question 4.
  public static string ReplaceCharacter(string str, char c1, char c2)
  {
    List<char> result = new List<char>();

    foreach (char ch in str)
    {
      if (ch == c1)
      {
        result.Add(c2);
      }
      else
      {
        result.Add(ch);
      }
    }

    return new string(result.ToArray());
  }

  // NUMBER 5.
  public static string SwapPairs(string s)
  {
    char[] arr = new char[s.Length];

    for (int i = 0; i < s.Length -1; i += 2)
    {
      arr[i] = s[i + 1];
      arr[i + 1] = s[i];


    }
    if (s.Length % 2 != 0)
    {
      arr[s.Length - 1] = s[s.Length - 1];
    }

    return new string(arr);
  }

}
