namespace WebMvc.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public String StudentName { get; set; }
        public String Email { get; set; }
        public String Position { get; set; }
        public int Experience { get; set; }
        public StudentViewModel()
        {

        }

        public StudentViewModel(int id, String studentName, String email, String position, int experience)
        {
            Id = id;
            StudentName = studentName;
            Email = email;
            Position = position;
            Experience = experience;
        }
    }

}
