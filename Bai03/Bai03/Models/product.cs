using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Bai03.Models
{
    public class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public Category category { set; get; } = null;
    }
}
