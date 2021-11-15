using System;
using DIPViolation.LowLevelModule;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.HighLevelModule
{
    class TaxCalculator
    {
        private LogPolicyType _policy;

        public TaxCalculator(LogPolicyType policy)
        {
            this._policy = policy;
        }

        public double Calculate(int value1, int value2)
        {
            var result = 0;
            try
            {
                result = value1 / value2;

            }
            catch(Exception ex)
            {
                if(_policy == LogPolicyType.DB)
                {
                    new DBLogger().WriteLine(ex.Message);
                }
                else if (_policy == LogPolicyType.File)
                {
                    new FileLogger().WriteLine(ex.Message);
                }
            }
            return result;
        }
    }
}
