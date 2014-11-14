using System;
using System.Collections.Generic;
using K12.Data;
using K12.Data.Utility;

namespace JHSchool.Data
{
    /// <summary>
    /// 評量設定類別，提供方法用來取得、新增、修改及刪除評量設定資訊
    /// </summary>
    public class JHAssessmentSetup:K12.Data.AssessmentSetup 
    {
        /// <summary>
        /// 取得所有評量設定列表。
        /// </summary>
        /// <returns>List&lt;JHAssessmentSetupRecord&gt;，代表多筆評量設定記錄物件。</returns>
        /// <seealso cref="JHAssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHAssessmentSetupRecord&gt; records = JHAssessmentSetup.SelectAll();
        /// </example>
        [SelectMethod("JHSchool.JHAssessmentSetup.SelectAll", "成績.評量設定")]
        public static List<JHAssessmentSetupRecord> SelectAll()
        {
            return SelectAll<JHAssessmentSetupRecord>();
        }

        /// <summary>
        /// 根據評量設定編號取得評量設定記錄物件。
        /// </summary>
        /// <param name="AssessmentSetupID">評量設定編號</param>
        /// <returns>JHAssessmentSetupRecord，代表評量設定記錄物件。</returns>
        /// <seealso cref="JHAssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHAssessmentSetupRecord&gt; records = JHAssessmentSetup.SelectByID(AssessmentSetupID);
        /// </example>
        public static JHAssessmentSetupRecord SelectByID(string AssessmentSetupID)
        {
            return SelectByID<JHAssessmentSetupRecord>(AssessmentSetupID);
        }

        /// <summary>
        /// 根據多筆評量設定編號取得評量設定列表。
        /// </summary>
        /// <param name="AssessmentSetupIDs">多筆評量設定編號</param>
        /// <returns>List&lt;JHAssessmentSetupRecord&gt;，代表多筆評量設定記錄物件。</returns>
        /// <seealso cref="JHAssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHAssessmentSetupRecord&gt; records = JHAssessmentSetup.SelectByIDs(AssessmentSetupIDs);
        /// </example>
        public static List<JHAssessmentSetupRecord> SelectByIDs(IEnumerable<string> AssessmentSetupIDs)
        {
            return SelectByIDs<JHAssessmentSetupRecord>(AssessmentSetupIDs);
        }

        /// <summary>
        /// 新增單筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecord">評量設定記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHAssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        public static string Insert(JHAssessmentSetupRecord AssessmentSetupRecord)
        {
            return K12.Data.AssessmentSetup.Insert(AssessmentSetupRecord);
        }

        /// <summary>
        /// 新增多筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecords">多筆評量設定記錄物件</param> 
        /// <returns>List&lt;string&gt，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="AssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static List<string> Insert(IEnumerable<JHAssessmentSetupRecord> AssessmentSetupRecords)
        {
            return K12.Data.AssessmentSetup.Insert(Utility.GetBaseList<K12.Data.AssessmentSetupRecord, JHAssessmentSetupRecord>(AssessmentSetupRecords));
        }

        /// <summary>
        /// 更新單筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecord">評量設定記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="AssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(JHAssessmentSetupRecord AssessmentSetupRecord)
        {
            return K12.Data.AssessmentSetup.Update(AssessmentSetupRecord);
        }

        /// <summary>
        /// 更新多筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecords">多筆評量設定記錄</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="AssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(IEnumerable<JHAssessmentSetupRecord> AssessmentSetupRecords)
        {
            return K12.Data.AssessmentSetup.Update(Utility.GetBaseList<K12.Data.AssessmentSetupRecord, JHAssessmentSetupRecord>(AssessmentSetupRecords));
        }

        /// <summary>
        /// 刪除單筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecord">評量設定記錄物件</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="AssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(JHAssessmentSetupRecord AssessmentSetupRecord)
        {
            return K12.Data.AssessmentSetup.Delete(AssessmentSetupRecord);
        }

        /// <summary>
        /// 刪除單筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecordID">評量設定記錄編號</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(string AssessmentSetupID)
        {
            return K12.Data.AssessmentSetup.Delete(AssessmentSetupID);
        }

        /// <summary>
        /// 刪除多筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecords">多筆評量設定記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="AssessmentSetupRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(IEnumerable<JHAssessmentSetupRecord> AssessmentSetupRecords)
        {
            return K12.Data.AssessmentSetup.Delete(Utility.GetBaseList<K12.Data.AssessmentSetupRecord, JHAssessmentSetupRecord>(AssessmentSetupRecords));
        }

        /// <summary>
        /// 刪除多筆評量設定記錄
        /// </summary>
        /// <param name="AssessmentSetupRecordIDs">多筆評量設定記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(IEnumerable<string> AssessmentSetupIDs)
        {
            return K12.Data.AssessmentSetup.Delete(AssessmentSetupIDs);
        }
    }
}
