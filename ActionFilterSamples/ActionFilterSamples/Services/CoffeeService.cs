using ActionFilterSamples.Domain.Entities;
using ActionFilterSamples.Exceptions;
using ActionFilterSamples.Repositories;

namespace ActionFilterSamples.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly ICoffeeRepository repository;

        public CoffeeService(ICoffeeRepository repository)
        {
            this.repository = repository;
        }

        public Coffee GetById(int id)
        {
            var coffee = repository.GetById(id);
            if (coffee == null)
            {
                throw new NotFoundException(nameof(Coffee), id);
            }

            return coffee;
        }

        public Coffee GetByName(string name)
        {
            throw new System.NotImplementedException();
        }


    }
}
