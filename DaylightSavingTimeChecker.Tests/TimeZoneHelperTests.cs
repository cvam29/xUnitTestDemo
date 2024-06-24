namespace DaylightSavingTimeChecker.Tests;

public class TimeZoneHelperTests
{
    private const string VictoriaTz = "AUS Eastern Standard Time";
    private const string NSWTz = "AUS Eastern Standard Time";
    private const string ACTTz = "AUS Eastern Standard Time";
    private const string SouthAustraliaTz = "Cen. Australia Standard Time";
    private const string TasmaniaTz = "AUS Eastern Standard Time";

    [Fact]
    public void Victoria_IsInDaylightSavings_Summer()
    {
        var summerTime = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.True(TimeZoneHelper.IsInDaylightSavings(VictoriaTz, summerTime));
    }

    [Fact]
    public void Victoria_IsInDaylightSavings_Winter()
    {
        var winterTime = new DateTime(2024, 6, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.False(TimeZoneHelper.IsInDaylightSavings(VictoriaTz, winterTime));
    }

    [Fact]
    public void NSW_IsInDaylightSavings_Summer()
    {
        var summerTime = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.True(TimeZoneHelper.IsInDaylightSavings(NSWTz, summerTime));
    }

    [Fact]
    public void NSW_IsInDaylightSavings_Winter()
    {
        var winterTime = new DateTime(2024, 6, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.False(TimeZoneHelper.IsInDaylightSavings(NSWTz, winterTime));
    }

    [Fact]
    public void ACT_IsInDaylightSavings_Summer()
    {
        var summerTime = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.True(TimeZoneHelper.IsInDaylightSavings(ACTTz, summerTime));
    }

    [Fact]
    public void ACT_IsInDaylightSavings_Winter()
    {
        var winterTime = new DateTime(2024, 6, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.False(TimeZoneHelper.IsInDaylightSavings(ACTTz, winterTime));
    }

    [Fact]
    public void SouthAustralia_IsInDaylightSavings_Summer()
    {
        var summerTime = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.True(TimeZoneHelper.IsInDaylightSavings(SouthAustraliaTz, summerTime));
    }

    [Fact]
    public void SouthAustralia_IsInDaylightSavings_Winter()
    {
        var winterTime = new DateTime(2024, 6, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.False(TimeZoneHelper.IsInDaylightSavings(SouthAustraliaTz, winterTime));
    }

    [Fact]
    public void Tasmania_IsInDaylightSavings_Summer()
    {
        var summerTime = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.True(TimeZoneHelper.IsInDaylightSavings(TasmaniaTz, summerTime));
    }

    [Fact]
    public void Tasmania_IsInDaylightSavings_Winter()
    {
        var winterTime = new DateTime(2024, 6, 15, 0, 0, 0, DateTimeKind.Utc);
        Assert.False(TimeZoneHelper.IsInDaylightSavings(TasmaniaTz, winterTime));
    }
}
