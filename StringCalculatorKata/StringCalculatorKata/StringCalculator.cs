using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {

        public int Add(string a)
        {
            int sum = 0;
            // if it is an empty string. 
            //Supposedly using .length is more efficient than other methods
            if (a.Length == 0)
            {
                return 0; 
            }
            else
            {
                //3. and 4. 
                //Refactor to Handle new Lines instead of commas. 
                //this code will take any delimiter, omit it and turn remaining chars
                //into int's.

                //turn string into a char array
                char [] ch = a.ToCharArray();
                int num = 0;

                //loop through each element to check for digits
                foreach(char c in ch)
                {
                    if (Char.IsDigit(c))
                    {
                        num = (int)char.GetNumericValue(c); //casting to int
                        sum = sum + num;
                    }
                }
                return sum;
               

                //2. Handle Unknown Number of numbers/arguments
                //var result = from val in a.Split(',')
                //             select int.Parse(val);
                //foreach (int num in result)
                //{
                //    sum = sum + num;
                    
                //}
                //return sum;
            }  

                        
        }//end Add method




    }//end class
}
