using System;
using System.Collections.Generic;
using System.Linq;
using Vehicles.Core;
using Vehicles.Core.Contracts;
using Vehicles.IO;
using Vehicles.IO.Contracts;

namespace Vehicles
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
