using System;
using Truck.Domain.Enums;

namespace Truck.Domain.Entities
{
    public abstract class Person : Entity<long>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DocumentType DocumentType { get; set; }

        public string DocumentNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
