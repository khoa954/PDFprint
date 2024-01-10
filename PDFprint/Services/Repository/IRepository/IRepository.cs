using System.Linq.Expressions;

namespace PDFprint.Services.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
    }
}
