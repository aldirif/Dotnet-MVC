namespace WebMvc.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public String StudentName { get; set; }
        public String Email { get; set; }
        public String Major { get; set; }
        public String Address { get; set; }
        public StudentViewModel()
        {

        }

        public StudentViewModel(int id, String studentName, String email, String major, String address)
        {
            Id = id;
            StudentName = studentName;
            Email = email;
            Major = major;
            Address = address;
        }
    }

}
