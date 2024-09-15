
namespace Models;

public record struct Year(int Number)
{
    public Month GetMonth(int ordinal) =>
        ordinal > 1 && ordinal < 12 ? new(this, ordinal) : 
        throw new ArgumentException(nameof(ordinal));

    public IEnumerable<Month> TryGetMonth(int ordinal)
    {
        if (ordinal > 1 && ordinal < 12 ) yield return new(this, ordinal);
    }
    public IEnumerable<Month> Months => GetMonths(this);

    public IEnumerable<Year> Decade =>
        Enumerable.Range(this.DecadeBeginning.Number, 10)
        .Select(year => new Year(year));
        
    public Year DecadeBeginning => new (this.Number / 10 * 10 + 1); 

    private IEnumerable<Month> GetMonths(Year year) =>
        Enumerable.Range(1, 12)
        .Select(ordinal => new Month(year, ordinal));
}