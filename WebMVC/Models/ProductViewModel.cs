namespace WebMvc.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Category { get; set; }
        public int Price { get; set; }
        public ProductViewModel()
        {

        }
        public ProductViewModel(int id, string name, string category, int price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
