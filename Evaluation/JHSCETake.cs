using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生期中成績類別，提供方法用來取得、新增、修改及刪除學生期中成績資訊
    /// </summary>
    public class JHSCETake : K12.Data.SCETake
    {
        /// <summary>
        /// 取得所有學生期中成績列表。
        /// </summary>
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHSCETakeRecord&gt; records = JHSCETake.SelectAll();
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHSCETake.SelectAll", "成績.評量成績")]
        public static new List<JHSCETakeRecord> SelectAll()
        {
            return K12.Data.SCETake.SelectAll<JHSCETakeRecord>();
        }

        public static List<JHSCETakeRecord> Select(IEnumerable<string> CourseIDs, IEnumerable<string> StudentIDs, IEnumerable<string> ExamIDs, IEnumerable<string> SCETakeIDs, IEnumerable<string> SCAttendIDs)
        {
            return Select<JHSCETakeRecord>(CourseIDs, StudentIDs, ExamIDs, SCETakeIDs, SCAttendIDs);
        }

        /// <summary>
        /// 根據多筆學生期中成績編號取得學生期中成績列表。
        /// </summary>
        /// <param name="SCETakeIDs">多筆學生期中成績編號</param>
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCETakeRecord&gt; records = JHSCETake.SelectByIDs(SCETakeIDs);
        /// </example>
        public static new List<JHSCETakeRecord> SelectByIDs(IEnumerable<string> SCETakeIDs)
        {
            return K12.Data.SCETake.SelectByIDs<JHSCETakeRecord>(SCETakeIDs);
        }

        /// <summary>
        /// 根據課程編號及考試項目編號取得學生期中成績列表。
        /// </summary>
        /// <param name="CourseID">課程編號</param> 
        /// <param name="ExamID">考試項目編號</param>
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCETakeRecord&gt; records = JHSCETake.SelectByCourseAndExam(CourseID,ExamID);
        /// </example>
        public static new List<JHSCETakeRecord> SelectByCourseAndExam(string CourseID, string ExamID)
        {
            return K12.Data.SCETake.SelectByCourseAndExam<JHSCETakeRecord>(CourseID, ExamID);
        }

        /// <summary>
        /// 根據多筆課程編號及單筆考試項目編號取得學生期中成績列表。
        /// </summary>
        /// <param name="CourseIDs">多筆課程編號</param>
        /// <param name="ExamID">單筆考試項目編號</param>
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCETakeRecord&gt; records = JHSCETake.SelectByCourseAndExam(CourseIDs,ExamID);
        /// </example>
        public static new List<JHSCETakeRecord> SelectByCourseAndExam(List<string> CourseIDs, string ExamID)
        {
            return K12.Data.SCETake.SelectByCourseAndExam<JHSCETakeRecord>(CourseIDs, ExamID);
        }


        /// <summary>
        /// 根據學生編號及課程編號取得學生期中成績列表。
        /// </summary>
        /// <param name="CourseID">課程編號</param> 
        /// <param name="StudentID">學生編號</param>
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;SCETakeRecord&gt; records = JHSCETake.SelectByStudentAndCourse(StudentID,CourseID);
        /// </example>
        public static new List<JHSCETakeRecord> SelectByStudentAndCourse(string StudentID, string CourseID)
        {
            return K12.Data.SCETake.SelectByStudentAndCourse<JHSCETakeRecord>(StudentID, CourseID);
        }

        /// <summary>
        /// 根據單筆學生編號取得學生期中成績列表。
        /// </summary>
        /// <param name="StudentID">單筆學生編號</param>
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCETakeRecord&gt; records = JHSCETake.SelectByStudentID(StudentID);
        /// </example>
        public static List<JHSCETakeRecord> SelectByStudentID(string StudentID)
        {
            return K12.Data.SCETake.SelectByStudentID<JHSCETakeRecord>(StudentID);
        }


        /// <summary>
        /// 根據多筆學生編號取得學生期中成績列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCETakeRecord&gt; records = JHSCETake.SelectByStudentID(StudentIDs);
        /// </example>
        public static List<JHSCETakeRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return SelectByStudentIDs<JHSCETakeRecord>(StudentIDs);
        }

        /// <summary>
        /// 根據多筆學生編號及多筆課程編號取得學生期中成績列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="CourseIDs">多筆課程編號</param> 
        /// <returns>List&lt;JHSCETakeRecord&gt;，代表多筆學生期中成績記錄物件。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCETakeRecord&gt; records = JHSCETake.SelectByStudentAndCourse(StudentIDs,CourseIDs);
        /// </example>
        public static List<JHSCETakeRecord> SelectByStudentAndCourse(IEnumerable<string> StudentIDs, IEnumerable<string> CourseIDs)
        {
            return K12.Data.SCETake.SelectByStudentAndCourse<JHSCETakeRecord>(StudentIDs, CourseIDs);
        }

        /// <summary>
        /// 新增單筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeRecord">學生期中成績記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHSCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        /// </example>
        public static string Insert(JHSCETakeRecord SCETakeRecord)
        {
            return K12.Data.SCETake.Insert(SCETakeRecord);
        }

        /// <summary>
        /// 新增多筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeRecords">多筆學生期中成績記錄物件</param> 
        /// <returns>List&lt;string&gt，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="SCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static List<string> Insert(IEnumerable<JHSCETakeRecord> SCETakeRecords)
        {
            return K12.Data.SCETake.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.SCETakeRecord,JHSCETakeRecord>(SCETakeRecords));
        }

        /// <summary>
        /// 更新單筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeRecord">學生期中成績記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="SCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(JHSCETakeRecord SCETakeRecord)
        {
            return K12.Data.SCETake.Update(SCETakeRecord);
        }

        /// <summary>
        /// 更新多筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeRecords">多筆學生期中成績記錄</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="SCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(IEnumerable<JHSCETakeRecord> SCETakeRecords)
        {
            return K12.Data.SCETake.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.SCETakeRecord, JHSCETakeRecord>(SCETakeRecords));
        }

        /// <summary>
        /// 刪除單筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeRecord">學生期中成績記錄物件</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="SCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(JHSCETakeRecord SCETakeRecord)
        {
            return K12.Data.SCETake.Delete(SCETakeRecord);
        }

        /// <summary>
        /// 刪除單筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeID">學生期中成績編號</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(string SCETakeID)
        {
            return K12.Data.SCETake.Delete(SCETakeID);
        }

        /// <summary>
        /// 刪除多筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeRecords">多筆學生期中成績記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="SCETakeRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(IEnumerable<JHSCETakeRecord> SCETakeRecords)
        {
            return K12.Data.SCETake.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.SCETakeRecord, JHSCETakeRecord>(SCETakeRecords));
        }

        /// <summary>
        /// 刪除多筆學生期中成績記錄
        /// </summary>
        /// <param name="SCETakeIDs">多筆學生期中成績編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(IEnumerable<string> SCETakeIDs)
        {
            return K12.Data.SCETake.Delete(SCETakeIDs);
        }
    }
}
