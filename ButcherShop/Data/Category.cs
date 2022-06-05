using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButcherShop.Data
{
    [Table("Category")]
    public class Category
    {
        /// <summary>
        /// カテゴリーID
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        /// <summary>
        /// カテゴリー名
        /// </summary>
        public string CategoryName { get; set; } = string.Empty;

        /// <summary>
        /// よみがな
        /// </summary>
        public string Yomigana { get; set; } = string.Empty;

        /// <summary>
        /// 並び順<br/>
        /// 初期値は、登録済みのカテゴリーのSortOrder+1を設定
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// 編集ユーザーID
        /// </summary>
        public int EditedUserID { get; set; }

        /// <summary>
        /// 編集日時
        /// </summary>
        public DateTime EditedDatetime { get; set; }
    }
}
