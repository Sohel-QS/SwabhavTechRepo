using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AurionProMathCalculator
{
    public class AurionProMath
    {
        private bool result = false;
        private int flag = 0;
        private float mid;
        int _index;
        public bool CheckPrimeNo(int number)
        {
            mid = number / 2;
            for(int divisor = 2; divisor <= mid; divisor++)
            {
                if(number % divisor == 0)
                { 
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                result = true;
            return result;
        }

        public int[] GeneratePrimeNosTill(int limit)
        {
            int[] _primeNos = new int[0];
            _index = 0;
            for(int number = 1; number < limit; number++)
            {
                mid = number / 2;
                flag = 0;
                for (int divisor = 2; divisor <= mid; ++divisor)
                {
                    if (number % divisor == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    Array.Resize(ref _primeNos, _index+1);
                    _primeNos[_index] = number;
                    _index+=1;
                }
            }

            return _primeNos;
        }

        public int[] GenerateEvenNosTill(int limit)
        {
            int[] _evenNos = new int[0];
            _index = 0;

            for (int number = 1; number < limit; number++)
            {
                if(number % 2 ==0)
                {
                    Array.Resize(ref _evenNos, _index+1);
                    _evenNos[_index] = number;
                    _index += 1;
                }
            }

            return _evenNos;
        }
    }
}
