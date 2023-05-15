namespace ATaraxia.Core;

public interface IUnitOfWork : IDisposable
{
   ITemplateRepository Templates { get; }


    Task<int> CompleteAsync();
}
