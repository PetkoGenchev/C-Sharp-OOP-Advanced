using System;
using System.Collections.Generic;
using Military.Contracts;
using Military.Core;
using Military.Core.Contracts;
using Military.IO;
using Military.IO.Contracts;

namespace Military
{
    public class Program
    {
        static void Main()
        {

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IEngine engine = new Engine(reader,writer);

            engine.Run();

        }
    }
}
