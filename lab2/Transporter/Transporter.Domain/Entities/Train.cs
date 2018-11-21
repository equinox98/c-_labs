using System;
using Transporter.Domain.ValueObjects;

namespace Transporter.Domain.Entities
{
    public class Train : Transport
    {
        private TransportationType TrainTransportationType = TransportationType.Ground;
        
        public override TransportationType Type => TrainTransportationType;

        public Train(
            Guid id,
            string model,
            int maxDistance) : base(id, model, maxDistance)
        {
            
        }
    }
}