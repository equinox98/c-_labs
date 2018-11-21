using System;
using Transporter.Domain.ValueObjects;

namespace Transporter.Domain.Entities
{
    public class Ship : Transport
    {
        private TransportationType ShipTransportationType = TransportationType.Water;
        
        public override TransportationType Type => ShipTransportationType;

        public Ship(
            Guid id,
            string model,
            int maxDistance) : base(id, model, maxDistance)
        {
            
        }
    }
}