using AurionProMathCalculator;

namespace GenericDictionaryApp.Model
{
    class Student
    {
        private string _name;
        private int _rollNo;
        private string _location;
        private int _std;

        public Student(int id, int std, string name, string location)
        {
            _name = name;
            _rollNo = id;
            _location = location;
            _std = std;
        }

        public string Name
        {
            get => _name;
        }
        public string Location
        {
            get => _name;
        }
        public int RollNumber
        {
            get => _rollNo;
        }
        public int Std
        {
            get => _std;
        }
        public override bool Equals(object obj)
        {
            var other = obj as Student;
            if (other == null)
            {
                return false;
            }
            return this._rollNo == other._rollNo && this._std == other._std;
        }
        public override int GetHashCode()
        {
            return int.Parse(GenerateHashCode());
        }

        private string GenerateHashCode()
        {
            AurionProMath math = new AurionProMath();
            string code = "";
            code += _rollNo.ToString();
            foreach (int item in math.GeneratePrimeNosTill(_std))
            {
                if (item >= 7)
                    break;
                code += item.ToString();
            }
            return code + _std.ToString();
        }
    }
}
