namespace WebMvc.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public String StudentName { get; set; }
        public String Email { get; set; }
        public StudentViewModel()
        {

        }

        public StudentViewModel(int id, String studentName, String email)
        {
            Id = id;
            StudentName = studentName;
            Email = email;
        }
    }

}
