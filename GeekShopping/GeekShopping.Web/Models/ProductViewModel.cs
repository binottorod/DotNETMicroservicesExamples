using System.ComponentModel.DataAnnotations;

namespace GeekShopping.Web.Models
{
    public class ProductViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }

        [Range(1, 100)]
        public int Count { get; set; } = 1;

        public string SubstringName()
        {
            if (Name.Length < 24)
            {
                return Name;
            }
            else
            {
                return $"{Name.Substring(0, 21)} ...";
            }
        }
        public string SubstringDescripition()
        {
            if (Description.Length < 355)
            {
                return Description;
            }
            else
            {
                return $"{Description.Substring(0, 355)} ...";
            }
        }

    }
}
