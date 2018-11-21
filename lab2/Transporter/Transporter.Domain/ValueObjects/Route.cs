using System.Collections.Generic;

namespace Transporter.Domain.ValueObjects
{
    public class Route : IRoute
    {
        private List<IRouteNode> _routeNodes;

        public IReadOnlyCollection<IRouteNode> RouteNodes => _routeNodes;

        public Route()
        {
            _routeNodes = new List<IRouteNode>();
        }
        
        public void AddNode(IRouteNode routeNode)
        {
            if(routeNode != null)
                _routeNodes.Add(routeNode);
        }
    }
}