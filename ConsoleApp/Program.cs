namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var laboratory = new OtusMeasuringLaboratory();

            var generator = new FibonacciNumberSearcher();
            Func<uint, uint> testRecursion = generator.RecursionMethod;
            Func<uint, uint> testCycle = generator.CycleMethod;
           
            var researchObjects = new uint[] { 5, 10, 20, 30, 40 };

            foreach (var researchObj in researchObjects)
            {
                laboratory.MeasurePerformance($"Cycle method, n={researchObj}", testCycle, researchObj);
                laboratory.MeasurePerformance($"Recursion method, n={researchObj}", testRecursion, researchObj);                
            }           

            laboratory.PrintLogs();
        }
    }
}

