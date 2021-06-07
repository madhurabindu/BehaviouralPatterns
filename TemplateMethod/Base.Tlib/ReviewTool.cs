using System;

namespace Base.Tlib
{
    public abstract class ReviewTool
    {
        public class Result
        {
            public bool CCNPassed = false;
            public bool CoveragePassed = false;
            public bool LineNosCheckPassed = false;

        }
        public Result PrepareForReview(string fileName)
        {
            Console.WriteLine("Preparing for Review....");
            Result result = new Result();
            result.CCNPassed = CheckCCN(fileName);
            result.CoveragePassed = CheckCoverage(fileName);
            result.LineNosCheckPassed = CheckLineNumbers(fileName);
            return result;
        }

        public void PerformReview(string reviewerName, string reviewerEmailId)
        {
            Console.WriteLine("Performing Review...");
            SendForManualReview(reviewerEmailId);
        }

        public void ConsolidateResult(string manualOutputReort, string fileName)
        {
            Console.WriteLine("Consolidating Result...");
            string output = RunStaticAnalysis(fileName);
            PublishOutput(fileName, output, manualOutputReort);
            MarkFileAsReviewedInSourceControl(fileName);
        }

        protected abstract bool CheckCCN(string fileName);

        protected abstract bool CheckCoverage(string fileName);

        protected abstract bool CheckLineNumbers(string fileName);

        protected abstract string RunStaticAnalysis(string fileName);

        protected abstract void PublishOutput(string filename, string output, string manualOutputReort);
       
        protected virtual void SendForManualReview(string reviewerEmailId)
        {
        }
        protected virtual void MarkFileAsReviewedInSourceControl(string fileName)
        {
        }
    }
}
