using System;
using OtasV3.Domain.Enumerations;

namespace OtasV3.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public Gender Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }


    }
}