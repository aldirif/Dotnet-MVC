namespace WebMvc.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public String EmployeeName { get; set; }
        public String Email { get; set; }
        public String Position { get; set; }
        public int Experience { get; set; }
        public EmployeeViewModel()
        {

        }

        public EmployeeViewModel(int id, String employeeName, String email, String position, int experience)
        {
            Id = id;
            EmployeeName = employeeName;
            Email = email;
            Position = position;
            Experience = experience;
        }
    }

}
