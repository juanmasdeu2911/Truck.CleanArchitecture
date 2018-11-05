using System;
using Truck.Domain.ValueObjects;

namespace Truck.Domain.Entities
{
    public class User : Entity<Guid>
    {
        public AdAccount AdAccount { get; set; }
    }
}
