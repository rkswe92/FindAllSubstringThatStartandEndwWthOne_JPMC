using System;

namespace FindAllSubstringThatStartandEndwWthOne
{
    class Program
    {
        static void Main(string[] args)
        {
            SubstringFinder obj = new SubstringFinder();
            obj.FindSubString("00100101");
            Console.ReadKey();
        }
    }
}
