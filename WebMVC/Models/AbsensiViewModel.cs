namespace WebMvc.Models
{
    public class AbsensiViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AbsentStartDate { get; set; }
        public DateTime AbsentEndDate { get; set; }
        public String Location { get; set; }
        public String Description { get; set; }

        public AbsensiViewModel()
        {

        }

        public AbsensiViewModel(int id, int employeeId, DateTime absentStartDate, DateTime absentEndDate, string location, string description)
        {
            Id = id;
            EmployeeId = employeeId;
            AbsentStartDate = absentStartDate;
            AbsentEndDate = absentEndDate;
            Location = location;
            Description = description;
        }
    }

}
