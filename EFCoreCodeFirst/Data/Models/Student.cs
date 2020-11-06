namespace EFCoreCodeFirst.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static DataValidations.Student;
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

     // [MinLength] v efcore ne pravi ni6to, predi e pravil v ef
        [Required]
        [MaxLength(NameMaxLenght)]
        public string FirstName { get; set; }
        
        [MaxLength(NameMaxLenght)]
        public string MiddleName { get; set; }

        [MaxLength(NameMaxLenght)]
        [Required]
        public string LastName { get; set; }
        public int? Age { get; set; }

        [MaxLength(2 * 1024)]
        public byte[] Image { get; set; }

        [Column(TypeName ="char(10)")]
        public string IdentifierNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public StudentType Type { get; set; }
    }
}
