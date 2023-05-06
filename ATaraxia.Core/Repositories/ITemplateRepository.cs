using ATaraxia.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATaraxia.Core.Repositories
{
    public interface ITemplateRepository:IBaseRepository<Template>
    {
        Task<Template> GetByIdWithUserLikesAsync(Guid id);



    }
}
