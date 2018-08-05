using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Vehicle_Industry
{
    public interface IVehicleBuilder
    {
        void Model();
        void Color();
        void Engine();

        Vehicle GetVehicle();
    }
}
