using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MVC_Company_Core.Domain.Entities
{
    public class EntityBase
    {
        protected EntityBase() => Date = DateTime.UtcNow;

        [Required] 
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Subtitle")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Text")]
        public virtual string Text { get; set; }
        
        [Display(Name = "SEO Metatag Title")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "SEO Metatag Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "SEO Metatag Keywords")]
        public virtual string MetaKeywords { get; set; }

        [DataType(DataType.Time)] 
        public DateTime Date { get; set; }

    }
}
