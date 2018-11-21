using System;

namespace Transporter.Domain.ValueObjects
{
    public class RouteNode : IRouteNode
    {
        public TransportationType TransportationType { get; }
        public int Distance { get; }

        public RouteNode(TransportationType transportationType, int distance)
        {
            if(distance <=0)
                throw new ArgumentException(nameof(distance));

            TransportationType = transportationType;
            Distance = distance;
        }
    }
}