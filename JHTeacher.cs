using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 教師類別，提供方法用來取得、新增、修改及刪除教師資訊
    /// </summary>
    public class JHTeacher : K12.Data.Teacher
    {

        /// <summary>
        /// 取得所有教師記錄列表。
        /// </summary>
        /// <returns>List&lt;JHTeacherRecord&gt;，代表多筆教師記錄物件。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHTeacherRecord&gt; records = JHTeacher.SelectAll();
        ///     
        ///     foreach(JHTeacherRecord record in records)
        ///         System.Console.Writeln(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 請先using K12.Data;
        /// </remarks> 
        [SelectMethod("JHSchool.JHTeacher.SelectAll", "學籍.教師")]
        public static new List<JHTeacherRecord> SelectAll()
        {
            return K12.Data.Teacher.SelectAll<JHTeacherRecord>();
        }


        /// <summary>
        /// 根據單筆教師編號取得教師記錄物件。
        /// </summary>
        /// <param name="TeacherID">教師編號</param>
        /// <returns>JHTeacherRecord，代表教師記錄物件。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHTeacherRecord record = JHTeacher.SelectByID(TeacherID);
        ///     
        ///    if (record != null)
        ///        System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>若是TeacherID不則在則會傳回null</remarks>
        public static new JHTeacherRecord SelectByID(string TeacherID)
        {
            return K12.Data.Teacher.SelectByID<JHTeacherRecord>(TeacherID);
        }

        /// <summary>
        /// 根據多筆教師編號取得教師記錄列表。
        /// </summary>
        /// <param name="TeacherIDs">多筆教師編號</param>
        /// <returns>List&lt;JHTeacherRecord&gt;，代表多教師記錄物件。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHTeacherRecord&gt; records = JHTeacher.SelectByIDs(TeacherIDs);
        ///     
        ///     foreach(JHTeacherRecord record in records)
        ///         Console.WrlteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆ID，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static new List<JHTeacherRecord> SelectByIDs(IEnumerable<string> TeacherIDs)
        {
            return K12.Data.Teacher.SelectByIDs<JHTeacherRecord>(TeacherIDs);
        }

        /// <summary>
        /// 新增單筆教師記錄
        /// </summary>
        /// <param name="TeacherRecord">教師記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHTeacherRecord newrecord = new JHTeacherRecord();
        ///         newrecord.Name = (new System.Random()).NextDouble().ToString();
        ///         strng NewID = JHTeacher.Insert(newrecord)
        ///         JHTeacherRecord record = JHTeacher.SelectByID(NewID);
        ///         System.Console.Writeln(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為課程名稱（Name）。
        /// </remarks>
        public static string Insert(JHTeacherRecord TeacherRecord)
        {
            return K12.Data.Teacher.Insert(TeacherRecord);
        }

        /// <summary>
        /// 新增多筆教師記錄
        /// </summary>
        /// <param name="TeacherRecords">多筆教師記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHTeacherRecord record = new JHTeacherRecord();
        ///         record.Name = (new System.Random()).NextDouble().ToString();
        ///         List&lt;JHTeacherRecord&gt; records = new List&lt;JHTeacherRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHTeacher.Insert(records)
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHTeacherRecord> TeacherRecords)
        {
            List<K12.Data.TeacherRecord> Teachers = new List<K12.Data.TeacherRecord>();

            foreach (JHTeacherRecord TeacherRecord in TeacherRecords)
                Teachers.Add(TeacherRecord);

            return K12.Data.Teacher.Insert(Teachers);
        }

        /// <summary>
        /// 更新單筆教師記錄
        /// </summary>
        /// <param name="TeacherRecord">教師記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHTeacherRecord record = JHTeacher.SelectByID(TeacherID);
        ///     record.Name = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHTeacher.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHTeacherRecord TeacherRecord)
        {
            return K12.Data.Teacher.Update(TeacherRecord);
        }

        /// <summary>
        /// 更新多筆教師記錄
        /// </summary>
        /// <param name="TeacherRecords">多筆教師記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHTeacherRecord record = JHTeacher.SelectByID(CourseID);
        ///     record.Name = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHTeacherRecord&gt; records = new List&lt;JHTeacherRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHTeacher.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHTeacherRecord> TeacherRecords)
        {
            List<K12.Data.TeacherRecord> Teachers = new List<K12.Data.TeacherRecord>();

            foreach (JHTeacherRecord TeacherRecord in TeacherRecords)
                Teachers.Add(TeacherRecord);

            return K12.Data.Teacher.Update(Teachers);
        }

        /// <summary>
        /// 刪除多筆教師記錄
        /// </summary>
        /// <param name="TeacherRecords">多筆教師記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHTeacherRecord&gt; records = JHTeacher.SelectByIDs(CourseIDs);
        ///       int DeleteCount = JHTeacher.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHTeacherRecord> TeacherRecords)
        {
            List<K12.Data.TeacherRecord> Teachers = new List<K12.Data.TeacherRecord>();

            foreach (JHTeacherRecord TeacherRecord in TeacherRecords)
                Teachers.Add(TeacherRecord);

            return K12.Data.Teacher.Delete(Teachers);
        }

        /// <summary>
        /// 刪除單筆教師記錄
        /// </summary>
        /// <param name="TeacherRecord">教師記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHTeacherRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       JHTeacherRecord record = JHTeacher.SelectByID(TeacherID);
        ///       int DeleteCount = JHTeacher.Delete(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHTeacherRecord TeacherRecord)
        {
            return K12.Data.Teacher.Delete(TeacherRecord);
        }

        /// <summary>
        /// 刪除單筆教師記錄
        /// </summary>
        /// <param name="TeacherID">教師記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHTeacher.Delete(TeacherID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string TeacherID)
        {
            return K12.Data.Teacher.Delete(TeacherID);
        }

        /// <summary>
        /// 刪除多筆教師記錄
        /// </summary>
        /// <param name="TeacherIDs">多筆教師記錄編琥</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHTeacher.Delete(TeacherIDs);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(IEnumerable<string> TeacherIDs)
        {
            return K12.Data.Teacher.Delete(TeacherIDs);
        }
    }
}