using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        /// <summary>
        /// Static method. Calculates distance between two points 
        /// </summary>
        /// <param name="point1"> </param>
        /// <param name="point2"> </param>
        /// <returns>Distance between point1 and point2 </returns> 
        internal static long GetDestancebetweenPoints(Point point1, Point point2)
        {
            long distance = (long)Math.Round(Math.Sqrt((point1.XCoordinate - point2.XCoordinate)
                * (point1.XCoordinate - point2.XCoordinate) +
                  (point1.YCoordinate - point2.YCoordinate) *
                  (point1.YCoordinate - point2.YCoordinate)));
            return distance;
        }
        /// <summary>
        /// Non-tatic method. Calculates distance between predifined point and input point 
        /// </summary>
        /// <param name="externalPoint"> </param>
        /// <returns>Distance between internal predefined point and external input </returns> 
        internal long GetDistanceToPoint(Point externalPoint)
        {
            long distance = (long)Math.Round(Math.Sqrt((this._xCoordinate - externalPoint.XCoordinate)
                * (this.XCoordinate - externalPoint.XCoordinate) +
                  (this._yCoordinate - externalPoint.YCoordinate) *
                  (this.YCoordinate - externalPoint.YCoordinate)));
            return distance;
        }
    }
}
