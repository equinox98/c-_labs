using System;
using Transporter.Domain.ValueObjects;

namespace Transporter.Domain.Entities
{
    public interface ITransport
    {
        Guid Id { get; }
        TransportationType Type { get; }
        string Model { get; }
        int MaxDistance { get; }
    }
}