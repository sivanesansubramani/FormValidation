using System.ComponentModel.DataAnnotations;


namespace FormValidation.Models
{
    public class ValidationModel
    {
        public int id { get; set; }

        [Required]
        [MinLength(5), MaxLength(20)]
        public string Name { get; set; }

        [Required]

        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        public String Pnone { get; set; }

        public String Location { get; set; }

        public List<LocationModel> LocationValues { get; set; }
    }

}
