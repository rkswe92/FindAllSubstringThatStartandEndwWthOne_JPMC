using System;
using System.Collections.Generic;
using System.Text;

namespace FindAllSubstringThatStartandEndwWthOne
{
   public class SubstringFinder
    {
        public void FindSubString( String actual, char start='1', char end='1')
        {
            int pivot =0;
            int last = 0;
            List<string> list = new List<string>();
            while(pivot< actual.Length)
            {
                if(actual[pivot]=='1')
                {
                    last = pivot + 1;
                    while(last < actual.Length)
                    {
                        if(actual[last] =='1')
                        {
                            list.Add(actual.Substring(pivot, last - pivot+1));
                        }
                        last++;
                    }
                    pivot++;
                }
                pivot++;
            }
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
