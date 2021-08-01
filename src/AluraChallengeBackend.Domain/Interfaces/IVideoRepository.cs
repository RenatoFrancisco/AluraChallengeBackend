using AluraChallengeBackend.Core.Data;
using AluraChallengeBackend.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace AluraChallengeBackend.Domain.Interfaces
{
    public interface IVideoRepository : IRepository<Video>
    {
        Task<IEnumerable<Video>> GetAll();

        Task<Video> Get(Guid id);

        Task Add(Video video);

        Task Update(Video video);

        Task Remove(Guid id);
    }
}