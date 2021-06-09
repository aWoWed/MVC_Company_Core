using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Company_Core.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Enter a title for service")]
        [Display(Name = "Title name")]
        public override string Title { get; set; }

        [Display(Name = "Subtitle name")] 
        public override string Subtitle { get; set; }

        [Display(Name = "Text contained")]
        public override string Text { get; set; }

    }
}
