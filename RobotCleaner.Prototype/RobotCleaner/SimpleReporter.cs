using System.Collections.Generic;

namespace RobotCleaner
{
    public class SimpleReporter : IReport
    {
        private SortedSet<Location> _cleanedLocationStrings;
        

        public SimpleReporter()
        {
            _cleanedLocationStrings = new SortedSet<Location>();
        }

        public string PrintReport()
        {
            return string.Format("=> Cleaned: {0}", _cleanedLocationStrings.Count);
        }

        public void RegisterNewPosition(Location position)
        {
            _cleanedLocationStrings.Add(position);
        }
    }
} 