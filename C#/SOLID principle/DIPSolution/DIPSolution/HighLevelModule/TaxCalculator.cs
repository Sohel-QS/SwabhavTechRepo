using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolution.CommonModule;

namespace DIPSolution.HighLevelModule
{
    class TaxCalculator
    {
        private ILogger _logger;

        public TaxCalculator(ILogger logger)
        {
            this._logger = logger;
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
                _logger.Log(ex.Message);
            }
            return result;
        }
    }
}
