using System;
using System.Collections.Generic;

class Solution
{
    /*
     * Complete the virusIndices function below.
     */
    static void VirusIndices(List<string> p, List<string> v)
    {
        //GetEnumerator it's a method to return an enumerator that interacts with the List.
        var pE = p.GetEnumerator();
        var vE = v.GetEnumerator();
        {
            //Using that interacts to navigate whilw the list has values on it. 
            while (pE.MoveNext() && vE.MoveNext())
            {
                //Extract current value from the list for a variable
                var pValue = pE.Current;
                var vValue = vE.Current;

                //Checking if the value Virus exists in the Patient(-1 is for not found)
                if (pValue.IndexOf(vValue) != -1) 
                    Console.WriteLine($"{pValue.IndexOfAny(vValue.ToCharArray())} {pValue.IndexOf(vValue)}"); //Printing the answer 
                else
                    Console.WriteLine("No Match!"); //Printing the answer 
            }
        }

        Console.WriteLine(Environment.NewLine + "Press enter to close...");
        Console.ReadLine();
    }
    
    static void Main(string[] args)
    {
        List<string> resultPatient = new List<string>();
        List<string> resultVirus = new List<string>();
        int t = Convert.ToInt32(Console.ReadLine());

        if (t > 0 && t < 11) //T(test cases): 1 <= T <= 10  
        {
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] pv = Console.ReadLine().Split(' ');

                if (pv[0].Length < 100000 || pv[1].Length < 100000) //P(Patient DNA) and V(Virus DNA) contain at most 100000 characters each. 
                {
                    resultPatient.Add(pv[0].ToLower());     //ToLower method convert all characters in P(Patient DNA) to lowercase letters.
                    resultVirus.Add(pv[1].ToLower());   //ToLower method convert all characters in V(Virus DNA) to lowercase letters.
                }
                else
                {
                    Console.WriteLine("P(Patient DNA) or V(Virus DNA) must contain at most 100000 characters each...");
                    Console.Read(); //Ends the console application pressing any key
                }
            }
            Console.WriteLine(Environment.NewLine + "Output:");
            VirusIndices(resultPatient, resultVirus);
        }
        else
        {
            Console.WriteLine(Environment.NewLine + "Value of T must be between 1 and 10...");
            Console.Read(); //Ends the console application pressing any key
        }
    }

}