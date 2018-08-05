using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Vehicle_Industry
{
    public class Ford : IVehicleBuilder
    {
        private Vehicle _vehicle;

        public Ford()
        {
            _vehicle = new Vehicle();
        }
        public void Color()
        {
            _vehicle.Color = "Red";
        }

        public void Engine()
        {
            _vehicle.Engine = "Turbo";
        }

        public void Model()
        {
            _vehicle.Model = "2018";
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }
    }
}
