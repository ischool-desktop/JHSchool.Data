using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生修課類別，提供方法用來取得、新增、修改及刪除學生修課資訊
    /// </summary>
    public class JHSCAttend : K12.Data.SCAttend
    {
        /// <summary>
        /// 取得所有學生修課列表。
        /// </summary>
        /// <returns>List&lt;JHSCAttendRecord&gt;，代表多筆學生修課記錄物件。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;SCAttendRecord&gt; records = JHSCAttend.SelectAll();
        /// </example>
        [SelectMethod("JHSchool.JHSCAttend.SelectAll", "成績.學生修課")]
        public static new List<JHSCAttendRecord> SelectAll()
        {
            return SelectAll<JHSCAttendRecord>();
        }

        /// <summary>
        /// 根據條件取得學生修課列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="CourseIDs">多筆課程編號</param>
        /// <param name="SCAttendIDs">多筆學生修課列表</param>
        /// <param name="SchoolYear">學年度</param>
        /// <param name="Semester">學期</param>
        /// <returns>List&lt;JHSCAttendRecord&gt;，代表多筆學生修課記錄物件。</returns>
        public new static List<JHSCAttendRecord> Select(IEnumerable<string> StudentIDs, IEnumerable<string> CourseIDs, IEnumerable<string> SCAttendIDs, string SchoolYear, string Semester)
        {
            return Select<JHSCAttendRecord>(StudentIDs, CourseIDs, SCAttendIDs, SchoolYear, Semester);
        }

        /// <summary>
        /// 根據單筆學生修課編號取得學生修課列表。
        /// </summary>
        /// <param name="SCAttendID">單筆學生修課編號</param>
        /// <returns>JHSCAttendRecord，代表單筆學生修課記錄物件。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     JHSCAttendRecord record = JHSCAttend.SelectByID(SCAttendID);
        /// </example>
        public static new JHSCAttendRecord SelectByID(string SCAttendID)
        {
            return SelectByID<JHSCAttendRecord>(SCAttendID);
        }

        /// <summary>
        /// 根據多筆學生修課編號取得學生修課列表。
        /// </summary>
        /// <param name="SCAttendIDs">多筆學生修課編號</param>
        /// <returns>List&lt;JHSCAttendRecord&gt;，代表多筆學生修課記錄物件。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCAttendRecord&gt; records = JHSCAttend.SelectByIDs(SCAttendIDs);
        /// </example>
        public static new List<JHSCAttendRecord> SelectByIDs(IEnumerable<string> SCAttendIDs)
        {
            return SelectByIDs<JHSCAttendRecord>(SCAttendIDs);
        }

        /// <summary>
        /// 根據多筆學生編號及多筆課程編號取得學生修課列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="CourseIDs">多筆課程編號</param>
        /// <returns>List&lt;SCAttendRecord&gt;，代表多筆學生修課記錄物件。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCAttendRecord&gt; records = JHSCAttend.GetByStudentIDsAndCourseIDs(StudentIDs,CourseIDs);
        /// </example>
        public static List<JHSCAttendRecord> SelectByStudentIDAndCourseID(IEnumerable<string> StudentIDs, IEnumerable<string> CourseIDs)
        {
            return SelectByStudentIDAndCourseID<JHSCAttendRecord>(StudentIDs, CourseIDs);
        }


        /// <summary>
        /// 根據單筆學生編號取得學生修課列表。
        /// </summary>
        /// <param name="StudentID">單筆學生編號</param>
        /// <returns>List&lt;JHSCAttendRecord&gt;，代表多筆學生修課記錄物件。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCAttendRecord&gt; records = JHSCAttend.SelectByStudentID(StudentID);
        /// </example>
        public static List<JHSCAttendRecord> SelectByStudentID(string StudentID)
        {
            return K12.Data.SCAttend.SelectByStudentID<JHSCAttendRecord>(StudentID);
        }

        /// <summary>
        /// 根據多筆學生編號取得學生修課列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHSCAttendRecord&gt;，代表多筆學生修課記錄物件。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHSCAttendRecord&gt; records = JHSCAttend.SelectByStudentIDs(StudentIDs);
        /// </example>
        public static List<JHSCAttendRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.SCAttend.SelectByStudentIDs<JHSCAttendRecord>(StudentIDs);
        }

        public static JHSCAttendRecord SelectByCourseID(string CourseID)
        {
            if (string.IsNullOrEmpty(CourseID))
                return null;

            List<string> IDs = new List<string>();

            IDs.Add(CourseID);

            List<JHSCAttendRecord> records = K12.Data.SCAttend.SelectByCourseIDs<JHSCAttendRecord>(IDs);

            if (records.Count > 0)
                return records[0];
            else
                return null;
        }

        public static List<JHSCAttendRecord> SelectByCourseIDs(IEnumerable<string> CourseIDs)
        {
            return K12.Data.SCAttend.SelectByCourseIDs<JHSCAttendRecord>(CourseIDs);
        }

        /// <summary>
        /// 新增單筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendRecord">學生修課記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        public static string Insert(JHSCAttendRecord SCAttendRecord)
        {
            return K12.Data.SCAttend.Insert(SCAttendRecord);
        }

        /// <summary>
        /// 新增多筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendRecords">多筆學生修課記錄物件</param> 
        /// <returns>List&lt;string&gt，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static List<string> Insert(IEnumerable<JHSCAttendRecord> SCAttendRecords)
        {
            return K12.Data.SCAttend.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.SCAttendRecord,JHSCAttendRecord>(SCAttendRecords));
        }

        /// <summary>
        /// 更新單筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendRecord">學生修課記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(JHSCAttendRecord SCAttendRecord)
        {
            return K12.Data.SCAttend.Update(SCAttendRecord);
        }

        /// <summary>
        /// 更新多筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendRecords">多筆學生修課記錄</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(IEnumerable<JHSCAttendRecord> SCAttendRecords)
        {
            return K12.Data.SCAttend.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.SCAttendRecord, JHSCAttendRecord>(SCAttendRecords));
        }

        /// <summary>
        /// 刪除單筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendRecord">學生修課記錄物件</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHSCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(JHSCAttendRecord SCAttendRecord)
        {
            return K12.Data.SCAttend.Delete(SCAttendRecord);
        }

        /// <summary>
        /// 刪除單筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendID">學生修課編號</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(string SCAttendID)
        {
            return K12.Data.SCAttend.Delete(SCAttendID);
        }

        /// <summary>
        /// 刪除多筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendRecords">多筆學生修課記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="SCAttendRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(IEnumerable<JHSCAttendRecord> SCAttendRecords)
        {
            return K12.Data.SCAttend.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.SCAttendRecord, JHSCAttendRecord>(SCAttendRecords));
        }


        /// <summary>
        /// 刪除多筆學生修課記錄
        /// </summary>
        /// <param name="SCAttendIDs">多筆學生修課編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(IEnumerable<string> SCAttendIDs)
        {
            return K12.Data.SCAttend.Delete(SCAttendIDs);
        }
    }
}