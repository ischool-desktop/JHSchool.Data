﻿using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生懲戒類別，提供方法用來取得、新增、修改及刪除學生懲戒資訊
    /// </summary>
    public class JHDemerit : K12.Data.Demerit
    {
        /// <summary>
        /// 取得所有學生懲戒記錄物件列表。
        /// </summary>
        /// <returns>List&lt;JHDemeritRecord&gt;，代表多筆學生懲戒記錄物件。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectAll();
        ///     
        ///     foreach(JHDemeritRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHDemerit.SelectAll", "學務.懲戒")]
        public static new List<JHDemeritRecord> SelectAll()
        {
            return K12.Data.Demerit.SelectAll<JHDemeritRecord>();
        }

        /// <summary>
        /// 根據條件取得懲戒紀錄列表
        /// </summary>
        /// <param name="StudentIDs">學生編號列表</param>
        /// <param name="StartDate">開始時間</param>
        /// <param name="EndDate">結束時間</param>
        /// <param name="StartRegisterDate">開始登錄時間</param>
        /// <param name="EndRegisterDate">結束登錄時間</param>
        /// <param name="SchoolYears">學年度</param>
        /// <param name="Semesters">學期</param>
        /// <returns>List&lt;JHDemeritRecord&gt;，懲戒紀錄物件列表</returns>
        public static new List<JHDemeritRecord> Select(IEnumerable<string> StudentIDs, DateTime? StartDate, DateTime? EndDate, DateTime? StartRegisterDate, DateTime? EndRegisterDate, IEnumerable<int> SchoolYears, IEnumerable<int> Semesters)
        {
            return Select<JHDemeritRecord>(StudentIDs,StartDate,EndDate,StartRegisterDate,EndRegisterDate,SchoolYears,Semesters);
        }

        /// <summary>
        /// 根據條件取得懲戒紀錄列表
        /// </summary>
        /// <param name="StudentIDs">學生編號列表</param>
        /// <param name="StartDate">發生開始時間</param>
        /// <param name="EndDate">發生結束時間</param>
        /// <param name="StartRegisterDate">開始登錄時間</param>
        /// <param name="EndRegisterDate">結束登錄時間</param>
        /// <param name="SchoolYears">學年度列表</param>
        /// <param name="Semesters">學期列表</param>
        /// <param name="SchoolYearSemesters">學年度學期列表</param>
        /// <returns>List&lt;JHDemeritRecord&gt;，懲戒紀錄物件列表</returns>
        public static new List<JHDemeritRecord> Select(IEnumerable<string> StudentIDs, DateTime? StartDate, DateTime? EndDate, DateTime? StartRegisterDate, DateTime? EndRegisterDate, IEnumerable<int> SchoolYears, IEnumerable<int> Semesters, IEnumerable<SchoolYearSemester> SchoolYearSemesters)
        {
            return Select<JHDemeritRecord>(StudentIDs, StartDate, EndDate, StartRegisterDate, EndRegisterDate, SchoolYears, Semesters, SchoolYearSemesters);
        }

        /// <summary>
        /// 根據條件取得懲戒紀錄列表
        /// </summary>
        /// <typeparam name="T">懲戒紀錄型別，繼承至K12.Data.DemeritRecord</typeparam>
        /// <param name="StudentIDs">學生編號列表</param>
        /// <param name="StartDate">發生開始時間</param>
        /// <param name="EndDate">發生結束時間</param>
        /// <param name="StartRegisterDate">開始登錄時間</param>
        /// <param name="EndRegisterDate">結束登錄時間</param>
        /// <param name="StartClearDate">開始已銷過時間</param>
        /// <param name="EndClearDate">結束已銷過時間</param>
        /// <param name="SchoolYears">學年度列表</param>
        /// <param name="Semesters">學期列表</param>
        /// <param name="SchoolYearSemesters">學年度學期列表</param>
        /// <returns>List&lt;JHDemeritRecord&gt;，懲戒紀錄列表</returns>
        public static new List<JHDemeritRecord> Select(IEnumerable<string> StudentIDs, DateTime? StartDate, DateTime? EndDate, DateTime? StartRegisterDate, DateTime? EndRegisterDate, DateTime? StartClearDate, DateTime? EndClearDate, IEnumerable<int> SchoolYears, IEnumerable<int> Semesters, IEnumerable<SchoolYearSemester> SchoolYearSemesters)
        {
            return Select<JHDemeritRecord>(StudentIDs, StartDate, EndDate, StartRegisterDate, EndRegisterDate, StartClearDate, EndClearDate, SchoolYears, Semesters, SchoolYearSemesters);
        }

        /// <summary>
        /// 根據單筆學生編號、學年度及學期取得學生懲戒記錄物件列表。
        /// </summary>
        /// <param name="StudentID">單筆學生編號</param>
        /// <param name="SchoolYear">學年度，傳入null代表取得所有學年度的資料</param>
        /// <param name="Semester">學期，傳入null代表取得所有學年度的資料</param>
        /// <returns>List&lt;JHDemeritRecord&gt;，代表多筆學生懲戒記錄物件。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectBySchoolYearAndSemester(StudentID,School,Semester);
        ///     
        ///     foreach(JHDemeritRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHDemeritRecord> SelectBySchoolYearAndSemester(string StudentID, int? SchoolYear, int? Semester)
        {
            return K12.Data.Demerit.SelectBySchoolYearAndSemester<JHDemeritRecord>(StudentID, SchoolYear, Semester);
        }

        /// <summary>
        /// 根據多筆學生編號、學年度及學期取得學生懲戒記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="SchoolYear">學年度，傳入null代表取得所有學年度的資料</param>
        /// <param name="Semester">學期，傳入null代表取得所有學年度的資料</param>
        /// <returns>List&lt;DemeritRecord&gt;，代表多筆學生懲戒記錄物件。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectBySchoolYearAndSemester(StudentIDs,School,Semester);
        ///     
        ///     foreach(JHDemeritRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHDemeritRecord> SelectBySchoolYearAndSemester(IEnumerable<string> StudentIDs, int? SchoolYear, int? Semester)
        {
            return K12.Data.Demerit.SelectBySchoolYearAndSemester<JHDemeritRecord>(StudentIDs, SchoolYear, Semester);
        }

        /// <summary>
        /// 根據多筆學生編號取得學生懲戒記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <returns>List&lt;JHDemeritRecord&gt;，代表多筆學生懲戒記錄物件。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHDemeritRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHDemeritRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.Demerit.SelectByStudentIDs<JHDemeritRecord>(StudentIDs);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Obsolete("此方法已不再使用。")] 
        public static List<JHDemeritRecord> SelectRegisterDate(IEnumerable<string> StudentIDs, DateTime? StartRegisterDate, DateTime? EndRegisterDate)
        {
            return K12.Data.Demerit.SelectByRegisterDate<JHDemeritRecord>(StudentIDs, StartRegisterDate, EndRegisterDate);
        }

        /// <summary>
        /// 根據多筆學生編號及登錄日期取得學生懲戒記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="StartRegisterDate">登錄開始日期</param>
        /// <param name="EndRegisterDate">登錄結束日期</param>
        /// <returns>List&lt;JHDemeritRecord&gt;，代表多筆學生懲戒記錄物件。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectByRegisterDate(StudentIDs,StartRegisterDate,EndRegisterDate);
        ///     
        ///     foreach(JHDemeritRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.若是StartRegisterDate傳入null，則會傳回EndRegisterDate之前的資料。
        /// 2.若是EndRegisterDate傳入null，則會傳回StartRegisterDate之後的資料。
        /// </remarks>
        public static new List<JHDemeritRecord> SelectByRegisterDate(IEnumerable<string> StudentIDs, DateTime? StartRegisterDate, DateTime? EndRegisterDate)
        {
            return K12.Data.Demerit.SelectByRegisterDate<JHDemeritRecord>(StudentIDs, StartRegisterDate, EndRegisterDate);
        }


        /// <summary>
        /// 根據多筆學生編號及發生日期取得學生懲戒記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生編號</param>
        /// <param name="StartOccurDate">發生開始日期</param>
        /// <param name="EndOccurDate">發生結束日期</param>
        /// <returns>List&lt;JHDemeritRecord&gt;，代表多筆學生懲戒記錄物件。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectByOccurDate(StudentIDs,StartOccurDate,EndOccurDate);
        ///     
        ///     foreach(JHDemeritRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.若是StartOccurDate傳入null，則會傳回EndOccurDate之前的資料。
        /// 2.若是EndOccurDate傳入null，則會傳回StartOccurDate之後的資料。
        /// </remarks>
        public static new List<JHDemeritRecord> SelectByOccurDate(IEnumerable<string> StudentIDs, DateTime? StartOccurDate, DateTime? EndOccurDate)
        {
            return K12.Data.Demerit.SelectByOccurDate<JHDemeritRecord>(StudentIDs, StartOccurDate, EndOccurDate);
        }

        /// <summary>
        /// 新增單筆學生懲戒記錄
        /// </summary>
        /// <param name="DemeritRecord">學生懲戒記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHDemeritRecord newrecord = new JHDemeritRecord();
        ///         newrecord.RefStudentID = RefStudentID;
        ///         newrecord.SchoolYear = SchoolYear;
        ///         newrecord.Semester = Semester;
        ///         newrecord.OccurDate = DateTime.Today;
        ///         strng NewID = JHDemerit.Insert(newrecord)
        ///         JHDemeritRecord record = JHDemerit.SelectByID(NewID);
        ///         System.Console.Writeln(record.RefStudentID);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為學生記錄編號（RefStudentID）、學年度（SchoolYear）、學期（Semester）、缺曠日期（OccurDate）。
        /// </remarks>       
        public static string Insert(JHDemeritRecord DemeritRecord)
        {
            return K12.Data.Demerit.Insert(DemeritRecord);
        }

        /// <summary>
        /// 新增多筆學生懲戒記錄
        /// </summary>
        /// <param name="DemeritRecords">多筆學生懲戒記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHDemeritRecord record = new JHDemeritRecord();
        ///         newrecord.RefStudentID = RefStudentID;
        ///         newrecord.SchoolYear = SchoolYear;
        ///         newrecord.Semester = Semester;
        ///         newrecord.OccurDate = DateTime.Today;
        ///         
        ///         List&lt;JHDemeritRecord&gt; records = new List&lt;JHDemeritRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHDemerit.Insert(records)
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHDemeritRecord> DemeritRecords)
        {
            return K12.Data.Demerit.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.DemeritRecord,JHDemeritRecord>(DemeritRecords));
        }

        /// <summary>
        /// 更新單筆學生懲戒記錄
        /// </summary>
        /// <param name="DemeritRecord">學生懲戒記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHDemeritRecord record = JHDemerit.SelectByStudentIDs(StudentIDs)[0];
        ///     record.OccurDate = DateTime.Today;
        ///     int UpdateCount = JHDemerit.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHDemeritRecord DemeritRecord)
        {
            return K12.Data.Demerit.Update(DemeritRecord);
        }

        /// <summary>
        /// 更新多筆學生懲戒記錄
        /// </summary>
        /// <param name="DemeritRecords">多筆學生懲戒記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHDemeritRecord record = JHDemerit.SelectByStudentIDs(StudentIDs)[0];
        ///     record.OccurDate = DateTime.Today;
        ///     List&lt;JHDemeritRecord&gt; records = new List&lt;JHDemeritRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHDemerit.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHDemeritRecord> DemeritRecords)
        {
            return K12.Data.Demerit.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.DemeritRecord, JHDemeritRecord>(DemeritRecords));
        }

        /// <summary>
        /// 刪除單筆學生懲戒記錄
        /// </summary>
        /// <param name="DemeritRecord">學生懲戒記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectByStudentIDs(StudentIDs);
        ///       int DeleteCount = JHDemerit.Delete(records[0]);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHDemeritRecord DemeritRecord)
        {
            return K12.Data.Demerit.Delete(DemeritRecord);
        }

        /// <summary>
        /// 刪除單筆學生懲戒記錄
        /// </summary>
        /// <param name="DemeritID">學生懲戒記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHDemerit.Delete(DemeritID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string DemeritID)
        {
            return K12.Data.Demerit.Delete(DemeritID);
        }

        /// <summary>
        /// 刪除多筆學生懲戒記錄
        /// </summary>
        /// <param name="DermitRecords">多筆學生懲戒記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHDemeritRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHDemeritRecord&gt; records = JHDemerit.SelectByStudentIDs(StudentIDs);
        ///       int DeleteCount = Demerit.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHDemeritRecord> DermitRecords)
        {
            return K12.Data.Demerit.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.DemeritRecord, JHDemeritRecord>(DermitRecords));
        }

        /// <summary>
        /// 刪除多筆學生懲戒記錄
        /// </summary>
        /// <param name="DemeritIDs">多筆學生懲戒記錄編號</param>
        /// <returns>int，傳回刪除更新的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHDemerit.Delete(DemeritIDs);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(IEnumerable<string> DemeritIDs)
        {
            return K12.Data.Demerit.Delete(DemeritIDs);
        }
    }
}