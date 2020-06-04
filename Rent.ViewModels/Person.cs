using System.ComponentModel.DataAnnotations;

namespace Rent.ViewModels
{
    public class Person
    {
        [Required(ErrorMessage = "required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "required")]
        public string Email { get; set; }



        [Required(ErrorMessage = "required")]
        [MaxLength(10)]
        [MinLength(6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "required")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "required")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "required")]
        public int CountryId { get; set; }
        public bool IsSeller { get; set; }

    }
}
