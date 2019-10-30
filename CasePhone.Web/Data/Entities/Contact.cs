using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CasePhone.Web.Data.Entities
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        [Display (Name="Contacto")]
        public int NumberCellphone { get; set; } 
    }
}
