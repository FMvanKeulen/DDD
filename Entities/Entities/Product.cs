using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Product : Base
    {
        [Display(Name = "Preço")]
        public decimal Price { get; set; }
        [Display(Name = "Ativo")]
        public bool Active { get; set; }
    }
}