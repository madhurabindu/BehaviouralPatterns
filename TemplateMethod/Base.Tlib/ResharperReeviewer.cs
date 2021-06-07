using System;

namespace Base.Tlib
{
    public class Resharper : ReviewTool
    {
        bool randomResult = false;
        protected override bool CheckCCN(string fileName)
        {
            Console.WriteLine("Checking Code Complexity with {0}", this.GetType().Name.ToUpper());
            return randomResult;
        }

        protected override bool CheckCoverage(string fileName)
        {
            Console.WriteLine("Checking Code Coverage with {0}", this.GetType().Name.ToUpper());
            return !randomResult;
        }

        protected override bool CheckLineNumbers(string fileName)
        {
            Console.WriteLine("Checking Number of Lines Limit with {0}", this.GetType().Name.ToUpper());
            randomResult = !randomResult;
            return randomResult;
        }

        protected override string RunStaticAnalysis(string fileName)
        {
            Console.WriteLine("Running Static Analysis Tool : {0}", this.GetType().Name.ToUpper());
            return string.Empty;
        }

        protected override void PublishOutput(string filename, string output, string manualOutputReort)
        {
            Console.WriteLine("Publishing Output to \\{0}\\{1}", filename, this.GetType().Name.ToUpper());
        }

      
    }
}
