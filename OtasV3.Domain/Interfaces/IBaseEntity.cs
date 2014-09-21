using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtasV3.Domain.Interfaces
{
    ////Using an interface instead of class because this is makes it easier to extend the other entities (ex : ApplicationUser)
    //public interface IBaseEntity
    //{
    //    [DatabaseGenerated(DatabaseGeneratedOption.Computed)] //Equivalent to 'default' in SQL
    //    DateTime CreatedAt { get; set; }
    //    DateTime? UpdatedAt { get; set; }
    //}
}
