namespace WebApplication1.Services;

public class CarsServiceImpl: ICarsService
{
    public string GetCarNames()
    {
        Console.WriteLine("GetCarNames");
        return "Car Name 1";
    }
}