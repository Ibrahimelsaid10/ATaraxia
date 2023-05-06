using ATaraxia.Core;
using ATaraxia.Core.Models;
using ATaraxia.Core.Repositories;
using ATaraxia.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ATaraxia.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public ITemplateRepository Templates { get; private set; }
        public IUserLikeRepository Userlikes { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Templates = new TemplateRepository(_context);
            Userlikes = new UserLikeRepository(_context);

        }
        
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
