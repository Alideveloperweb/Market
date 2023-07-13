using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataLayer.Entities
{
    public class MainSlader
    {
        [Key]
        public int SliderId { get; set; }

        [Display(Name ="نام اسلایدر")]
        [Required(ErrorMessage ="وارد کردن {0} اجباری است")]
        public string SliderTitle { get; set; }

        [Display(Name = "Alt اسلایدر")]

        public string SliderAlt { get; set; }

        [Display(Name = "ترتیب اسلایدر")]
        public int SliderSort { get; set; }

        [Display(Name = "لینک اسلایدر")]
        public string SliderLink { get; set; }

        [Display(Name = "وضعیت اسلایدر")]
        public bool IsActive { get; set; }
    }
}
