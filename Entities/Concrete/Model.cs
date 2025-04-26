using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Model : IEntity
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
    }
}
