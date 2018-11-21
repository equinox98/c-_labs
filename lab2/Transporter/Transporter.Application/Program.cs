using System;
using System.Collections.Generic;
using Transporter.Domain.Entities;
using Transporter.Domain.ValueObjects;

namespace Transporter.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var route = new Route();
            route.AddNode(new RouteNode(TransportationType.Air, 100));
            route.AddNode(new RouteNode(TransportationType.Ground, 1));
            route.AddNode(new RouteNode(TransportationType.Ground, 1000));
            route.AddNode(new RouteNode(TransportationType.Water, 100));
            route.AddNode(new RouteNode(TransportationType.Air, 100));
            route.AddNode(new RouteNode(TransportationType.Air, 100));

            var airplane = new Airplane(Guid.NewGuid(), "boing", 10000);
            var train = new Train(Guid.NewGuid(), "ukrzaliznizia", 100000);
            var ship = new Ship(Guid.NewGuid(), "moriak papay", 100);
            
            var dispatcher = new Dispatcher(new List<ITransport>(){airplane, train, ship});
            var res = dispatcher.BuildTransportationPlan(route);
        }
    }
}