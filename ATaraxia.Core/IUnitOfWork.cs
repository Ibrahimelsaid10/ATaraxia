using ATaraxia.Core.Models;
using ATaraxia.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATaraxia.Core
{
    public interface IUnitOfWork : IDisposable
    {
       ITemplateRepository Templates { get; }
       IUserLikeRepository Userlikes { get; }


        Task<int> CompleteAsync();
    }
}
