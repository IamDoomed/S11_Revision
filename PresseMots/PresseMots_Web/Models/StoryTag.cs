using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using PresseMots.Utility;

namespace PresseMots.Models
{
    public class StoryTag
    {

        public int Id { get; set; }

        [ForeignKey("Story")]
        public virtual int StoryId { get; set; }

        [ValidateNever]
        public virtual Story Story { get; set; }

        [ForeignKey("Tag")]
        public virtual int TagId { get; set; }

        [ValidateNever]
        public virtual Tag Tag { get; set; }

    }
}
