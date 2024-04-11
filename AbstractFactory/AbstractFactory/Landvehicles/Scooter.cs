using System;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("encomenda na mochila");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega com patinete!");
        }
    }
}