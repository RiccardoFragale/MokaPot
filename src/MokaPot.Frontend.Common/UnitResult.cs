
namespace MokaPot.Frontend.Common
{
    public class UnitResult<T>
    {
        public bool IsSuccessful { get; set; }
        public T Value { get; set; }
    }
}