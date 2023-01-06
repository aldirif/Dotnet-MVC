namespace WebMvc.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public String CustomerName { get; set; }
        public String Email { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public CustomerViewModel()
        {

        }

        public CustomerViewModel(int id, String customerName, String email, String city, String country)
        {
            Id = id;
            CustomerName = customerName;
            Email = email;
            City = city;
            Country = country;
        }
    }

}
