using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace student_app.Models
{
    public class Student
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column(TypeName ="nvarchar(50)")]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
