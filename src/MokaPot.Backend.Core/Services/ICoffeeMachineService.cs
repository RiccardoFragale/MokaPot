namespace MokaPot.Backend.Core.Services
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
