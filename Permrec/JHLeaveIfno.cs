using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生離校資訊類別，提供方法用來取得及修改學生地址資訊
    /// </summary>
    public class JHLeaveIfno : K12.Data.LeaveInfo
    {
        /// <summary>
        /// 取得所有學生離校資訊物件列表。
        /// </summary>
        /// <returns>List&lt;JHLeaveInfoRecord&gt;，代表多筆學生離校資訊物件。</returns>
        /// <seealso cref="JHLeaveInfoRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHLeaveInfoRecord&gt; records = JHLeaveInfo.SelectAll();
        ///     
        ///     foreach(JHLeaveInfoRecord record in records)
        ///         Console.WrlteLine(record.Reason);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHLeaveInfo.SelectAll", "學籍.離校資訊")]
        public new static List<JHLeaveInfoRecord> SelectAll()
        {
            return SelectAll<JHLeaveInfoRecord>();
        }

        /// <summary>
        /// 根據單筆學生記錄物件取得學生離校資訊物件。
        /// </summary>
        /// <param name="Student">學生記錄物件</param>
        /// <returns>JHLeaveInfoRecord，代表學生離校資訊物件。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <seealso cref="JHLeaveInfoRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHLeaveInfoRecord record = JHLeaveInfo.SelectByStudent(Student);
        ///     
        ///    if (record != null)
        ///        System.Console.WriteLine(record.Reason);
        ///     </code>
        /// </example>
        /// <remarks>若是Student不則在則會傳回null</remarks>
        public static JHLeaveInfoRecord SelectByStudent(JHStudentRecord Student)
        {
            return K12.Data.LeaveInfo.SelectByStudent<JHLeaveInfoRecord>(Student);
        }

        /// <summary>
        /// 根據單筆學生記錄編號取得學生離校資訊物件。
        /// </summary>
        /// <param name="StudentID">學生記錄編號</param>
        /// <returns>JHLeaveInfoRecord，代表學生離校資訊物件。</returns>
        /// <seealso cref="JHLeaveInfoRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHLeaveInfoRecord record = JHLeaveInfo.SelectByStudentID(StudentID);
        ///     
        ///     if (record != null)
        ///        System.Console.WriteLine(record.Reason);
        ///     </code>
        /// </example>
        /// <remarks>若是StudentID不則在則會傳回null</remarks>
        public static new JHLeaveInfoRecord SelectByStudentID(string StudentID)
        {
            return K12.Data.LeaveInfo.SelectByStudentID<JHLeaveInfoRecord>(StudentID);
        }

        /// <summary>
        /// 根據多筆學生記錄物件取得學生離校資訊物件列表。
        /// </summary>
        /// <param name="Students">多筆學生記錄物件</param>
        /// <returns>List&lt;JHLeaveInfoRecord&gt;，代表多筆學生離校資訊物件。</returns>
        /// <seealso cref="JHLeaveInfoRecord"/>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHLeaveInfoRecord&gt; records = JHLeaveInfo.SelectByStudents(Students);
        ///     
        ///     foreach(JHLeaveInfoRecord record in records)
        ///         Console.WrlteLine(record.Reason);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static List<JHLeaveInfoRecord> SelectByStudents(IEnumerable<JHStudentRecord> Students)
        {
            return K12.Data.LeaveInfo.SelectByStudents<JHLeaveInfoRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord,JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據多筆學生記錄編號取得學生離校資訊物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>List&lt;JHLeaveInfoRecord&gt;，代表多筆學生離校資訊物件。</returns>
        /// <seealso cref="JHLeaveInfoRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHLeaveInfoRecord&gt; records = JHLeaveInfo.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHLeaveInfoRecord record in records)
        ///         Console.WrlteLine(record.Reason);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static new List<JHLeaveInfoRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.LeaveInfo.SelectByStudentIDs<JHLeaveInfoRecord>(StudentIDs);
        }

        /// <summary>
        /// 更新單筆學生離校資訊
        /// </summary>
        /// <param name="LeaveInfoRecord">學生離校資訊物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHLeaveInfoRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHLeaveInfoRecord record = JHLeaveInfo.SelectByStudentID(StudentID);
        ///     record.Reason = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHLeaveInfo.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHLeaveInfoRecord LeaveInfoRecord)
        {
            return K12.Data.LeaveInfo.Update(LeaveInfoRecord);
        }

        /// <summary>
        /// 更新多筆學生離校資訊
        /// </summary>
        /// <param name="LeaveInfoRecords">多筆學生離校資訊物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHLeaveInfoRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHLeaveInfoRecord record = JHLeaveInfo.SelectByStudentID(StudentID);
        ///     record.Reason = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHLeaveInfoRecord&gt; records = new List&lt;JHLeaveInfoRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHLeaveInfo.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHLeaveInfoRecord> LeaveInfoRecords)
        {
            return K12.Data.LeaveInfo.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.LeaveInfoRecord,JHLeaveInfoRecord>(LeaveInfoRecords));
        }
    }
}