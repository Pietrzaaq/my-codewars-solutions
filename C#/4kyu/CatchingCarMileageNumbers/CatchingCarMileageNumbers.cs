using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class KataIsInteresting
{
    public static int IsInteresting(int number, List<int> awesomePhrases)
    {
        int counter = 0;
      
        while (counter < 3)
        {

            if((number + counter).ToString().Length < 3 && number.ToString().Length < 1000000)
            {
                counter++;
                continue;
            }
            
            bool isInteresting = CheckIfAnyRuleAreMatched(number + counter, awesomePhrases);
          
            //If interesting number is returned on first try
            if(isInteresting && counter == 0)
            {
                return 2;
            }
          
            //If interesting number is returned after first try
            else if(isInteresting)
            {
                return 1;
            }
            counter++;
        }

        return 0;
    }

    public static bool CheckIfAnyRuleAreMatched(int number, List<int> pharses)
    {
        string numberString = number.ToString();
        bool isInteresting = true;

        //Check if matches one of awsome pharses
        if(pharses.Any())
        {        
            foreach(var pharse in pharses)
            {
                if(number == pharse) return isInteresting;
            }
        }

        //Check if the number is followed by zeros
        if(numberString.Count(x => int.Parse(x.ToString()) != 0) == 1) {return isInteresting;}

        //Check if every digit is the same number
        if(numberString.Distinct().Count() == 1) {return isInteresting;}

        //Check if digits are sequential, incementing
        bool IsAscending = false;
        for(int i = 0; i < numberString.Length - 1; i++)
        {
            IsAscending = int.Parse(numberString[i].ToString()) + 1 == int.Parse(numberString[i + 1].ToString()) || (int.Parse(numberString[numberString.Length - 2].ToString()) == 9 && numberString.Last() == '0' && i == numberString.Length - 2);
            if (!IsAscending) break;
        }
        if(IsAscending) {return isInteresting;}


        //Check if digits are sequential, decrementing
        bool IsDescending = false;
        for(int i = 0; i < numberString.Length - 1; i++)
        {
            IsDescending = int.Parse(numberString[i].ToString()) - 1 == int.Parse(numberString[i + 1].ToString()) || (int.Parse(numberString[numberString.Length - 2].ToString()) == 1 && numberString.Last() == '0' && i == numberString.Length - 2);
            if (!IsDescending) break;
        }
        if(IsDescending) {return isInteresting;}

        //Check if number is a pallindrome
        var charArr  = numberString.ToCharArray();
        Array.Reverse(charArr);
        if (new string(charArr).Equals(numberString)) {return isInteresting;}

        return !isInteresting;
    }
}