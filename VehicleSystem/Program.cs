namespace VehicleSystem
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Car car = new Car();
            car.Brand = "Toyota";
            car.Start();
            car.ShowInfo();

            Console.WriteLine();

            Motorcycle bike = new Motorcycle();
            bike.Brand = "Honda";
            bike.Start();
            bike.ShowInfo();
        }
    }
}