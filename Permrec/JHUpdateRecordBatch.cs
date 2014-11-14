using System;
using System.Collections.Generic;

namespace JHSchool.Data
{
    /// <summary>
    /// 異動名冊記錄類別，提供方法用來取得、新增、修改及刪除異動名冊記錄物件
    /// </summary>
    public class JHUpdateRecordBatch:K12.Data.UpdateRecordBatch 
    {
        /// <summary>
        /// 取得所有異動名冊記錄列表。
        /// </summary>
        /// <returns>List&lt;JHUpdateRecordBatchRecord&gt;，代表多筆異動名冊記錄物件。</returns>
        /// <seealso cref="JHUpdateReocrdBatchRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordBatchRecord&gt; records = JHUpdateRecordBatch.SelectAll();
        ///     
        ///     foreach(JHUpdateRecordBatchRecord record in records)
        ///         Console.WrlteLine(record.Name);
        ///     </code>
        /// </example>
        public static new List<JHUpdateReocrdBatchRecord> SelectAll()
        {
            return K12.Data.UpdateRecordBatch.SelectAll<JHUpdateReocrdBatchRecord>();
        }

        /// <summary>
        /// 根據異動名冊記錄編號取得異動名冊記錄物件。
        /// </summary>
        /// <param name="UpdateRecordBatchID">異動名冊記錄編號</param>
        /// <returns>UpdateRecordBatchRecord，代表單筆異動名冊記錄編號。</returns>
        /// <seealso cref="JHUpdateReocrdBatchRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHUpdateRecordBatchRecord record = JHUpdateRecordBatch.SelectByID("15");
        ///     
        ///     Console.WrlteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>若是UpdateRecordBatchID不存在則會傳回null。</remarks>
        public static new JHUpdateReocrdBatchRecord SelectByID(string UpdateRecordBatchID)
        {
            return K12.Data.UpdateRecordBatch.SelectByID<JHUpdateReocrdBatchRecord>(UpdateRecordBatchID);
        }

        /// <summary>
        /// 根據異動名冊記錄編號取得異動名冊記錄物件列表。
        /// </summary>
        /// <param name="UpdateRecordBatchIDs">多筆異動名冊記錄編號。</param>
        /// <returns>List&lt;JHUpdateRecordBatchRecord&gt;，代表多筆異動名冊記錄物件。</returns>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordBatchRecord&gt; records = JHUpdateRecordBatch.SelectByIDs(UpdateRecordBatchIDs);
        ///     
        ///     foreach(JHUpdateRecordBatchRecord record in records)
        ///         Console.WrlteLine(record.Name);
        ///     </code>
        /// </example>
        public static new List<JHUpdateReocrdBatchRecord> SelectByIDs(IEnumerable<string> UpdateRecordBatchIDs)
        {
            return K12.Data.UpdateRecordBatch.SelectByIDs<JHUpdateReocrdBatchRecord>(UpdateRecordBatchIDs);
        }

        /// <summary>
        /// 根據學年度及學期取得異動名冊記錄物件列表。
        /// </summary>
        /// <param name="SchoolYear">學年度，若是傳入null則會傳回所有學年度資料。</param>
        /// <param name="Semester">學期，若是傳入null則會傳回所有學期資料。</param>
        /// <returns>List&lt;JHUpdateRecordBatchRecord&gt;，代表多筆異動名冊記錄物件。</returns>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordBatchRecord&gt; records = JHUpdateRecordBatch.SelectBySchoolYearAndSemester(UpdateRecordBatchIDs);
        ///     
        ///     foreach(JHUpdateRecordBatchRecord record in records)
        ///         Console.WrlteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>若是學年度及學期參數皆傳入null，則會傳回所有資料。</remarks>
        public static new List<JHUpdateReocrdBatchRecord> SelectBySchoolYearAndSemester(int? SchoolYear, int? Semester)
        {
            return SelectBySchoolYearAndSemester<JHUpdateReocrdBatchRecord>(SchoolYear, Semester);
        }


