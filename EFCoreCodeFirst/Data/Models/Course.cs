namespace EFCoreCodeFirst.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static DataValidations.Course;

    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }


    }
}
