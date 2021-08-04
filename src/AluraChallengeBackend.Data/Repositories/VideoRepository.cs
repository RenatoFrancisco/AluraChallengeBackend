using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AluraChallengeBackend.Core.Data;
using AluraChallengeBackend.Domain.Entities;
using AluraChallengeBackend.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AluraChallengeBackend.Data.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly Context _context;

        public VideoRepository(Context context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Video>> GetAll()
        {
            return await _context.Videos.AsNoTracking().ToListAsync();
        }

        public async Task<Video> Get(Guid id)
        {
            return await _context.Videos.AsNoTracking().FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task Add(Video video)
        {
            await _context.Videos.AddAsync(video);
        }

        public void Update(Video video)
        {
             _context.Videos.Update(video);
        }

        public void Remove(Guid id)
        {
            _context.Videos.Remove(_context.Videos.Find(id));
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}