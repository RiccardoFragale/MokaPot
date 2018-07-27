namespace MokaPot.ConsoleFrontend.Services
{
    public interface ICoffeeMachineService
    {
        bool GetWater(int ml);
        bool SetCoffee(int grams);
        bool GetMilk(int ml);
        bool SteamBlast(int seconds);
        bool Run();
    }
}
