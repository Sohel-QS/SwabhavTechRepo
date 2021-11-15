using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolution.Interface;

namespace LSPSolution.Model
{
    class Square : IPolygon
    {
        private int _side;

        public Square(int side)
        {
            this._side = side;
        }

        public int Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }

        public void CalculateArea()
        {
            int area = _side * side;
            retunr area;
        }
    }
}
