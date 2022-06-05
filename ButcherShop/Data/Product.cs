using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButcherShop.Data
{
    [Table("Product")]
    public class Product
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// よみがな
        /// </summary>
        public string Yomigana { get; set; } = string.Empty;

        /// <summary>
        /// カテゴリーID
        /// <para>初期値は、カテゴリー未指定(CategoryID:1)を設定</para>
        /// </summary>
        public int CategoryID { get; set; } = 1;

        /// <summary>
        /// ラベル印刷対象
        /// <para>false:印刷対象外, true:印刷対象</para>
        /// </summary>
        public bool LabelPrintingTarget { get; set; } = true;

        /// <summary>
        /// 味付け対象
        /// <para>false:味付け対象外, true:味付け対象</para>
        /// </summary>
        public bool TargetOfSeasoning { get; set; } = true;

        /// <summary>
        /// 単位ID
        /// </summary>
        public int UnitID { get; set; }

        /// <summary>
        /// 単価(100g当たり)
        /// </summary>
        public decimal? UnitPrice { get; set; } = null;

        /// <summary>
        /// 消費税率
        /// </summary>
        public decimal TaxRate { get; set; }

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
