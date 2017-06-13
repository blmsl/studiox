using StudioX.Timing;
using Shouldly;
using Xunit;

namespace StudioX.Tests.Extensions
{
    public class DateTimeRangeTests
    {
        [Fact]
        public void StaticRangesTest()
        {
            DateTimeRange.Today.StartTime.ShouldBeGreaterThan(DateTimeRange.Yesterday.EndTime);
            DateTimeRange.Today.EndTime.ShouldBeLessThan(DateTimeRange.Tomorrow.StartTime);

            DateTimeRange.ThisMonth.StartTime.Day.ShouldBe(1);
            DateTimeRange.LastMonth.StartTime.Day.ShouldBe(1);
            DateTimeRange.NextMonth.StartTime.Day.ShouldBe(1);

            DateTimeRange.ThisMonth.StartTime.ShouldBeGreaterThan(DateTimeRange.LastMonth.EndTime);
            DateTimeRange.ThisMonth.EndTime.ShouldBeLessThan(DateTimeRange.NextMonth.EndTime);

            DateTimeRange.ThisYear.StartTime.Month.ShouldBe(1);
            DateTimeRange.ThisYear.StartTime.Day.ShouldBe(1);
            
            DateTimeRange.ThisYear.StartTime.ShouldBeGreaterThan(DateTimeRange.LastYear.EndTime);
            DateTimeRange.ThisYear.EndTime.ShouldBeLessThan(DateTimeRange.NextYear.StartTime);

            DateTimeRange.Last7DaysExceptToday.EndTime.ShouldBeLessThan(DateTimeRange.Today.StartTime);
            DateTimeRange.Last30DaysExceptToday.EndTime.ShouldBeLessThan(DateTimeRange.Today.StartTime);
        }
    }
}