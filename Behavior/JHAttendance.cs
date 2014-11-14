using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生缺曠類別，提供方法用來取得、新增、修改及刪除學生缺曠資訊
    /// </summary>
    public class JHAttendance : K12.Data.Attendance
    {
        [SelectMethod("JHSchool.JHAttendance.SelectAllAttendancePeriod", "學務.缺曠")]
        public static List<AttendancePeriod> SelectAllAttendancePeriod()
        {
            List<JHAttendanceRecord> Attendances = SelectAll();

            List<AttendancePeriod> Periods = new List<AttendancePeriod>();

            for (int i = 0; i < Attendances.Count; i++)
                Periods.AddRange(Attendances[i].PeriodDetail);

            return Periods;
        }

        /// <summary>
        /// 取得所有缺曠紀錄
        /// </summary>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 JHAttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <example>
        ///     <code>
        ///     List&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectAll();
        ///     
        ///     foreach(JHAttendanceRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>    
        /// <exception cref="Exception">
        /// </exception>
        public new static List<JHAttendanceRecord> SelectAll()
        {
            return SelectAll<JHAttendanceRecord>();
        }

        /// <summary>
        /// 根據條件取得缺曠紀錄列表
        /// </summary>
        /// <param name="StudentIDs">學生編號列表</param>
        /// <param name="StartDate">缺曠發生開始時間</param>
        /// <param name="EndDate">缺曠發生結束時間</param>
        /// <param name="OccurDate">缺曠發生時間</param>
        /// <param name="SchoolYears">學年度列表</param>
        /// <param name="Semesters">學期列表</param>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 AttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        public static new List<JHAttendanceRecord> Select(IEnumerable<string> StudentIDs, DateTime? StartDate, DateTime? EndDate, DateTime? OccurDate, IEnumerable<int> SchoolYears, IEnumerable<int> Semesters)
        {
            return Select<JHAttendanceRecord>(StudentIDs,StartDate,EndDate,OccurDate,SchoolYears,Semesters);
        }

        /// <summary>
        /// 根據條件取得缺曠紀錄列表
        /// </summary>
        /// <param name="StudentIDs">學生編號列表</param>
        /// <param name="StartDate">缺曠發生開始時間</param>
        /// <param name="EndDate">缺曠發生結束時間</param>
        /// <param name="OccurDates">缺曠發生時間列表</param>
        /// <param name="SchoolYears">學年度列表</param>
        /// <param name="Semesters">學期列表</param>
        /// <param name="SchoolYearSemesters">學年度學期列表</param>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 AttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        public static new List<JHAttendanceRecord> Select(IEnumerable<string> StudentIDs, DateTime? StartDate, DateTime? EndDate, IEnumerable<DateTime> OccurDates, IEnumerable<int> SchoolYears, IEnumerable<int> Semesters, IEnumerable<SchoolYearSemester> SchoolYearSemesters)
        {
            return K12.Data.Attendance.Select<JHAttendanceRecord>(StudentIDs, StartDate, EndDate,OccurDates, SchoolYears, Semesters, SchoolYearSemesters);
        }

        /// <summary>
        /// 取得指定學生在某學年度學期的學生缺曠紀錄
        /// </summary>
        /// <param name="Students">學生記錄物件列表</param>
        /// <param name="SchoolYear">學年度，傳入null代表取得所有學年度資料。</param>
        /// <param name="Semester">學期，傳入null代表取得所有學期資料。</param>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 AttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectBySchoolYearAndSemester(Students, 98,1);
        ///     
        ///     foreach(JHAttendanceRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>    
        public static List<JHAttendanceRecord> SelectBySchoolYearAndSemester(IEnumerable<JHStudentRecord> Students,
                                                                        int? SchoolYear,
                                                                        int? Semester)
        {
            return K12.Data.Attendance.SelectBySchoolYearAndSemester<JHAttendanceRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord, JHStudentRecord>(Students), SchoolYear, Semester);
        }

        /// <summary>
        /// 取得指定學生在日期區間的學生缺曠紀錄
        /// </summary>
        /// <param name="Students">學生記錄物件列表</param>
        /// <param name="BeginDate">開始日期</param>
        /// <param name="EndDate">結束日期</param>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 AttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <remarks></remarks>
        /// <example>
        ///     <code>
        ///     DateTime beginDate = new DateTime(2009, 4, 1);
        ///     DateTime endDate = DateTime.Now ;
        ///
        ///     ListList&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectByDate(Students, beginDate, endDate );
        ///     
        ///     foreach(JHAttendanceRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static List<JHAttendanceRecord> SelectByDate(IEnumerable<JHStudentRecord> Students,
                                                        DateTime BeginDate,
                                                        DateTime EndDate)
        {
            return K12.Data.Attendance.SelectByDate<JHAttendanceRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord, JHStudentRecord>(Students),BeginDate ,EndDate);
        }

        /// <summary>
        /// 取得指定日期區間的學生缺曠紀錄
        /// </summary>
        /// <param name="BeginDate">開始日期</param>
        /// <param name="EndDate">結束日期</param>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 AttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <example>
        ///     <code>
        ///     DateTime beginDate = new DateTime(2009, 4, 1);
        ///     DateTime endDate = DateTime.Now ;
        ///
        ///     List&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectByDate(StudentIDs,beginDate, endDate );
        ///     foreach(JHAttendanceRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHAttendanceRecord> SelectByDate(DateTime BeginDate, DateTime EndDate)
        {
            return K12.Data.Attendance.SelectByDate<JHAttendanceRecord>(BeginDate, EndDate);
        }

        /// <summary>
        /// 取得指定學生歷年所有的學生缺曠紀錄
        /// </summary>
        /// <param name="Students">學生記錄物件列表</param>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 AttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <example>
        ///     <code>
        ///     List&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectByStudents(Students);
        ///     
        ///     foreach(JHAttendanceRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static List<JHAttendanceRecord> SelectByStudents(IEnumerable<JHStudentRecord> Students)
        {
            return K12.Data.Attendance.SelectByStudents<JHAttendanceRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord, JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據多筆學生編號取得學生缺曠紀錄
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>List&lt;JHAttendanceRecord&gt;，一個 JHAttendanceRecord物件代表一個學生在某一天的缺曠紀錄。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <example>
        ///     <code>
        ///     List&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHAttendanceRecord record in records)
        ///         System.Console.WriteLine(record.RefStudentID);
        ///     </code>
        /// </example>
        public static new List<JHAttendanceRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.Attendance.SelectByStudentIDs<JHAttendanceRecord>(StudentIDs);
        }

        /// <summary>
        /// 新增單筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecord">學生缺曠記錄</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHAttendanceRecord newrecord = new JHAttendanceRecord();
        ///         newrecord.RefStudentID = RefStudentID;
        ///         newrecord.SchoolYear = SchoolYear;
        ///         newrecord.Semester = Semester;
        ///         newrecord.OccurDate = DateTime.Today;
        ///         strng NewID = JHAttendance.Insert(newrecord)
        ///         JHAttendanceRecord record = JHAttendance.SelectByID(NewID);
        ///         System.Console.Writeln(record.RefStudentID);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為學生記錄編號（RefStudentID）、學年度（SchoolYear）、學期（Semester）、缺曠日期（OccurDate）。
        /// </remarks>
        public static string Insert(JHAttendanceRecord AttendanceRecord)
        {
            //AttendanceRecord K12AttendanceRecord = AttendanceRecord;

            //foreach (JHAttendancePeriod JHAttendancePeriod in AttendanceRecord.PeriodDetail)
            //    K12AttendanceRecord.PeriodDetail.Add(JHAttendancePeriod);

            return K12.Data.Attendance.Insert(AttendanceRecord);
        }

        /// <summary>
        /// 新增多筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecords">多筆班級記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHAttendanceRecord record = new JHAttendanceRecord();
        ///         newrecord.RefStudentID = RefStudentID;
        ///         newrecord.SchoolYear = SchoolYear;
        ///         newrecord.Semester = Semester;
        ///         newrecord.OccurDate = DateTime.Today;
        ///         
        ///         List&lt;JHAttendanceRecord&gt; records = new List&lt;JHAttendanceRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHAttendance.Insert(records)
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHAttendanceRecord> AttendanceRecords)
        {
            //foreach (JHAttendanceRecord JHAttendanceRec in AttendanceRecords)
            //{
            //    AttendanceRecord AttendanceRec = JHAttendanceRec;

            //    foreach (JHAttendancePeriod JHAttendancePeriod in JHAttendanceRec.PeriodDetail)
            //        AttendanceRec.PeriodDetail.Add(JHAttendancePeriod);
            //}

            return K12.Data.Attendance.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.AttendanceRecord, JHAttendanceRecord>(AttendanceRecords));
        }

        /// <summary>
        /// 更新單筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecord">學生缺曠記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHAttendanceRecord record = JHAttendance.SelectByStudentID(Student)[0];
        ///     record.OccurDate = DateTime.Today;
        ///     int UpdateCount = JHAttendance.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHAttendanceRecord AttendanceRecord)
        {
            return K12.Data.Attendance.Update(AttendanceRecord);
        }

        /// <summary>
        /// 更新多筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecords">多筆學生缺曠記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHAttendanceRecord record = JHAttendance.SelectByStudentID(Student)[0];
        ///     record.Date = DateTime.Today;
        ///     List&lt;JHAttendanceRecord&gt; records = new List&lt;JHAttendanceRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHAttendance.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHAttendanceRecord> AttendanceRecords)
        {
            return K12.Data.Attendance.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.AttendanceRecord, JHAttendanceRecord>(AttendanceRecords));
        }

        /// <summary>
        /// 刪除單筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecord">學生缺曠記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectByStudentIDs(StudentIDs);
        ///       int DeleteCount = JHAttendance.Delete(records[0]);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHAttendanceRecord AttendanceRecord)
        {
            return K12.Data.Attendance.Delete(AttendanceRecord);
        }

        /// <summary>
        /// 刪除單筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecordID">學生缺曠記錄編號</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHAttendance.Delete(AttendanceID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string AttendanceRecordID)
        {
            return K12.Data.Attendance.Delete(AttendanceRecordID);
        }

        /// <summary>
        /// 刪除多筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecords">多筆學生缺曠記錄物件</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHAttendanceRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHAttendanceRecord&gt; records = JHAttendance.SelectByStudentIDs(StudentIDs);
        ///       int DeleteCount = JHAttendance.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHAttendanceRecord> AttendanceRecords)
        {
            return K12.Data.Attendance.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.AttendanceRecord, JHAttendanceRecord>(AttendanceRecords));
        }

        /// <summary>
        /// 刪除多筆學生缺曠記錄
        /// </summary>
        /// <param name="AttendanceRecordIDs">多筆學生缺曠記錄編號</param>
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHAttendance.Delete(AttendanceIDs);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(IEnumerable<string> AttendanceRecordIDs)
        {
            return K12.Data.Attendance.Delete(AttendanceRecordIDs);
        }
    }
}