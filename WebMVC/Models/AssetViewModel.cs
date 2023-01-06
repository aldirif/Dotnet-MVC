namespace WebMvc.Models
{
    public class AssetViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String SerialNumber { get; set; }
        public int PurchaseYear { get; set; }
        public String Location { get; set; }

        public AssetViewModel()
        {

        }
        public AssetViewModel(int id, String name, String serialNumber, int purchaseYear, String location)
        {
            Id = id;
            Name = name;
            SerialNumber = serialNumber;
            PurchaseYear = purchaseYear;
            Location = location;
        }
    }
}
