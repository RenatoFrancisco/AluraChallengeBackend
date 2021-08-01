using System;
using AluraChallengeBackend.Core.DomainObjects;

namespace AluraChallengeBackend.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    } 
}