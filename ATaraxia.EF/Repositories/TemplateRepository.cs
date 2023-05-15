using ATaraxia.Core.Models.TemplateType;

namespace ATaraxia.EF.Repositories;

public class TemplateRepository :BaseRepository<Template>,ITemplateRepository
{
    public TemplateRepository(ApplicationDbContext context) : base(context)
    {
    }

    //public async Task<Template> GetByIdWithUserLikesAsync(Guid id)
    //{
    //    return await _context.Set<Template>().Include(t => t.UserLikes).FirstOrDefaultAsync(t => t.TemplateId == id);
    //}
    public async Task<IEnumerable<Template>> GetAllWithUsersAsync(string includes = null)
    {
        IQueryable<Template> query = _context.Set<Template>();

        if (includes != null)
                query = query.Include(includes);

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<Template>> GetAllWithUsersAsync(TemplateType type)
    {
        return await _context.Set<Template>().ToList().Select(e => e.TemplateType.Equals(type)) ;
    }

}
