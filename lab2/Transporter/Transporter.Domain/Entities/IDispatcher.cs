using System.Collections.Generic;
using Transporter.Domain.ValueObjects;

namespace Transporter.Domain.Entities
{
    public interface IDispatcher
    {
        IReadOnlyCollection<ITransport> BuildTransportationPlan(IRoute route);
    }
}