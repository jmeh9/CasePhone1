using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CasePhone.Web.Data.Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nosotros")]
        public string Name { get; set; }

    }
}
