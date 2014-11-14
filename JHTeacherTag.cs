using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 教師標籤類別，提供方法用來取得、新增、修改及刪除班級標籤資訊
    /// </summary>
    public class JHTeacherTag:K12.Data.TeacherTag 
    {
        /// <summary>
        /// 取得所有教師標籤列表。
        /// </summary>
        /// <returns>List&lt;JHTeacherTagRecord&gt;，代表多筆教師標籤物件。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHTeacherTagRecord&gt; records = JHTeacherTag.SelectAll();
        ///        
        ///         foreach(JHTeacherTagRecord record in records)
        ///             System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHTeacherTag.SelectAll", "學籍.教師類別")]
        public static new List<JHTeacherTagRecord> SelectAll()
        {
            return K12.Data.TeacherTag.SelectAll<JHTeacherTagRecord>();
        }

        /// <summary>
        /// 根據單筆教師編號取得教師標籤列表。
        /// </summary>
        /// <param name="TeacherID">教師編號</param>
        /// <returns>List&lt;JHTeacherTagRecord&gt;，代表多筆教師標籤物件。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <sample>
        ///     <code>
        ///         List&lt;JHTeacherTagRecord&gt; records = JHTeacherTag.SelectByTeacherID(TeacherID);
        ///        
        ///         foreach(JHTeacherTagRecord record in records)
        ///           System.Console.WriteLine(record.Name);
        ///     </code>
        /// </sample>
        public static new List<JHTeacherTagRecord> SelectByTeacherID(string TeacherID)
        {
            return K12.Data.TeacherTag.SelectByTeacherID<JHTeacherTagRecord>(TeacherID);
        }

        /// <summary>
        /// 根據多筆教師編號取得教師標籤列表。
        /// </summary>
        /// <param name="TeacherIDs">多筆教師編號</param>
        /// <returns>List&lt;JHTeacherTagRecord&gt;，代表多筆教師標籤物件。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHTeacherTagRecord&gt; records = JHTeacherTag.SelectByTeacherIDs(TeacherIDs);
        ///    
        ///     forech(JHTeacherTagRecord record in records)
        ///         System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        public static new List<JHTeacherTagRecord> SelectByTeacherIDs(IEnumerable<string> TeacherIDs)
        {
            return K12.Data.TeacherTag.SelectByTeacherIDs<JHTeacherTagRecord>(TeacherIDs);
        }

        /// <summary>
        /// 新增單筆教師標籤記錄
        /// </summary>
        /// <param name="TeacherTagRecord">教師標籤記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHTeacherTagRecord  record = new JHTeacherTagRecord(TeacherID, TagConfigID);
        ///     string NewID = JHTeacherTag.Insert(record); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增傳入的參數為教師編號以及標籤編號。
        /// 2.回傳值為新增物件的系統編號。
        /// </remarks>
        public static string Insert(JHTeacherTagRecord TeacherTagRecord)
        {
            return K12.Data.TeacherTag.Insert(TeacherTagRecord);
        }

        /// <summary>
        /// 新增多筆教師標籤記錄
        /// </summary>
        /// <param name="TeacherTagRecords">多筆教師標籤記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHTeacherTagRecord record = new JHTeacherTagRecord(TeacherID, TagConfigID);
        ///     List&lt;JHTeacherTagRecord&gt; records = new List&lt;JHTeacherTagRecord&gt;();
        ///     records.Add(record);
        ///     List&lt;string&gt; NewIDs = JHTeacherTag.Insert(records); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增傳入的參數為教師編號以及標籤編號。
        /// 2.回傳值為新增物件的系統編號。
        /// </remarks>
        public static List<string> Insert(IEnumerable<JHTeacherTagRecord> TeacherTagRecords)
        {
            return K12.Data.TeacherTag.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.TeacherTagRecord, JHTeacherTagRecord>(TeacherTagRecords));
        }

        /// <summary>
        /// 更新單筆教師標籤記錄
        /// </summary>
        /// <param name="TeacherTagRecord"> 教師標籤記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHTeacherTagRecord&gt; records = JHTeacherTag.SelectByTeacherID(TeacherID);       
        ///         records[0].RefEntityID = TeacherID;
        ///         records[0].RefTagID = TagConfigID;
        ///         int UpdateCount = JHTeacherTag.Update(record[0]);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.更新的欄位值只有TeacherID及TagConfigID，其它為唯讀欄位。
        /// 2.傳回值為成功更新的筆數。
        /// </remarks>       
        public static int Update(JHTeacherTagRecord TeacherTagRecord)
        {
            return K12.Data.TeacherTag.Update(TeacherTagRecord);
        }

        /// <summary>
        /// 更新多筆教師標籤記錄
        /// </summary>
        /// <param name="TeacherTagRecords">多筆教師標籤記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHTeacherTagRecord&gt; records = JHTeacherTag.SelectByTeacherID(TeacherID);       
        ///         records[0].RefEntityID = TeacherID;
        ///         records[0].RefTagID = TagConfigID;
        ///         int UpdateCount = JHTeacherTag.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.更新的欄位值只有TeacherID及TagConfigID，其它為唯讀欄位。
        /// 2.傳回值為成功更新的筆數。
        /// </remarks>
        public static int Update(IEnumerable<JHTeacherTagRecord> TeacherTagRecords)
        {
            return K12.Data.TeacherTag.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.TeacherTagRecord, JHTeacherTagRecord>(TeacherTagRecords));
        }

        /// <summary>
        /// 刪除多筆教師標籤記錄
        /// </summary>
        /// <param name="TeacherTagRecords">多筆教師標籤記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHTeacherTagRecord&gt; records = JHTeacherTag.SelectByTeacherID(TeacherID);
        ///         int DeleteCount = JHTeacherTag.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 傳回值為成功刪除的筆數。
        /// </remarks>
        static public int Delete(IEnumerable<JHTeacherTagRecord> TeacherTagRecords)
        {
            return K12.Data.TeacherTag.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.TeacherTagRecord,JHTeacherTagRecord>(TeacherTagRecords));
        }

        /// <summary>
        /// 刪除單筆教師記錄
        /// </summary>
        /// <param name="TeacherTagRecord">教師記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHTeacherTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHTeacherTagRecord&gt; records = JHTeacherTag.SelectByTeacherID(TeacherID);
        ///         int DeleteCount = JHTeacherTag.Delete(records[0]);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHTeacherTagRecord TeacherTagRecord)
        {
            return K12.Data.TeacherTag.Delete(TeacherTagRecord);
        }
    }
}