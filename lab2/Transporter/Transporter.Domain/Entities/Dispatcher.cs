using System;
using System.Collections.Generic;
using System.Linq;
using Transporter.Domain.Exceptions;
using Transporter.Domain.ValueObjects;

namespace Transporter.Domain.Entities
{
    public sealed class Dispatcher : IDispatcher
    {
        private List<ITransport> _transports;

        public Dispatcher(IEnumerable<ITransport> transports)
        {
            _transports = transports.ToList() ?? throw new ArgumentNullException(nameof(transports));
        }

        public IReadOnlyCollection<ITransport> BuildTransportationPlan(IRoute route)
        {
            if(route == null)
                throw new ArgumentNullException(nameof(route));
            
            if(route.RouteNodes.Count == 0)
                return new List<ITransport>();

            var transportationPlan = new List<ITransport>();
            
            foreach (var node in route.RouteNodes)
            {
                transportationPlan.Add(FindTransport(node.TransportationType, node.Distance));
            }

            return transportationPlan;
        }

        private ITransport FindTransport(TransportationType transportationType, int distance)
        {
            foreach (var transport in _transports)
            {
                if (transport.Type == transportationType && transport.MaxDistance >= distance)
                    return transport;
            }
            
            throw new AppropriativeTransportNotFoundException();
        }
    }
}