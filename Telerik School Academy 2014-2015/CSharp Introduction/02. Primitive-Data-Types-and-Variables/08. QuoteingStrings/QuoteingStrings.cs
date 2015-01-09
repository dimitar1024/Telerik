using System;
class QuoteingStrings
    {
        static void Main()
        {
            string unquoted = "The \"use\" of quotations causes difficulties";
            string quoted = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(unquoted);
            Console.WriteLine(quoted);

        }
    }

