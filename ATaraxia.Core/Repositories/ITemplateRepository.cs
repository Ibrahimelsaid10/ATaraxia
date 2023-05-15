namespace ATaraxia.Core.Repositories;

public interface ITemplateRepository:IBaseRepository<Template>
{
    // Task<Template> GetByIdWithUserLikesAsync(Guid id);

      Task<IEnumerable< Template>> GetAllWithUsersAsync(string includes = "");
       

}
