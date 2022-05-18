using BenchmarkDotNet.Attributes;

namespace BenchmarkSamples
{
    [MemoryDiagnoser]
    public class LoopBenchmarks
    {
        private readonly List<int> numbersAsList = Enumerable.Range(1, 10).ToList();
        private readonly int[] numbersAsArray = Enumerable.Range(1, 10).ToArray();

        [Benchmark]
        public void ForEachLoopUsingList()
        {
            foreach (var num in numbersAsList)
            {
                bool isEven = (num % 2) == 0;
            }
        }

        [Benchmark]
        public void ForLoopUsingList()
        {
            for (int i = 0; i < numbersAsList.Count; i++)
            {
                bool isEven = (numbersAsList[i] % 2) == 0;
            }
        }

        
        [Benchmark]
        public void ForEachLoopUsingArray()
        {
            foreach (var num in numbersAsArray)
            {
                bool isEven = (num % 2) == 0;
            }
        }

        [Benchmark]
        public void ForLoopUsingArray()
        {
            for (int i = 0; i < numbersAsArray.Length; i++)
            {
                bool isEven = (numbersAsArray[i] % 2) == 0;
            }
        }
    }
}