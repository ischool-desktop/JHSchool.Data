using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生前級畢業資訊類別，提供方法用來取得及修改學生前級畢業資訊。
    /// </summary>
    public class JHBeforeEnrollment:K12.Data.BeforeEnrollment
    {
        /// <summary>
        /// 取得所有學生前級畢業資訊物件列表。
        /// </summary>
        /// <returns>List&lt;JHBeforeEnrollmentRecord&gt;，代表多筆學生前級畢業資訊物件。</returns>
        /// <seealso cref="JHBeforeEnrollmentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHBeforeEnrollmentRecord&gt; records = JHBeforeEnrollment.SelectAll();
        ///     
        ///     foreach(JHBeforeEnrollmentRecord record in records)
        ///         Console.WrlteLine(record.Reason);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHBeforeEnrollment.SelectAll", "學籍.前級畢業資訊")]
        public new static List<JHBeforeEnrollmentRecord> SelectAll()
        {
            return SelectAll<JHBeforeEnrollmentRecord>();
        }

        /// <summary>
        /// 根據單筆學生記錄物件取得學生前級畢業資訊物件。
        /// </summary>
        /// <param name="Student">學生記錄物件</param>
        /// <returns>JHLeaveInfoRecord，代表學生前級畢業資訊物件。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <seealso cref="JHBeforeEnrollmentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHBeforeEnrollmentRecord record = JHBeforeEnrollment.SelectByStudent(Student);
        ///     
        ///    if (record != null)
        ///        System.Console.WriteLine(record.Memo);
        ///     </code>
        /// </example>
        /// <remarks>若是Student不則在則會傳回null</remarks>
        public static JHBeforeEnrollmentRecord SelectByStudent(JHStudentRecord Student)
        {
            return K12.Data.BeforeEnrollment.SelectByStudent<JHBeforeEnrollmentRecord>(Student);
        }

        /// <summary>
        /// 根據單筆學生記錄編號取得學生前級畢業資訊物件。
        /// </summary>
        /// <param name="StudentID">學生記錄編號</param>
        /// <returns>JHBeforeEnrollmentRecord，代表學生前級畢業資訊物件。</returns>
        /// <seealso cref="JHBeforeEnrollmentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHBeforeEnrollmentRecord record = JHBeforeEnrollment.SelectByStudentID(StudentID);
        ///     
        ///     if (record != null)
        ///        System.Console.WriteLine(record.Reason);
        ///     </code>
        /// </example>
        /// <remarks>若是StudentID不則在則會傳回null</remarks>
        public static new JHBeforeEnrollmentRecord SelectByStudentID(string StudentID)
        {
            return K12.Data.BeforeEnrollment.SelectByStudentID<JHBeforeEnrollmentRecord>(StudentID);
        }

        /// <summary>
        /// 根據多筆學生記錄物件取得學生前級畢業資訊物件列表。
        /// </summary>
        /// <param name="Students">多筆學生記錄物件</param>
        /// <returns>List&lt;JHBeforeEnrollmentRecord&gt;，代表多筆學生前級畢業資訊物件。</returns>
        /// <seealso cref="JHBeforeEnrollmentRecord"/>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHBeforeEnrollmentRecord&gt; records = JHBeforeEnrollment.SelectByStudents(Students);
        ///     
        ///     foreach(JHBeforeEnrollmentRecord record in records)
        ///         Console.WrlteLine(record.Reason);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static List<JHBeforeEnrollmentRecord> SelectByStudents(IEnumerable<JHStudentRecord> Students)
        {
            return K12.Data.BeforeEnrollment.SelectByStudents<JHBeforeEnrollmentRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord, JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據多筆學生記錄編號取得學生前級畢業資訊物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>List&lt;JHBeforeEnrollmentRecord&gt;，代表多筆學生前級畢業資訊物件。</returns>
        /// <seealso cref="JHBeforeEnrollmentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHBeforeEnrollmentRecord&gt; records = JHBeforeEnrollment.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHBeforeEnrollmentRecord record in records)
        ///         Console.WrlteLine(record.Reason);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static new List<JHBeforeEnrollmentRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.BeforeEnrollment.SelectByStudentIDs<JHBeforeEnrollmentRecord>(StudentIDs);
        }

        /// <summary>
        /// 更新單筆學生離校資訊
        /// </summary>
        /// <param name="BeforeEnrollmentRecord">學生前級畢業資訊物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHBeforeEnrollmentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHBeforeEnrollmentRecord record = JHBeforeEnrollment.SelectByStudentID(StudentID);
        ///     record.Reason = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHBeforeEnrollment.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHBeforeEnrollmentRecord BeforeEnrollmentRecord)
        {
            return K12.Data.BeforeEnrollment.Update(BeforeEnrollmentRecord);
        }

        /// <summary>
        /// 更新多筆學生離校資訊
        /// </summary>
        /// <param name="BeforeEnrollmentRecords">多筆學生離校資訊物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHBeforeEnrollmentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHBeforeEnrollmentRecord record = JHBeforeEnrollment.SelectByStudentID(StudentID);
        ///     record.Memo = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHBeforeEnrollment&gt; records = new List&lt;JHBeforeEnrollment&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHBeforeEnrollment.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHBeforeEnrollmentRecord> BeforeEnrollmentRecords)
        {
            return K12.Data.BeforeEnrollment.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.BeforeEnrollmentRecord, JHBeforeEnrollmentRecord>(BeforeEnrollmentRecords));
        }
    }
}