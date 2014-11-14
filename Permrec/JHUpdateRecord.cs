using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生異動記錄類別，提供方法用來取得、新增、修改及刪除學生異動記錄
    /// </summary>
    public class JHUpdateRecord:K12.Data.UpdateRecord 
    {
        /// <summary>
        /// 取得所有學生異動記錄列表。
        /// </summary>
        /// <returns>List&lt;JHUpdateRecordRecord&gt;，代表多筆學生異動記錄物件。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordRecord&gt; records = JHUpdateRecord.SelectAll();
        ///     
        ///     foreach(JHUpdateRecordRecord record in records)
        ///         Console.WrlteLine(record.StudentName);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHUpdateRecord.SelectAll", "學籍.異動記錄")]
        public static new List<JHUpdateRecordRecord> SelectAll()
        {
            return K12.Data.UpdateRecord.SelectAll<JHUpdateRecordRecord>();
        }

        /// <summary>
        /// 根據單筆學生編號取得學生異動記錄列表。
        /// </summary>
        /// <param name="StudentID">學生記錄編號</param>
        /// <returns>List&lt;JHUpdateRecordRecord&gt;，代表多筆學生異動記錄列表。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordRecord&gt; record = JHUpdateRecord.SelectByStudentID(StudentID);
        ///     
        ///     if (record != null)
        ///        System.Console.WriteLine(record.StudentName);
        ///     </code>
        /// </example>
        /// <remarks>若是StudentID不則在則會傳回null</remarks>
        public static new List<JHUpdateRecordRecord> SelectByStudentID(string StudentID)
        {
            return K12.Data.UpdateRecord.SelectByStudentID<JHUpdateRecordRecord>(StudentID);
        }

        /// <summary>
        /// 根據單筆學生編號取得學生異動記錄列表。
        /// </summary>
        /// <param name="Student">學生記錄物件</param>
        /// <returns>List&lt;JHUpdateRecordRecord&gt;，代表多筆學生異動記錄列表。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordRecord&gt; record = JHUpdateRecord.SelectByStudent(Student);
        ///     
        ///     if (record != null)
        ///        System.Console.WriteLine(record.StudentName);
        ///     </code>
        /// </example>
        public static List<JHUpdateRecordRecord> SelectByStudent(JHStudentRecord Student)
        {
            return K12.Data.UpdateRecord.SelectByStudent<JHUpdateRecordRecord>(Student);
        }

        /// <summary>
        /// 根據多筆學生編號取得學生異動記錄列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>List&lt;JHUpdateRecordRecord&gt;，代表多筆學生異動記錄物件。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordRecord&gt; records = JHUpdateRecord.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHUpdateRecordRecord record in records)
        ///         System.Console.WriteLine(record.StudentName);
        ///     </code>
        /// </example>
        public static new List<JHUpdateRecordRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.UpdateRecord.SelectByStudentIDs<JHUpdateRecordRecord>(StudentIDs);
        }

        /// <summary>
        /// 根據多筆學生物件取得學生異動記錄列表。
        /// </summary>
        /// <param name="Students">多筆學生記錄物件</param>
        /// <returns>List&lt;JHUpdateRecordRecord&gt;，代表多筆學生異動記錄物件。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordRecord&gt; records = JHUpdateRecord.SelectByStudents(Students);
        ///     
        ///     foreach(JHUpdateRecordRecord record in records)
        ///         System.Console.WriteLine(record.StudentName);
        ///     </code>
        /// </example>
        public static List<JHUpdateRecordRecord> SelectByStudents(IEnumerable<JHStudentRecord> Students)
        {
            return K12.Data.UpdateRecord.SelectByStudents<JHUpdateRecordRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord,JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據多筆異動記錄編號取得學生異動記錄列表。
        /// </summary>
        /// <param name="IDs">多筆異動記錄編號</param>
        /// <returns>List&lt;JHUpdateRecordRecord&gt;，代表多筆學生異動記錄物件。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordRecord&gt; records = JHUpdateRecord.SelectByIDs(IDs);
        ///     
        ///     foreach(JHUpdateRecordRecord record in records)
        ///         System.Console.WriteLine(record.StudentName);
        ///     </code>
        /// </example>
        public new static List<JHUpdateRecordRecord> SelectByIDs(IEnumerable<string> IDs)
        {
            return SelectByIDs<JHUpdateRecordRecord>(IDs);
        }

        /// <summary>
        /// 根據異動代碼取得學生異動記錄列表。
        /// </summary>
        /// <param name="UpdateCodes">多個異動代碼</param>
        /// <returns>List&lt;JHUpdateRecordRecord&gt;，代表多筆學生異動記錄物件。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHUpdateRecordRecord&gt; records = JHUpdateRecord.SelectByUpdateCodes(UpdateCodes);
        ///     </code>
        /// </example>
        public static new List<JHUpdateRecordRecord> SelectByUpdateCodes(IEnumerable<string> UpdateCodes)
        {
            return SelectByUpdateCodes<JHUpdateRecordRecord>(UpdateCodes);
        }

        /// <summary>
        /// 新增單筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordRecord">學生異動記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHUpdateRecordRecord newrecord = new JHUpdateRecordRecord();
        ///         newrecord.StudentID = StudentID;
        ///         newrecord.UpdateDate = "2009/9/9";
        ///         strng NewID = JHUpdateRecord.Insert(newrecord)
        ///         JHUpdateRecordRecord record = JHUpdateRecord.SelectByID(NewID);
        ///         System.Console.Writeln(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為學生編號及異動日期。
        /// </remarks>
        public static string Insert(JHUpdateRecordRecord UpdateRecordRecord)
        {
            return K12.Data.UpdateRecord.Insert(UpdateRecordRecord);
        }

        /// <summary>
        /// 新增多筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordRecords">多筆學生異動記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHUpdateRecordRecord record = new JHUpdateRecordRecord();
        ///         record.StudentID = StudentID;
        ///         record.UpdateDate = "2009/9/9";
        ///         List&lt;JHUpdateRecordRecord&gt; records = new List&lt;JHUpdateRecordRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHupdateRecord.Insert(records)
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHUpdateRecordRecord> UpdateRecordRecords)
        {
            return K12.Data.UpdateRecord.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.UpdateRecordRecord, JHUpdateRecordRecord>(UpdateRecordRecords));  
        }

        /// <summary>
        /// 更新單筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordRecord">學生異動記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHUpdateRecordRecord record = JHUpdateRecord.SelectByID(ClassID);
        ///     record.StudentName = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHUpdateRecord.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHUpdateRecordRecord UpdateRecordRecord)
        {
            return K12.Data.UpdateRecord.Update(UpdateRecordRecord);
        }

        /// <summary>
        /// 更新多筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordRecords">多筆學生異動記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHUpdateRecordRecord record = JHUpdateRecord.SelectByID(UpdateRecordID);
        ///     record.StudentName = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHUpdateRecordRecord&gt; records = new List&lt;JHUpdateRecordRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHUpdateRecord.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHUpdateRecordRecord> UpdateRecordRecords)
        {
            return K12.Data.UpdateRecord.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.UpdateRecordRecord, JHUpdateRecordRecord>(UpdateRecordRecords));  
        }

        /// <summary>
        /// 刪除多筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordRecords">多筆學生異動記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHUpdateRecordRecord&gt; records = JHUpdateRecord.SelectByIDs(UpdateRecordIDs);
        ///       int DeleteCount = JHUpdateRecord.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHUpdateRecordRecord> UpdateRecordRecords)
        {
            return K12.Data.UpdateRecord.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.UpdateRecordRecord, JHUpdateRecordRecord>(UpdateRecordRecords));  
        }

        /// <summary>
        /// 刪除多筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordIDs">多筆學生異動記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///    <code>
        ///    int DeleteCount = JHUpdateRecord.Delete(UpdateRecordIDs);
        ///    </code>
        /// </example>
        static public new int Delete(IEnumerable<string> UpdateRecordIDs)
        {
            return K12.Data.UpdateRecord.Delete(UpdateRecordIDs); 
        }

        /// <summary>
        /// 刪除單筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordRecord">單筆學生異動記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHUpdateRecordRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       JHUpdateRecordRecord&gt; record = JHUpdateRecord.SelectByID(UpdateRecordID);
        ///       int DeleteCount = JHUpdateRecord.Delete(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHUpdateRecordRecord UpdateRecordRecord)
        {
            return K12.Data.UpdateRecord.Delete(UpdateRecordRecord);
        }

        /// <summary>
        /// 刪除單筆學生異動記錄
        /// </summary>
        /// <param name="UpdateRecordID">單筆學生異動記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHUpdateRecord.Delete(UpdateRecordID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string UpdateRecordID)
        {
            return K12.Data.UpdateRecord.Delete(UpdateRecordID);
        }
    }
}