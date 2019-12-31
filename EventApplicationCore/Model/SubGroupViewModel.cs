using System.ComponentModel.DataAnnotations;

namespace MyAccountProject.Model
{
    public class SubGroupViewModel
    {
        [Required(ErrorMessage = "Required Group Name")]
        public string GroupName { get; set; }

        public SubGroup SubGroup { get; set; }
    }
}