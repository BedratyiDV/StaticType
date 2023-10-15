using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticType
{
    /// <summary>
    /// Class containing calculation methods
    /// </summary>
    internal class Calculation
    {
        /// <summary>
        /// The only property of this class is predefined point
        /// </summary>
        private static readonly Point _internalPoint;

        /// <summary>
        /// Constructor for Calculation class. Sets up coordinats of predefined point
        /// </summary>
        static Calculation() 
        
        { 
            _internalPoint = new Point(10,10); 
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
            long distance = (long)Math.Round(Math.Sqrt((_internalPoint.XCoordinate - externalPoint.XCoordinate)
                * (_internalPoint.XCoordinate - externalPoint.XCoordinate) +
                  (_internalPoint.YCoordinate - externalPoint.YCoordinate) *
                  (_internalPoint.YCoordinate - externalPoint.YCoordinate)));
            return distance;
        }
    }
}
