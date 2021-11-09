using System;

namespace EnumTestApp.Model
{
    class DaysOfWeek
    {
        private enum _Days { Sunday, Monday, Tuesday, WednesDay, Thursday, Friday, SaturDay };
        private string[] _days = new string[10];
        private int[] workDays = new int[] { 1, 2, 3, 4, 5 };
        private int[] weekEndDays = new int[] { 0, 6 };
        private int[] weekDays = new int[] { 0, 1, 2, 3, 4, 5, 6 };

        public string[] GetWorkingDays()
        {
            GetDays(workDays);
            return _days;
        }

        public string[] GetWeekEndDays()
        {
            GetDays(weekEndDays);
            return _days;
        }

        public string[] GetWeekDays()
        {
            GetDays(weekDays);
            return _days;
        }

        private void GetDays(int[] day)
        {
            Array.Clear(_days, 0, _days.Length);
            foreach (int index in day)
            {
                _days[index + 1] = Enum.GetName(typeof(_Days), index);
            }
        }

    }
}
