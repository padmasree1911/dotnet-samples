namespace BenchmarkSamples
{
    public class DateParser
    {
        public int GetYearFromDateTime(string datetimeAsString)
        {
            var dateTime = DateTime.Parse(datetimeAsString);
            return dateTime.Year;
        }

        public int GetYearFromSubString(string datetimeAsString)
        {
            var yeaAsString = datetimeAsString.Substring(0, datetimeAsString.IndexOf('-'));
            return int.Parse(yeaAsString);
        }

        public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var yeaAsString = dateTimeAsSpan.Slice(0, dateTimeAsSpan.IndexOf("-"));
            return int.Parse(yeaAsString);
        }

    }
}