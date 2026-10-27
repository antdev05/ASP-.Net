namespace Bai03.Models
{
    public class Category
    {
        public int id { get; set; }
        public String name { get; set; } = string.Empty;

        public List<product> productions = new List<product>();
    }
}
