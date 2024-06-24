namespace DaylightSavingTimeChecker.Tests;

public class TZHelperTest
{
    private const string VictoriaTz = "AUS Eastern Standard Time";
    private const string NSWTz = "AUS Eastern Standard Time";
    private const string ACTTz = "AUS Eastern Standard Time";
    private const string SouthAustraliaTz = "Cen. Australia Standard Time";
    private const string TasmaniaTz = "AUS Eastern Standard Time";


    [Theory]
    [InlineData(VictoriaTz, "2024-01-15T00:00:00Z", true)] // Summer
    [InlineData(VictoriaTz, "2024-06-15T00:00:00Z", false)] // Winter
    [InlineData(NSWTz, "2024-06-15T00:00:00Z", false)] // Winter
    [InlineData(ACTTz, "2024-01-15T00:00:00Z", true)] // Summer
    [InlineData(ACTTz, "2024-06-15T00:00:00Z", false)] // Winter
    [InlineData(SouthAustraliaTz, "2024-01-15T00:00:00Z", true)] // Summer
    [InlineData(SouthAustraliaTz, "2024-06-15T00:00:00Z", false)] // Winter
    [InlineData(TasmaniaTz, "2024-01-15T00:00:00Z", true)] // Summer
    [InlineData(TasmaniaTz, "2024-06-15T00:00:00Z", false)] // Winter
    public void IsInDaylightSavings_Tests(string timeZoneId, string utcTimeStr, bool expected)
    {
        var utcTime = DateTime.Parse(utcTimeStr, null, System.Globalization.DateTimeStyles.RoundtripKind);
        bool isInDst = TimeZoneHelper.IsInDaylightSavings(timeZoneId, utcTime);
        Assert.Equal(expected, isInDst);
    }
}
