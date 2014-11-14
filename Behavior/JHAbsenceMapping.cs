using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 假別對照表類別，提供方法用來取得假別對照資訊
    /// </summary>
    public class JHAbsenceMapping : K12.Data.AbsenceMapping 
    {
        /// <summary>
        /// 取得所有假別對照資訊
        /// </summary>
        /// <returns>List&lt;JHAbsenceMappingInfo&gt;，代表假別對照資訊物件列表。</returns>
        [SelectMethod("JHSchool.JHAbsenceMapping.SelectAll", "學務.假別對照表")]
        public static new List<JHAbsenceMappingInfo> SelectAll()
        {
            return K12.Data.AbsenceMapping.SelectAll<JHAbsenceMappingInfo>();
        }
    }
}