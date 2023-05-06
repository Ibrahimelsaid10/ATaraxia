using ATaraxia.Core.Models;
using ATaraxia.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATaraxia.EF.Repositories
{
    public class UserLikeRepository:BaseRepository<UserLike>,IUserLikeRepository
    {
        public UserLikeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
