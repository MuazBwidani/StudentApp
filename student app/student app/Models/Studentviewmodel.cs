using System.ComponentModel;

namespace student_app.Models
{
    public class Studentviewmodel
    {
        public int Id { get; set; }

        [DisplayName("first name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}
