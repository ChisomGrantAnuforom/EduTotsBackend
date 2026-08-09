using EduTots.Infrastructure.Persistence;

namespace EduTots.Infrastructure.Repositories;

using EduTots.Domain.Entities;
using EduTots.Application.Interfaces;
using EduTots.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

    public class PupilRepository : IPupilRepository
    {
        private readonly EduTotsDbContext _context;

        public PupilRepository(EduTotsDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Pupil child)
        {
            await _context.Pupils.AddAsync(child);
            await _context.SaveChangesAsync();
        }

        public async Task<Pupil> GetByIdAsync(long id)
        {
            return await _context.Pupils
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.PupilId == id);
        }
        
        
        public async Task<List<Pupil>> GetAllPupilsAsync()
        {
            return await _context.Pupils
                .AsNoTracking()
                .OrderBy(x => x.LastName)
                .ToListAsync();
        }

        
    }
