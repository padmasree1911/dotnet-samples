using BenchmarkDotNet.Attributes;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer]
    public class DateParserBenchmarks
    {
        private const string dateTimeAsString = "2022-01-26T15:25:56Z";
        private static readonly DateParser parser = new DateParser();

        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            parser.GetYearFromDateTime(dateTimeAsString);
        }

        [Benchmark]
        public void GetYearFromSubString()
        {
            parser.GetYearFromSubString(dateTimeAsString);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            parser.GetYearFromSubString(dateTimeAsString);
        }
    }
}