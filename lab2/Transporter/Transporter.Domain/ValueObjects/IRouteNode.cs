namespace Transporter.Domain.ValueObjects
{
    public interface IRouteNode
    {
        TransportationType TransportationType { get; }
        int Distance { get; }
    }
}