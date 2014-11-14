using System;
using System.Collections.Generic;
using K12.Data;


namespace JHSchool.Data 
{
    /// <summary>
    /// 學生類別，提供方法用來取得、新增、修改及刪除學生資訊
    /// </summary>
    public class JHStudent : K12.Data.Student
    {
        /// <summary>
        /// 取得所有學生記錄列表。
        /// </summary>
        /// <returns>List&lt;JHStudentRecord&gt;，代表多筆學生記錄物件。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHStudentRecord&gt; records = JHStudent.SelectAll();
        ///     
        ///     foreach(JHStudentRecord record in records)
        ///         System.Console.Writeln(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 請先using K12.Data;
        /// </remarks>
        [SelectMethod("JHSchool.JHStudent.SelectAll", "學籍.學生")]
        public static new List<JHStudentRecord> SelectAll()
        {
            return K12.Data.Student.SelectAll<JHStudentRecord>();
        }

        /// <summary>
        /// 根據班級記錄物件取得學生記錄編號列表。
        /// </summary>
        /// <param name="ClassRec">班級記錄物件</param>
        /// <returns>List&lt;JHStudentRecord&gt;，代表多筆學生記錄物件。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHStudentRecord&gt; records = JHStudent.SelectByClass(ClassRec);
        ///     
        ///     foreach(JHStudentRecord record in records)
        ///         System.Console.Writeln(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 請先using K12.Data;
        /// </remarks>
        public static List<JHStudentRecord> SelectByClass(JHClassRecord ClassRec)
        {
            return SelectByClassID<JHStudentRecord>(ClassRec.ID);
        }

        /// <summary>
        /// 根據班級編號取得學生記錄編號列表。
        /// </summary>
        /// <param name="ClassID">班級編號</param>
        /// <returns>List&lt;JHStudentRecord&gt;，代表多筆學生記錄物件。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHStudentRecord&gt; records = JHStudent.SelectByClassID(ClassID);
        ///     
        ///     foreach(JHStudentRecord record in records)
        ///         System.Console.Writeln(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 請先using K12.Data;
        /// </remarks>
        public static new List<JHStudentRecord> SelectByClassID(string ClassID)
        {
            return K12.Data.Student.SelectByClassID<JHStudentRecord>(ClassID);
        }

        /// <summary>
        /// 根據多筆班級記錄物件取得學生記錄編號列表。
        /// </summary>
        /// <param name="ClassRecs">多筆班級記錄物件</param>
        /// <returns>List&lt;JHStudentRecord&gt;，代表多筆學生記錄物件。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHStudentRecord&gt; records = JHStudent.SelectByClasses(ClassRecs);
        ///     
        ///     foreach(JHStudentRecord record in records)
        ///         System.Console.Writeln(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 請先using K12.Data;
        /// </remarks>
        public static List<JHStudentRecord> SelectByClasses(IEnumerable<JHClassRecord> ClassRecs)
        {
            List<string> IDs = new List<string>();

            foreach (JHClassRecord ClassRec in ClassRecs)
                IDs.Add(ClassRec.ID);

            return SelectByClassIDs<JHStudentRecord>(IDs);
        }


        /// <summary>
        /// 根據多筆班級編號取得學生記錄編號列表。
        /// </summary>
        /// <param name="ClassIDs">多筆班級編號</param>
        /// <returns>List&lt;JHStudentRecord&gt;，代表多筆學生記錄物件。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHHStudentRecord&gt; records = JHStudent.SelectByClassIDs(ClassIDs);
        ///     
        ///     foreach(JHStudentRecord record in records)
        ///         System.Console.Writeln(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 請先using K12.Data;
        /// </remarks>
        public static  new List<JHStudentRecord> SelectByClassIDs(IEnumerable<string> ClassIDs)
        {
            return K12.Data.Student.SelectByClassIDs<JHStudentRecord>(ClassIDs);
        }

        /// <summary>
        /// 根據單筆學生編號取得學生記錄。
        /// </summary>
        /// <param name="StudentID">學生編號</param>
        /// <returns>JHStudentRecord，代表學生記錄物件</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHStudentRecord record = JHStudent.SelectByID(StudentID);
        ///     
        ///     if (record != null)
        ///         System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>若是StudentID不則在則會傳回null</remarks>
        public static new JHStudentRecord SelectByID(string StudentID)
        {
            return K12.Data.Student.SelectByID<JHStudentRecord>(StudentID);
        }

