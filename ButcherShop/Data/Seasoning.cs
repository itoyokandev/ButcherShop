using System.ComponentModel.DataAnnotations.Schema;

namespace ButcherShop.Data
{
    [Table("Seasoning")]
    public class Seasoning
    {
        /// <summary>
        /// 味付けID
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeasoningID { get; set; }

        /// <summary>
        /// 味付け名
        /// </summary>
        public string SeasoningName { get; set; } = string.Empty;

        /// <summary>
        /// よみがな
        /// </summary>
        public string Yomigana { get; set; } = string.Empty;

        /// <summary>
        /// カテゴリーID
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// カテゴリー
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// 並び順<br/>
        /// 初期値は、登録済みのカテゴリーと商品の最後のSortOrder+1を設定
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
