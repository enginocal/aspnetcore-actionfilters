using ActionFilterSamples.Domain.Entities;

namespace ActionFilterSamples.Services
{
    public interface ICoffeeService
    {
        Coffee GetById(int id);
        Coffee GetByName(string name);
    }
}
