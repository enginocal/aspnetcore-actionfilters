using ActionFilterSamples.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionFilterSamples.Repositories
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private IEnumerable<Coffee> coffees = new List<Coffee>
        {
            new Coffee
            {
                Id=1,
                Name="Kenya",
                Density="Mediuam"
            },
            new Coffee
            {
                Id=2,
                Name="Guatemela",
                Density="Hard"
            }
        };

        public Coffee GetById(int id)
        {
            var coffee = coffees.FirstOrDefault(x => x.Id == id);
            return coffee;
        }

        public Coffee GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
