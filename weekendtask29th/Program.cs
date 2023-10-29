using weekendtask29th;


Vehicle[] vehicles = new Vehicle[20];
int vehicleCount = 0;

void CreateaCar()
{
    Car car = new Car();    
    Console.WriteLine("You created a Car");

    Console.Write("Enter the number of doors: ");
    int doorCount = Convert.ToInt32(Console.ReadLine());

    while (doorCount <= 0 || doorCount > 10)
    {
        Console.WriteLine("That's not a valid number of doors. Please try again.");
        Console.Write("Enter the number of doors: ");
        doorCount = Convert.ToInt32(Console.ReadLine());
    }
    

    Console.Write("Enter the Win Code: ");
    int winCode = Convert.ToInt32(Console.ReadLine());
    car.WinCode = winCode;

    Console.Write("Enter the Horse Power : ");
    int HorsePower = Convert.ToInt32(Console.ReadLine());
    car.HorsePower = HorsePower;

    Console.Write("Enter the Tanksize : ");
    int TankSize = Convert.ToInt32(Console.ReadLine());
    car.TankSize = TankSize;    

    Console.Write("Enter the CurrentOil : ");
    int CurrentOil = Convert.ToInt32(Console.ReadLine());
    car.CurrentOil = CurrentOil;

    Console.Write("Enter the FuelType : ");
    string FuelType = Console.ReadLine();
    car.FuelType = FuelType;

    Console.Write("Enter the WheelThickness : ");
    int WheelThickness = Convert.ToInt32(Console.ReadLine());
    car.WheelThickness = WheelThickness;
    
    vehicles[vehicleCount] = car;
    vehicleCount++;
}
void CreateNewBicycle()
{
    Bicycle bicycle = new Bicycle();
    Console.WriteLine("Your created a bike");

    Console.Write("Enter the Pedal Kind : ");
    string PedalKind = Console.ReadLine();
    bicycle.PedalKind = PedalKind;

    Console.Write("Enter the Wheel Thickness : ");
    int WheelThickness = Convert.ToInt32(Console.ReadLine());
    bicycle.WheelThickness = WheelThickness;

    vehicles[vehicleCount] = bicycle;
    vehicleCount++;
}

void CreateNewPlane()
{
    Plane plane= new Plane();
    Console.WriteLine("Your created a plane");

    Console.Write("Enter the Horse Power : ");
    int HorsePower = Convert.ToInt32(Console.ReadLine());
    plane.HorsePower = HorsePower;

    Console.Write("Enter the Tanksize : ");
    int TankSize = Convert.ToInt32(Console.ReadLine());
    plane.TankSize = TankSize;

    Console.Write("Enter the CurrentOil : ");
    int CurrentOil = Convert.ToInt32(Console.ReadLine());
    plane.CurrentOil = CurrentOil;

    Console.Write("Enter the FuelType : ");
    string FuelType = Console.ReadLine();
    plane.FuelType = FuelType;

    Console.Write("Enter the Wing Length : ");
    int WingLength = Convert.ToInt32(Console.ReadLine());
    plane.WingLength = WingLength;

    vehicles[vehicleCount] = plane;
    vehicleCount++;


}


void InfoAboutAllVehicles()
{
    for (int i = 0; i < vehicleCount; i++)
    {
        Console.WriteLine($"Vehicle {i + 1}: {vehicles[i]}");
    }
}

void DeleteVehicle()
{

}

bool continueRunning = true;

while (continueRunning)
{
    Console.WriteLine("Vehicle Menu:");
    Console.WriteLine("1- Create a new car");
    Console.WriteLine("2- Create a new bicycle");
    Console.WriteLine("3- Create a new plane");
    Console.WriteLine("4- Info about all vehicles");
    Console.WriteLine("5- Delete vehicle");
    Console.WriteLine("6- Exit");
    Console.Write("Enter your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            CreateaCar();
            break;
        case 2:
            CreateNewBicycle();
            break;
        case 3:
            CreateNewPlane();
            break;
        case 4:
            InfoAboutAllVehicles();
            break;
        case 5:
            DeleteVehicle();
            break;
        case 6:
            continueRunning = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}