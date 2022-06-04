using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButcherShop.Models
{
    [Table("Category")]
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Yomigana { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public int EditedUserID { get; set; }
        public DateTime EditedDatetime { get; set; }

    }
}
