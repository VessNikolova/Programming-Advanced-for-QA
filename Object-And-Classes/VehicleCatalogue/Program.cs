
namespace VehicleCatalogue
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while(input != "end")
            {
                string[] commands = input.Split("/");
                string type = commands[0];
                string brand = commands[1];
                string model = commands[2];
                string powerOrWeight = commands[3];
                
                if(type == "Car")
                {
                    Car car = new Car(brand, model, powerOrWeight);
                    cars.Add(car);
                }
                else if(type == "Truck")
                {
                    Truck truck = new Truck(brand, model, powerOrWeight);
                    trucks.Add(truck);
                }

                    input = Console.ReadLine();
            }

            Catalog catalog = new Catalog(cars, trucks);

            catalog.Cars = cars.OrderBy(c => c.Brand).ToList();
            catalog.Trucks = trucks.OrderBy(t => t.Brand).ToList();

            if (catalog.Cars.Any())
            {
                Console.WriteLine("Cars:");
                catalog.Cars.ForEach(c => Console.WriteLine($"{c.Brand}: {c.Model} - {c.HorsePower}hp"));
            }

            if (catalog.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
                catalog.Trucks.ForEach(t => Console.WriteLine($"{t.Brand}: {t.Model} - {t.Weight}kg"));
            }

        }
    }
}
