using System;
using Transporter.Domain.ValueObjects;

namespace Transporter.Domain.Entities
{
    public class Airplane : Transport
    {
        private TransportationType AirplaneTransportationType = TransportationType.Air;
        
        public override TransportationType Type => AirplaneTransportationType;

        public Airplane(
            Guid id,
            string model,
            int maxDistance) : base(id, model, maxDistance)
        {
            
        }
    }
}