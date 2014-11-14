using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 節次對照表類別，提供方法用來取得節次對照資訊
    /// </summary>
    public class JHPeriodMapping:K12.Data.PeriodMapping
    {
        /// <summary>
        /// 取得所有節次對照表清單
        /// </summary>
        /// <returns>List&lt;JHPeriodMappingInfo&gt;，代表節次對照資訊物件列表。</returns>
        [SelectMethod("JHSchool.JHPeriodMapping.SelectAll", "學務.節次對照表")]
        public static new List<JHPeriodMappingInfo> SelectAll()
        {
            return K12.Data.PeriodMapping.SelectAll<JHPeriodMappingInfo>();
        }
    }
}