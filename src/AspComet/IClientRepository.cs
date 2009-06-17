using System.Collections;

namespace AspComet
{
    public interface IClientRepository
    {
        bool ContainsID(string clientID);
        Client GetByID(string clientID);
        void RemoveByID(string clientID);
        void Add(Client client);
        IEnumerable WhereSubscribedTo(string channel);
    }
}