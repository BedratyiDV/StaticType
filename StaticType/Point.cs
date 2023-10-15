using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticType
{
    internal class Point
    {
        private int _xCoordinate;
        private int _yCoordinate;
        internal static int Counter;

        /// <summary>
        /// Getter-Setter for X coordinate field. It's possible to set only positive values from 0 to Int.MaxValue
        /// </summary>
        public int XCoordinate
        {
            get => _xCoordinate;
            set => _xCoordinate = value < int.MaxValue && value > 0 ? value : 0;
        }
        /// <summary>
        /// Getter-Setter for Y coordinate field. It's possible to set only positive values from 0 to Int.MaxValue
        /// </summary>
        public int YCoordinate
        {
            get => _yCoordinate;
            set => _yCoordinate = value < int.MaxValue && value > 0 ? value : 0;
        }
        /// <summary>
        /// Constructor for Point class initializing
        /// </summary>
        /// <param name="xCoordinate">   </param>
        /// <param name="yCoordinate"> </param>

        public Point(int xCoordinate, int yCoordinate)
        {
            _xCoordinate = xCoordinate < int.MaxValue && xCoordinate > 0 ? xCoordinate : 0;
            _yCoordinate = yCoordinate < int.MaxValue && yCoordinate > 0 ? yCoordinate : 0;
            Counter++;
        }
    }
}
