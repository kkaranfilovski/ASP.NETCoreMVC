using System.ComponentModel.DataAnnotations;

namespace SEDC.Class05.Demo.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Please fill this field")]
        //[MinLength(3, ErrorMessage = "Enter more then 3 characters")]
        [StringLength(50, ErrorMessage ="From 2 to 50 char", MinimumLength = 2)]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "City of residence")]
        public string City { get; set; }
        //public bool IsEmployed { get; set; }

        public override string ToString()
        {
            return $"Hello there! I am {FirstName} {LastName}";
        }
    }
}
