

namespace VehicleCatalogue
{
    internal class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }


        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }
    }
}
