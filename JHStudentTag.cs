using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生標籤類別，提供方法用來取得、新增、修改及刪除學生標籤資訊
    /// </summary>
    public class JHStudentTag:K12.Data.StudentTag 
    {
        /// <summary>
        /// 取得所有學生標籤列表。
        /// </summary>
        /// <returns>List&lt;JHStudentTagRecord&gt;，代表多筆學生標籤物件。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHStudentTagRecord&gt; records = JHStudentTag.SelectAll();
        ///         
        ///         foreach(JHStudentTagRecord record in records)
        ///             System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHStudentTag.SelectAll", "學籍.學生類別")]
        public static new List<JHStudentTagRecord> SelectAll()
        {
            return K12.Data.StudentTag.SelectAll<JHStudentTagRecord>();
        }

        /// <summary>
        /// 根據單筆學生編號取得學生標籤列表。
        /// </summary>
        /// <param name="StudentID">學生編號</param>
        /// <returns>List&lt;JHStudentTagRecord&gt;，代表多筆學生標籤物件。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHStudentTagRecord&gt; records = JHStudentTag.SelectByStudentID(StudentID);
        ///         
        ///         foreach(JHStudentTagRecord record in records)
        ///           System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        public static new List<JHStudentTagRecord> SelectByStudentID(string StudentID)
        {
            return K12.Data.StudentTag.SelectByStudentID<JHStudentTagRecord>(StudentID);
        }


        /// <summary>
        /// 根據多筆學生編號取得學生標籤列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHStudentTagRecord&gt;，代表多筆學生標籤物件。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHStudentTagRecord&gt; records = JHStudentTag.SelectByStudentIDs(StudentIDs);
        ///     
        ///     forech(JHStudentTagRecord record in records)
        ///         System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        public static new List<JHStudentTagRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.StudentTag.SelectByStudentIDs<JHStudentTagRecord>(StudentIDs);
        }

        /// <summary>
        /// 新增單學生標籤記錄
        /// </summary>
        /// <param name="StudentTagRecord">學生標籤記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHStudentTagRecord  record = new JHStudentTagRecord(StudentID, TagConfigID); 
        ///     string NewID = JHStudentTag.Insert(record);  
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增傳入的參數為學生編號以及標籤編號。
        /// 2.回傳值為新增物件的系統編號。
        /// </remarks> 
        public static string Insert(JHStudentTagRecord StudentTagRecord)
        {
            return K12.Data.StudentTag.Insert(StudentTagRecord);
        }

        /// <summary>
        /// 新增多筆學生標籤記錄
        /// </summary>
        /// <param name="StudentTagRecords">多筆學生標籤記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHStudentTagRecord record = new JHStudentTagRecord(StudentID, TagConfigID); 
        ///     List&lt;JHStudentTagRecord&gt; records = new List&lt;JHStudentTagRecord&gt;();
        ///     records.Add(record);
        ///     List&lt;string&gt; NewIDs = JHStudentTag.Insert(records);  
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增傳入的參數為學生編號以及標籤編號。
        /// 2.回傳值為新增物件的系統編號。
        /// </remarks>
        public static List<string> Insert(IEnumerable<JHStudentTagRecord> StudentTagRecords)
        {
            return K12.Data.StudentTag.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentTagRecord,JHStudentTagRecord>(StudentTagRecords));
        }

        /// <summary>
        /// 更新單筆學生標籤記錄
        /// </summary>
        /// <param name="StudentTagRecord">學生標籤記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHStudentTagRecord&gt; records = JHStudentTag.SelectByStudentID(StudentID);        
        ///         records[0].RefEntityID = StudentID;
        ///         records[0].RefTagID = TagConfigID;
        ///         int UpdateCount = JHStudentTag.Update(record[0]);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.更新的欄位值只有StudentID及TagConfigID，其它為唯讀欄位。
        /// 2.傳回值為成功更新的筆數。
        /// </remarks>
        public static int Update(JHStudentTagRecord StudentTagRecord)
        {
            return K12.Data.StudentTag.Update(StudentTagRecord);
        }

        /// <summary>
        /// 更新多筆學生標籤記錄
        /// </summary>
        /// <param name="StudentTagRecords">多筆學生標籤記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHStudentTagRecord&gt; records = JHStudentTag.SelectByStudentID(StudentID);        
        ///         records[0].RefEntityID = StudentID;
        ///         records[0].RefTagID = TagConfigID;
        ///         int UpdateCount = JHStudentTag.Update(records);
        ///     </code>
        /// </example>
        public static int Update(IEnumerable<JHStudentTagRecord> StudentTagRecords)
        {
            return K12.Data.StudentTag.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentTagRecord, JHStudentTagRecord>(StudentTagRecords));        }

        /// <summary>
        /// 刪除多筆學生標籤記錄
        /// </summary>
        /// <param name="StudentTagRecords">多筆標籤記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHStudentTagRecord&gt; records = JHStudentTag.SelectByStudentID(StudentID);
        ///         int DeleteCount = StudentTag.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 傳回值為成功刪除的筆數。
        /// </remarks>        
        static public int Delete(IEnumerable<JHStudentTagRecord> StudentTagRecords)
        {
            return K12.Data.StudentTag.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentTagRecord, JHStudentTagRecord>(StudentTagRecords));        
        }

        /// <summary>
        /// 刪除單筆學生記錄
        /// </summary>
        /// <param name="StudentTagRecord">學生記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHStudentTagRecord&gt; records = JHStudentTag.SelectByStudentID(StudentID);
        ///         int DeleteCount = JHStudentTag.Delete(records[0]);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHStudentTagRecord StudentTagRecord)
        {
            return K12.Data.StudentTag.Delete(StudentTagRecord);
        }
    }
}