        /// <summary>
        /// 根據多筆學生編號取得學生記錄列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHStudentRecord&gt;，代表多筆學生記錄物件。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHStudentRecord&gt; records = JHStudent.SelectByIDs(CourseIDs);
        ///     
        ///     foreach(JHStudentRecord record in records)
        ///         Console.WrlteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆ID，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static new List<JHStudentRecord> SelectByIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.Student.SelectByIDs<JHStudentRecord>(StudentIDs);
        }

        /// <summary>
        /// 新增單筆學生記錄
        /// </summary>
        /// <param name="StudentRecord">學生記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHStudentRecord newrecord = new JHStudentRecord();
        ///         newrecord.Name = (new System.Random()).NextDouble().ToString();
        ///         newrecord.Gender = "男";
        ///         strng NewID = JHStudent.Insert(newrecord)
        ///         StudentRecord record = JHStudent.SelectByID(NewID);
        ///         System.Console.Writeln(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為課程名稱（Name）。
        /// </remarks>
        public static string Insert(JHStudentRecord StudentRecord)
        {
            return K12.Data.Student.Insert(StudentRecord);
        }

        /// <summary>
        /// 新增多筆學生記錄
        /// </summary>
        /// <param name="StudentRecords">多筆班級記錄物件</param>
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHStudentRecord record = new JHStudentRecord();
        ///         record.Name = (new System.Random()).NextDouble().ToString();
        ///         List&lt;JHStudentRecord&gt; records = new List&lt;JHStudentRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHStudent.Insert(records)
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHStudentRecord> StudentRecords)
        {
            List<K12.Data.StudentRecord> Students = new List<K12.Data.StudentRecord>();

            foreach (JHStudentRecord StudentRecord in StudentRecords)
                Students.Add(StudentRecord);

            return K12.Data.Student.Insert(Students);
        }

        /// <summary>
        /// 更新單筆學生記錄
        /// </summary>
        /// <param name="StudentRecord">學生記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHStudentRecord record = JHStudent.SelectByID(StudentID);
        ///     record.Name = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHStudent.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHStudentRecord StudentRecord)
        {
            return K12.Data.Student.Update(StudentRecord);
        }

        /// <summary>
        /// 更新多筆學生記錄
        /// </summary>
        /// <param name="StudentRecords">多筆學生記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHStudentRecord record = JHStudent.SelectByID(StudentID);
        ///     record.Name = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHStudentRecord&gt; records = new List&lt;JHStudentRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHStudent.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHStudentRecord> StudentRecords)
        {
            List<K12.Data.StudentRecord> Students = new List<K12.Data.StudentRecord>();

            foreach (JHStudentRecord StudentRecord in StudentRecords)
                Students.Add(StudentRecord);

            return K12.Data.Student.Update(Students);
        }

        /// <summary>
        /// 刪除多筆學生記錄
        /// </summary>
        /// <param name="StudentRecords">多筆學生記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHStudentRecord&gt; records = JHStudent.SelectByIDs(StudentIDs);
        ///       int DeleteCount = Student.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHStudentRecord> StudentRecords)
        {
            List<K12.Data.StudentRecord> Students = new List<K12.Data.StudentRecord>();

            foreach (JHStudentRecord StudentRecord in StudentRecords)
                Students.Add(StudentRecord);

            return K12.Data.Student.Delete(Students);
        }

        /// <summary>
        /// 刪除單筆學生記錄
        /// </summary>
        /// <param name="StudentRecord">學生記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       JHStudentRecord record = JHStudent.SelectByID(StudentID);
        ///       int DeleteCount = JHStudent.Delete(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHStudentRecord StudentRecord)
        {
            return K12.Data.Student.Delete(StudentRecord);
        }

        /// <summary>
        /// 刪除單筆學生記錄
        /// </summary>
        /// <param name="StudentID">學生記錄編號</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHStudent.Delete(StudentID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string StudentID)
        {
            return K12.Data.Student.Delete(StudentID);
        }

        /// <summary>
        /// 刪除多筆學生標籤記錄
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHStudent.Delete(StudentIDs);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(IEnumerable<string> StudentIDs)
        {
            return K12.Data.Student.Delete(StudentIDs);
        }
    }
}