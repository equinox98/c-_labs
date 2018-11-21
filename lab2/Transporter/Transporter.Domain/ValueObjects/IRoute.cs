using System.Collections.Generic;

namespace Transporter.Domain.ValueObjects
{
    public interface IRoute
    {
        IReadOnlyCollection<IRouteNode> RouteNodes { get; }
        void AddNode(IRouteNode routeNode);
    }
}