using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學期德行評量類別，提供方法用來取得、新增、修改及刪除學期德行評量資訊
    /// </summary>
    public class JHMoralScore : K12.Data.MoralScore
    {
        /// <summary>
        /// 取得所有學期德行評量列表。
        /// </summary>
        /// <returns>List&lt;JHMoralScoreRecord&gt;，代表多筆學期德行評量記錄物件。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHMoralScoreRecord&gt; records = JHMoralScore.SelectAll();
        ///     </code>
        /// </example>
        public static new List<JHMoralScoreRecord> SelectAll()
        {
            return Select(null,null,null,null);
        }

        /// <summary>
        /// 取得德行評量列表
        /// </summary>
        /// <param name="IDs">德行評量記錄物件編號列表。</param>
        /// <param name="StudentIDs">學生編號列表。</param>
        /// <param name="SchoolYear">學年度。</param>
        /// <param name="Semester">學期。</param>
        /// <returns>List&lt;MoralScoreRecord&gt;，代表多筆學期德行評量記錄物件。</returns>
        public static new List<JHMoralScoreRecord> Select(IEnumerable<string> IDs, IEnumerable<string> StudentIDs, int? SchoolYear, int? Semester)
        {
            return K12.Data.MoralScore.Select<JHMoralScoreRecord>(IDs, StudentIDs, SchoolYear, Semester);
        }

        /// <summary>
        /// 取得德行評量列表 
        /// </summary>
        /// <param name="IDs">德行評量記錄物件編號列表。</param>
        /// <param name="StudentIDs">學生編號列表。</param>
        /// <param name="SchoolYear">學年度。</param>
        /// <param name="Semester">學期。</param>
        /// <param name="SchoolYearSemesters">學年度學期列表。</param>
        /// <returns>List&lt;JHMoralScoreRecord&gt;，代表多筆學期德行評量記錄物件。</returns>
        public static new List<JHMoralScoreRecord> Select(IEnumerable<string> IDs, IEnumerable<string> StudentIDs, int? SchoolYear, int? Semester, IEnumerable<SchoolYearSemester> SchoolYearSemesters)
        {
            return Select<JHMoralScoreRecord>(IDs, StudentIDs, SchoolYear, Semester, SchoolYearSemesters);
        }

        /// <summary>
        /// 根據學生編號、學年度及學期取得學期德行評量列表。
        /// </summary>
        /// <param name="StudentID">學生編號</param>
        /// <param name="SchoolYear">學年度</param>
        /// <param name="Semester">學期</param>
        /// <returns>List&lt;JHMoralScoreRecord&gt;，代表多筆學期德行評量記錄物件。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHMoralScoreRecord&gt; records = JHMoralScore.SelectBySchoolYearAndSemester(StudentID,SchoolYear,Semester);
        /// </example>
        public static new JHMoralScoreRecord SelectBySchoolYearAndSemester(string StudentID, int SchoolYear, int Semester)
        {
            List<string> StudentIDs = new List<string>() { StudentID };

            List<JHMoralScoreRecord> records = Select(null,StudentIDs, SchoolYear, Semester);

            if (records.Count>0)
                return records[0];
            else 
                return null;
        }

        /// <summary>
        /// 根據多筆學生編號取得學期德行評量列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHMoralScoreRecord&gt;，代表多筆學期德行評量記錄物件。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHMoralScoreRecord&gt; records = JHMoralScore.SelectByStudentIDs(StudentIDs);
        /// </example>
        public static new List<JHMoralScoreRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return Select(null,StudentIDs,null,null);
        }

        /// <summary>
        /// 新增單筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreRecord">學期德行評量記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        public static new string Insert(JHMoralScoreRecord MoralScoreRecord)
        {
            return K12.Data.MoralScore.Insert(MoralScoreRecord);
        }

        /// <summary>
        /// 新增多筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreRecords">多筆學期德行評量記錄物件</param> 
        /// <returns>List&lt;string&gt，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static List<string> Insert(IEnumerable<JHMoralScoreRecord> MoralScoreRecords)
        {
            return K12.Data.MoralScore.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.MoralScoreRecord, JHMoralScoreRecord>(MoralScoreRecords));
        }

        /// <summary>
        /// 更新單筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreRecord">學期德行評量記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(JHMoralScoreRecord MoralScoreRecord)
        {
            return K12.Data.MoralScore.Update(MoralScoreRecord);
        }

        /// <summary>
        /// 更新多筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreRecords">多筆學期德行評量記錄</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(IEnumerable<JHMoralScoreRecord> MoralScoreRecords)
        {
            return K12.Data.MoralScore.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.MoralScoreRecord, JHMoralScoreRecord>(MoralScoreRecords));
        }

        /// <summary>
        /// 刪除單筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreRecord">學期德行評量記錄物件</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(JHMoralScoreRecord MoralScoreRecord)
        {
            return K12.Data.MoralScore.Delete(MoralScoreRecord);
        }

        /// <summary>
        /// 刪除單筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreID">學期德行評量記錄編號</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(string MoralScoreID)
        {
            return K12.Data.MoralScore.Delete(MoralScoreID);
        }

        /// <summary>
        /// 刪除多筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreRecords">多筆學期德行評量記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHMoralScoreRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(IEnumerable<JHMoralScoreRecord> MoralScoreRecords)
        {
            return K12.Data.MoralScore.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.MoralScoreRecord, JHMoralScoreRecord>(MoralScoreRecords));
        }

        /// <summary>
        /// 刪除多筆學期德行評量記錄
        /// </summary>
        /// <param name="MoralScoreIDs">多筆學期德行評量記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(IEnumerable<string> MoralScoreIDs)
        {
            return K12.Data.MoralScore.Delete(MoralScoreIDs);
        }
    }
}
