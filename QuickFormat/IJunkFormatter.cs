namespace QuickFormat
{
    public interface IJunkFormatter
    {
        string FormatName { get; }
        bool TryFormatJunk(string junk, out string result);
    }
}