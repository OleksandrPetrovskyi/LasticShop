using System.ComponentModel.DataAnnotations.Schema;

namespace LasticShop.DatabaseModels
{
    public class Product
    {
        public int Id { get; set; }
        [Column("CreatorID")]
        public int UserId { get; set; }
        public List<Review> Reviews { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<string>? IMG { get; set; }
    }
}
