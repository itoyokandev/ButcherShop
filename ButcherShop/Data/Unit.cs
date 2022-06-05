using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ButcherShop.Data
{
    [Table("Unit")]
    public class Unit
    {
        /// <summary>
        /// 単位ID
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnitID { get; set; }

        /// <summary>
        /// 単位
        /// </summary>
        public string UnitName { get; set; } = string.Empty;

        /// <summary>
        /// 並び順<br/>
        /// 初期値は、登録済みの単位のSortOrder+1を設定
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