        /// <summary>
        /// 新增單筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchRecord">異動名冊記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHUpdateReocrdBatchRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHUpdateRecordBatchRecord newrecord = new JHUpdateRecordBatchRecord();
        ///         newrecord.Name ="test";
        ///         newrecord.SchoolYear = 95;
        ///         newrecord.Semester = 1;
        ///         strng NewID = JHUpdateRecordBatch.Insert(newrecord)
        ///         JHUpdateRecordBatchRecord record = JHUpdateRecordBatch.SelectByID(NewID);
        ///         System.Console.Writeln(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為異動名冊名稱、學年度及學期。
        /// </remarks>
        public static string Insert(JHUpdateReocrdBatchRecord UpdateRecordBatchRecord)
        {
            return K12.Data.UpdateRecordBatch.Insert(UpdateRecordBatchRecord);
        }

        /// <summary>
        /// 新增多筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchRecords">多筆異動名冊記錄</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHUpdateReocrdBatchRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHUpdateRecordBatchRecord record = new JHUpdateRecordBatchRecord();
        ///         
        ///         record.Name ="新生異動名冊";
        ///         record.SchoolYear = 96;
        ///         record.Semester = 1;
        ///         
        ///         List&lt;JHUpdateRecordBatchRecord&gt; records = new List&lt;JHUpdateRecordBatchRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHUpdateRecordBatch.Insert(records)
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHUpdateReocrdBatchRecord> UpdateRecordBatchRecords)
        {
            return K12.Data.UpdateRecordBatch.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.UpdateRecordBatchRecord, JHUpdateReocrdBatchRecord>(UpdateRecordBatchRecords));  
        }

        /// <summary>
        /// 更新單筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchRecord">異動名冊記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHUpdateReocrdBatchRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHUpdateRecordBatchRecord record = JHUpdateRecordBatch.SelectByID(UpdateRecordBatchID);
        ///     record.Name = "轉入異動名冊";
        ///     int UpdateCount = JHUpdateRecordBatch.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHUpdateReocrdBatchRecord UpdateRecordBatchRecord)
        {
            return K12.Data.UpdateRecordBatch.Update(UpdateRecordBatchRecord);
        }

        /// <summary>
        /// 更新多筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchRecords">多筆異動名冊記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHUpdateReocrdBatchRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHUpdateRecordBatchRecord record = JHUpdateRecordBatch.SelectByID(UpdateRecordBatchID);
        ///     record.Name = "畢業異動名冊";
        ///     List&lt;JHUpdateRecordBatchRecord&gt; records = new List&lt;JHUpdateRecordBatchRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHUpdateRecordBatch.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHUpdateReocrdBatchRecord> UpdateRecordBatchRecords)
        {
            return K12.Data.UpdateRecordBatch.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.UpdateRecordBatchRecord, JHUpdateReocrdBatchRecord>(UpdateRecordBatchRecords));  
        }


        /// <summary>
        /// 刪除多筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchRecords">多筆異動名冊記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHUpdateReocrdBatchRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHUpdateRecordBatchRecord&gt; records = JHUpdateRecordBatch.SelectByIDs(UpdateRecordIDs);
        ///       int DeleteCount = JHUpdateRecordBatch.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHUpdateReocrdBatchRecord> UpdateRecordBatchRecords)
        {
            return K12.Data.UpdateRecordBatch.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.UpdateRecordBatchRecord, JHUpdateReocrdBatchRecord>(UpdateRecordBatchRecords));  
        }

        /// <summary>
        /// 刪除多筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchIDs">多筆異動名冊記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///    <code>
        ///    int DeleteCount = JHUpdateRecordBatch.Delete(UpdateRecordBatchIDs);
        ///    </code>
        /// </example>
        static public new int Delete(IEnumerable<string> UpdateRecordBatchIDs)
        {
            return K12.Data.UpdateRecordBatch.Delete(UpdateRecordBatchIDs);
        }

        /// <summary>
        /// 刪除單筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchRecord">單筆異動名冊記錄物</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       JHUpdateRecordBatchRecord&gt; record = JHUpdateRecordBatch.SelectByID(UpdateRecordBatchID);
        ///       int DeleteCount = JHUpdateRecordBatch.Delete(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHUpdateReocrdBatchRecord UpdateRecordBatchRecord)
        {
            return K12.Data.UpdateRecordBatch.Delete(UpdateRecordBatchRecord);
        }

        /// <summary>
        /// 刪除單筆異動名冊記錄
        /// </summary>
        /// <param name="UpdateRecordBatchID">單筆異動名冊記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHUpdateRecordBatch.Delete(UpdateRecordID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string UpdateRecordBatchID)
        {
            return K12.Data.UpdateRecordBatch.Delete(UpdateRecordBatchID);
        }
    }
}