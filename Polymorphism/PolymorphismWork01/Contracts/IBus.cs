using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
{
    public interface IBus : IVehicle
    {
        string DriveFull(double distance);

    }
}
