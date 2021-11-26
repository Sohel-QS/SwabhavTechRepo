using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore.Model
{
    public class Cell
    {
        private MarkType _mark;
        public Cell()
        {
            _mark = MarkType.Empty;
        }

        public MarkType Mark 
        { 
            get => _mark;
            set
            {
                if (IsMarked())
                {
                    throw new Exception("Cell is Already Marked");
                }
                _mark = value;
            }
        }

        public bool IsMarked()
        {
            var result = _mark.Equals(MarkType.X) ||
                        _mark.Equals(MarkType.O);
            return result;
        }
    }
}
