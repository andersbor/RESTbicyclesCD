namespace RESTbicyclesCD.Models
{
    public class Bicycle
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return Id + " " + Brand;
        }
    }
}
