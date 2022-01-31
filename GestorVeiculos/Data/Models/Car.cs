namespace GestorVeiculos.Data.Models
{
    public class Car
    {
        public string? CarName { get; set; }
        public string? Plate { get; set; }
        
        public DateTime InspectionDate { get; set; }
        public int KilometersDone { get; set; }
        public int KilometersLimit { get; set; }
        public int TiresLimit { get; set; }
        public int TiresDone { get; set; }
        public bool AlertMessage { get; set; }
    }
}
