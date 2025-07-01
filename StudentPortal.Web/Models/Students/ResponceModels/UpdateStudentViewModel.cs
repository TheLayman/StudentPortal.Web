using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Web.Models.Students.ResponceModels
{
    public class UpdateStudentViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is not specified")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Allow from 3 to 30 characters")]
        [RegularExpression("^[а-яА-ЯёЁa-zA-Z]+$", ErrorMessage = "The name must contain only letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is not specified")]
        [EmailAddress(ErrorMessage = "Email format is not correct")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is not specified")]
        [Phone(ErrorMessage = "Phone type must be like +919876543210")]
        [RegularExpression(@"^\+91[0-9]{10}$", ErrorMessage = "Phone type must be like +919876543210")]
        public string Phone { get; set; }
        public bool Subscribed { get; set; }
    }
}
