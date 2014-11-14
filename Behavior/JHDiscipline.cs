using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生獎懲類別，提供方法用來取得、新增、修改及刪除學生獎懲資訊
    /// </summary>
    public class JHDiscipline:K12.Data.Discipline
    {
        /// <summary>
        /// 取得所有學生獎懲記錄物件列表。
        /// </summary>
        /// <returns>List&lt;JHDisciplineRecord&gt;，代表多筆學生獎懲記錄物件。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDisciplineRecord&gt; records = JHDisciplineRecord.SelectAll();
        ///     
        ///     foreach(JHDisciplineRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHDiscipline.SelectAll", "學務.獎懲")]
        public new static List<JHDisciplineRecord> SelectAll()
        {
            return SelectAll<JHDisciplineRecord>();
        }

        /// <summary>
        /// 根據多筆學生編號取得學生獎懲記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHDisciplineRecord&gt;，代表多筆學生獎懲記錄物件。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDisciplineRecord&gt; records = JHDiscipline.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHDisciplineRecord record in records)
        ///         Console.WrlteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHDisciplineRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.Discipline.SelectByStudentIDs<JHDisciplineRecord>(StudentIDs);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Obsolete("此方法已不再使用。")] 
        public static new List<JHDisciplineRecord> SelectRegisterDate(IEnumerable<string> StudentIDs, DateTime? StartRegisterDate, DateTime? EndRegisterDate)
        {
            return K12.Data.Discipline.SelectByRegisterDate<JHDisciplineRecord>(StudentIDs, StartRegisterDate, EndRegisterDate);
        }

        /// <summary>
        /// 根據多筆學生編號及登錄日期取得學生獎懲記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="StartRegisterDate">登錄開始日期</param>
        /// <param name="EndRegisterDate">登錄結束日期</param>
        /// <returns>List&lt;JHDisciplineRecord&gt;，代表多筆學生獎懲記錄物件。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDisciplineRecord&gt; records = JHDiscipline.SelectRegisterDate(StudentIDs,StartRegisterDate,EndRegisterDate);
        ///     
        ///     foreach(JHDisciplineRecord record in records)
        ///         Console.WrlteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHDisciplineRecord> SelectByRegisterDate(IEnumerable<string> StudentIDs, DateTime? StartRegisterDate, DateTime? EndRegisterDate)
        {
            return K12.Data.Discipline.SelectByRegisterDate<JHDisciplineRecord>(StudentIDs, StartRegisterDate, EndRegisterDate);
        }

        /// <summary>
        /// 根據多筆學生編號及發生日期取得學生獎懲記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="StartOccurDate">發生開始日期</param>
        /// <param name="EndOccurDate">發生結束日期</param>
        /// <returns>List&lt;JHDisciplineRecord&gt;，代表多筆學生獎懲記錄物件。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDisciplineRecord&gt; records = JHDiscipline.SelectByOccurDate(StudentIDs,StartOccurDate,EndOccurDate);
        ///     
        ///     foreach(JHDisciplineRecord record in records)
        ///         Console.WrlteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHDisciplineRecord> SelectByOccurDate(IEnumerable<string> StudentIDs, DateTime? StartOccurDate, DateTime? EndOccurDate)
        {
            return K12.Data.Discipline.SelectByOccurDate<JHDisciplineRecord>(StudentIDs, StartOccurDate, EndOccurDate);
        }

        /// <summary>
        /// 新增單筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineRecord">學生獎懲記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHDisciplineRecord newrecord = new JHDisciplineRecord();
        ///         newrecord.RefStudentID = RefStudentID;
        ///         newrecord.SchoolYear = SchoolYear;
        ///         newrecord.Semester = Semester;
        ///         newrecord.OccurDate = DateTime.Today;
        ///         strng NewID = JHDiscipline.Insert(newrecord)
        ///         JHDisciplineRecord record = JHDiscipline.SelectByID(NewID);
        ///         System.Console.Writeln(record.RefStudentID);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為學生記錄編號（RefStudentID）、學年度（SchoolYear）、學期（Semester）、缺曠日期（OccurDate）。
        /// </remarks>
        public static string Insert(JHDisciplineRecord DisciplineRecord)
        {
            return K12.Data.Discipline.Insert(DisciplineRecord);
        }

        /// <summary>
        /// 新增多筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineRecords">多筆學生獎懲記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHDisciplineRecord record = new JHDisciplineRecord();
        ///         newrecord.RefStudentID = RefStudentID;
        ///         newrecord.SchoolYear = SchoolYear;
        ///         newrecord.Semester = Semester;
        ///         newrecord.OccurDate = DateTime.Today;
        ///         
        ///         List&lt;JHDisciplineRecord&gt; records = new List&lt;JHDisciplineRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHDiscipline.Insert(records)
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHDisciplineRecord> DisciplineRecords)
        {
            return K12.Data.Discipline.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.DisciplineRecord, JHDisciplineRecord>(DisciplineRecords));
        }

        /// <summary>
        /// 更新單筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineRecord">學生獎懲記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHDisciplineRecord record = JHDiscipline.SelectByStudentIDs(StudentIDs)[0];
        ///     record.OccurDate = DateTime.Today;
        ///     int UpdateCount = JHDiscipline.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHDisciplineRecord DisciplineRecord)
        {
            return K12.Data.Discipline.Update(DisciplineRecord);
        }

        /// <summary>
        /// 更新多筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineRecords">多筆學生獎懲記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHDisciplineRecord record = JHDiscipline.SelectByStudentIDs(StudentIDs)[0];
        ///     record.OccurDate = DateTime.Today;
        ///     List&lt;JHDisciplineRecord&gt; records = new List&lt;JHDisciplineRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHDiscipline.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHDisciplineRecord> DisciplineRecords)
        {
            return K12.Data.Discipline.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.DisciplineRecord,JHDisciplineRecord>(DisciplineRecords));
        }

        /// <summary>
        /// 刪除單筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineRecord">學生獎懲記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHDisciplineRecord&gt; records = JHDiscipline.SelectByStudentIDs(StudentIDs);
        ///       int DeleteCount = JHDiscipline.Delete(records[0]);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHDisciplineRecord DisciplineRecord)
        {
            return K12.Data.Discipline.Delete(DisciplineRecord);
        }

        /// <summary>
        /// 刪除單筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineID">學生獎懲記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHDiscipline.Delete(DisciplineID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string DisciplineID)
        {
            return K12.Data.Discipline.Delete(DisciplineID);
        }

        /// <summary>
        /// 刪除多筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineRecords">多筆學生獎懲記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHDisciplineRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHDisciplineRecord&gt; records = JHDiscipline.SelectByStudentIDs(StudentIDs);
        ///       int DeleteCount = JHDiscipline.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHDisciplineRecord> DisciplineRecords)
        {
            return K12.Data.Discipline.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.DisciplineRecord, JHDisciplineRecord>(DisciplineRecords));
        }

        /// <summary>
        /// 刪除多筆學生獎懲記錄
        /// </summary>
        /// <param name="DisciplineIDs">多筆學生獎懲記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHDiscipline.Delete(DisciplineIDs);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(IEnumerable<string> DisciplineIDs)
        {
            return K12.Data.Discipline.Delete(DisciplineIDs);
        }
    }
}