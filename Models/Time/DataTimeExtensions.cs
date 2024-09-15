
namespace Models;
public static class DataTimeExtensions
{
    public static Year ToYear(this DateTime time) => new(time.Year);
}
