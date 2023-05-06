using ATaraxia.Core.Models;
using ATaraxia.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATaraxia.EF.Repositories
{
    public class TemplateRepository :BaseRepository<Template>,ITemplateRepository
    {
        public TemplateRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Template> GetByIdWithUserLikesAsync(Guid id)
        {
            return await _context.Set<Template>().Include(t => t.UserLikes).FirstOrDefaultAsync(t => t.TemplateId == id);
        }



    }
}
