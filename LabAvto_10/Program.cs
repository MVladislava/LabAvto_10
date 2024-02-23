using System.ComponentModel.DataAnnotations;
using Cars;
namespace LabaAvto_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Show();
            LightCar lightCar = new LightCar(2,300);
            lightCar.Show();
            OffRoad offRoad = new OffRoad();
            offRoad.Show();
            Truck truck = new Truck();
            truck.Show();
        }
    }
}