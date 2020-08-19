using ActionFilterSamples.Domain.Entities;

namespace ActionFilterSamples.Repositories
{
    public interface ICoffeeRepository
    {
        Coffee GetById(int id);
        Coffee GetByName(string name);
    }
}
