namespace GestorVeiculos.Data.Models
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public Car CarID { get; set; }
        public int? AddedKm { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
