using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Company_Core.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required] 
        public string CodeWord { get; set; }

        [Display(Name = "Title name")] 
        public override string Title { get; set; } = "Info title";

        [Display(Name = "Text contained")] 
        public override string Text { get; set; }
    }
}
