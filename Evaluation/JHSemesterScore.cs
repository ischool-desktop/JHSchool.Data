using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生學期成績類別，提供方法用來取得、新增、修改及刪除學生學期成績資訊
    /// </summary>
    public class JHSemesterScore : K12.Data.SemesterScore
    {
        /// <summary>
        /// 取得所有科目成績
        /// </summary>
        /// <returns></returns>
        [SelectMethod("JHSchool.JHSemesterScore.SelectAllSubjectScore", "成績.科目成績")]
        public static new List<SubjectScore> SelectAllSubjectScore()
        {
            List<SubjectScore> Subjects = new List<SubjectScore>();

            foreach (SemesterScoreRecord Record in SelectAll())
                foreach (SubjectScore Subject in Record.Subjects.Values)
                    Subjects.Add(Subject);
            return Subjects;
        }

        /// <summary>
        /// 取得所有領域成績
        /// </summary>
        /// <returns></returns>
        [SelectMethod("JHSchool.JHSemesterScore.SelectAllDomainScore", "成績.領域成績")]
        public static List<DomainScore> SelectAllDomainScore()
        {
            List<DomainScore> Domains = new List<DomainScore>();

            foreach (JHSemesterScoreRecord Record in SelectAll())
                foreach (DomainScore Subject in Record.Domains.Values)
                    Domains.Add(Subject);
            return Domains;
        }

        /// <summary>
        /// 取得所有學生學期成績記錄物件。
        /// </summary>
        /// <returns>List&lt;JHSemesterScoreRecord&gt;</returns>
        public static new List<JHSemesterScoreRecord> SelectAll()
        {
            return K12.Data.SemesterScore.SelectAll<JHSemesterScoreRecord>();
        }

        /// <summary>
        /// 根據學生編號、學年度及學期取得學生學期成績。
        /// </summary>
        /// <param name="StudentID">學生編號</param>
        /// <param name="SchoolYear">學年度</param>
        /// <param name="Semester">學期</param>
        /// <returns>JHSemesterScoreRecord，代表學生學期成績記錄物件。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     JHSemesterScoreRecord record = JHSemesterScore.SelectBySchoolYearAndSemester(StudentID,SchoolYear,Semester);
        /// </example>
        public static JHSemesterScoreRecord SelectBySchoolYearAndSemester(string StudentID, int SchoolYear, int Semester)
        {
            return K12.Data.SemesterScore.SelectBySchoolYearAndSemester<JHSemesterScoreRecord>(StudentID, SchoolYear, Semester);
        }


        /// <summary>
        /// 根據多筆學生編號、學年度、學期取得學生學期成績列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="SchoolYear">學年度，傳入null代表取得所有學年度資料。</param>
        /// <param name="Semester">學期，傳入null代表取得所有學期資料。</param>
        /// <returns>List&lt;JHSemesterScoreRecord&gt;，代表多筆學生學期成績記錄物件。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSemesterScoreRecord&gt; records = JHSemesterScore.SelectBySchoolYearAndSemester(StudentIDs,SchoolYear,Semester);
        /// </example>
        public static List<JHSemesterScoreRecord> SelectBySchoolYearAndSemester(IEnumerable<string> StudentIDs, int? SchoolYear, int? Semester)
        {
            return K12.Data.SemesterScore.SelectBySchoolYearAndSemester<JHSemesterScoreRecord>(StudentIDs, SchoolYear, Semester);
        }


        /// <summary>
        /// 根據多筆學生編號取得學生學期成績列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHSemesterScoreRecord&gt;，代表多筆學生學期成績記錄物件。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSemesterScoreRecord&gt; records = JHSemesterScore.SelectByStudentIDs(StudentIDs);
        /// </example>
        public static List<JHSemesterScoreRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.SemesterScore.SelectByStudentIDs<JHSemesterScoreRecord>(StudentIDs);
        }

        /// <summary>
        /// 根據多筆學生記錄物件取得學生學期成績列表。
        /// </summary>
        /// <param name="Students">多筆學生記錄物件</param>
        /// <returns>List&lt;JHSemesterScoreRecord&gt;，代表多筆學生學期成績記錄物件。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSemesterScoreRecord&gt; records = JHSemesterScore.SelectByStudents(Students);
        /// </example>
        public static List<JHSemesterScoreRecord> SelectByStudents(IEnumerable<JHStudentRecord> Students)
        {
            return K12.Data.SemesterScore.SelectByStudents<JHSemesterScoreRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord, JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據學生編號取得學生學期成績列表。
        /// </summary>
        /// <param name="StudentID">學生編號</param>
        /// <returns>List&lt;JHSemesterScoreRecord&gt;，代表多筆學生學期成績記錄物件。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSemesterScoreRecord&gt; records = JHSemesterScore.SelectByStudentID(StudentID);
        /// </example>
        public static List<JHSemesterScoreRecord> SelectByStudentID(string StudentID)
        {
            return K12.Data.SemesterScore.SelectByStudentID<JHSemesterScoreRecord>(StudentID);
        }

        /// <summary>
        /// 根據學生記錄物件取得學生學期成績列表。
        /// </summary>
        /// <param name="Student">學生記錄物件</param>
        /// <returns>List&lt;JHSemesterScoreRecord&gt;，代表多筆學生學期成績記錄物件。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSemesterScoreRecord&gt; records = JHSemesterScore.SelectByStudent(Student);
        /// </example>
        public static List<JHSemesterScoreRecord> SelectByStudent(JHStudentRecord Student)
        {
            return K12.Data.SemesterScore.SelectByStudent<JHSemesterScoreRecord>(Student);
        }


        /// <summary>
        /// 新增單筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreRecord">學生學期成績記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        public static string Insert(JHSemesterScoreRecord SemesterScoreRecord)
        {
            return K12.Data.SemesterScore.Insert(SemesterScoreRecord);
        }

        /// <summary>
        /// 新增多筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreRecords">多筆學生學期成績記錄物件</param> 
        /// <returns>List&lt;string&gt，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static List<string> Insert(IEnumerable<JHSemesterScoreRecord> SemesterScoreRecords)
        {
            return K12.Data.SemesterScore.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.SemesterScoreRecord, JHSemesterScoreRecord>(SemesterScoreRecords));
        }

        /// <summary>
        /// 更新單筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreRecord">學生學期成績記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(JHSemesterScoreRecord SemesterScoreRecord)
        {
            return K12.Data.SemesterScore.Update(SemesterScoreRecord);
        }

        /// <summary>
        /// 更新多筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreRecords">多筆學生學期成績記錄</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(IEnumerable<JHSemesterScoreRecord> SemesterScoreRecords)
        {
            return K12.Data.SemesterScore.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.SemesterScoreRecord, JHSemesterScoreRecord>(SemesterScoreRecords));
        }

        /// <summary>
        /// 刪除單筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreRecord">學生學期成績記錄物件</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(JHSemesterScoreRecord SemesterScoreRecord)
        {
            return K12.Data.SemesterScore.Delete(SemesterScoreRecord);
        }

        /// <summary>
        /// 刪除單筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreID">學生學期成績編號</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(string SemesterScoreRecordID)
        {
            return K12.Data.SemesterScore.Delete(SemesterScoreRecordID);
        }


        /// <summary>
        /// 刪除多筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreRecords">多筆學生學期成績記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHSemesterScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(IEnumerable<JHSemesterScoreRecord> SemesterScoreRecords)
        {
            return K12.Data.SemesterScore.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.SemesterScoreRecord, JHSemesterScoreRecord>(SemesterScoreRecords));
        }

        /// <summary>
        /// 刪除多筆學生學期成績記錄
        /// </summary>
        /// <param name="SemesterScoreIDs">多筆學生學期成績編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(IEnumerable<string> SemesterScoreRecordIDs)
        {
            return K12.Data.SemesterScore.Delete(SemesterScoreRecordIDs);
        }
    }
}