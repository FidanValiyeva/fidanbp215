public class HelloWorld
{
    static void Main (string[] args) 
    {
        Car car = new Car ("opel","cruise","1000","4");
        car.ShowfullInfo();
        Motorcycle motorcycle = new Motorcycle ("hyperbike","3000","5");
        motorcycle.ShowfullInfo();
    }
   
}
   
public class Vehicle
{
    public string brand;
    public string model;
    public double mileage;
 
    public  Vehicle (string brand,string model, double mileage)
    {
        this.brand = brand;
        this.model = model;
        this.mileage = mileage;
    }
}
public class Car : Vehicle
        
{ 
    public int doorsNum;
    
    public void ShowfullInfo()
    {
        Console.WriteLine($"Car brand: {brand}, model: {Model}, mileage: {mileage}, doors: {doorsNum}");
    }


    public Car(string brand,string model, double mileage,int doorsNum):base(model,mileage)
    {
        this.doorsNum = doorsNum;
    }
}
        
public class Motorcycle:Vehicle
{
        
            
    public int wheelNum;
            
        
    public  Motorcycle(string brand,string model, double mileage,int wheelNum):base(brand, model,mileage)
    {
        this.wheelNum = wheelNum;
    }
        
    public void ShowfullInfo()
    {
        Console.WriteLine($"Motorcycle: {brand},model:{model},milage:{milage},wheelNum:{wheelNum}");
    }
}
