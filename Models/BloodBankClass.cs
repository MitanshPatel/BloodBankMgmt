namespace BloodBank.Models
{
    public class BloodBankClass
    {
        public int Id { get; set; }
        public required string DonorName { get; set; }
        public int Age { get; set; }
        public required string BloodType { get; set; }
        public string? ContactInfo { get; set; }
        public int Quantity { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Status { get; set; }
    }
}
