using System;
using Transporter.Domain.ValueObjects;

namespace Transporter.Domain.Entities
{
    public abstract class Transport : ITransport
    {
        public Guid Id { get; }
        public abstract TransportationType Type { get; }
        public string Model { get; }
        public int MaxDistance { get; }
        
        public Transport(
            Guid id,
            string model,
            int maxDistance)
        {
            Id = id;
            Model = model;
            MaxDistance = maxDistance;
        }
    }
}