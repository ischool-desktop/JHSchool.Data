using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生電話類別，提供方法用來取得及修改學生電話資訊
    /// </summary>
    public class JHPhone : K12.Data.Phone
    {
        /// <summary>
        /// 取得所有學生電話記錄物件。
        /// </summary>
        /// <returns>List&lt;JHPhoneRecord&gt;，代表多筆學生電話記錄物件。</returns>
        /// <seealso cref="JHPhoneRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHPhoneRecord&gt; records = JHPhone.SelectAll();
        ///     
        ///     foreach(JHPhoneRecord record in records)
        ///         Console.WrlteLine(record.Permanent);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHPhone.SelectAll", "學籍.學生電話")]
        public static List<JHPhoneRecord> SelectAll()
        {
            return SelectAll<JHPhoneRecord>();
        }

        /// <summary>
        /// 根據單筆學生記錄編號取得學生電話記錄物件。
        /// </summary>
        /// <param name="StudentID">學生記錄編號</param>
        /// <returns>JHPhoneRecord，代表學生電話記錄物件。</returns>
        /// <seealso cref="JHPhoneRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHPhoneRecord record = JHPhone.SelectByStudentID(StudentID);
        ///     
        ///    if (record != null)
        ///        System.Console.WriteLine(record.Permanent);
        ///     </code>
        /// </example>
        /// <remarks>若是Student不則在則會傳回null</remarks>
        public static new JHPhoneRecord SelectByStudentID(string StudentID)
        {
            return K12.Data.Phone.SelectByStudentID<JHPhoneRecord>(StudentID);
        }

        /// <summary>
        /// 根據單筆學生記錄物件取得學生電話記錄物件。
        /// </summary>
        /// <param name="Student">學生記錄物件</param>
        /// <returns>JHPhoneRecord，代表學生電話記錄物件。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <seealso cref="JHPhoneRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHPhoneRecord record = JHPhone.SelectByStudent(Student);
        ///     
        ///      if (record != null)
        ///        System.Console.WriteLine(record.Permanent);
        ///     </code>
        /// </example>
        /// <remarks>若是Student不則在則會傳回null</remarks>
        public static JHPhoneRecord SelectByStudent(JHStudentRecord Student)
        {
            return K12.Data.Phone.SelectByStudent<JHPhoneRecord>(Student);
        }

        /// <summary>
        /// 根據多筆學生記錄物件取得學生電話記錄物件列表。
        /// </summary>
        /// <param name="Students">多筆學生記錄物件</param>
        /// <returns>List&lt;JHPhoneRecord&gt;，代表多筆學生電話記錄物件。</returns>
        /// <seealso cref="JHPhoneRecord"/>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHPhoneRecord&gt; records = JHPhone.SelectByStudents(Students);
        ///     
        ///     foreach(JHPhoneRecord record in records)
        ///         Console.WrlteLine(record.Permanent);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static List<JHPhoneRecord> SelectByStudents(List<JHStudentRecord> Students)
        {
            return K12.Data.Phone.SelectByStudents<JHPhoneRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord,JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據多筆學生記錄編號取得學生電話記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>List&lt;JHPhoneRecord&gt;，代表多筆學生電話記錄物件。</returns>
        /// <seealso cref="JHPhoneRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHPhoneRecord&gt; records = JHPhone.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHPhoneRecord record in records)
        ///         Console.WrlteLine(record.Permanent);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static new List<JHPhoneRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.Phone.SelectByStudentIDs<JHPhoneRecord>(StudentIDs);
        }

        /// <summary>
        /// 更新單筆學生電話記錄
        /// </summary>
        /// <param name="PhoneRecord">學生電話記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHPhoneRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHPhoneRecord record = JHPhone.SelectByStudentID(StudentID);
        ///     record.Permanent = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHPhone.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHPhoneRecord PhoneRecord)
        {
            return K12.Data.Phone.Update(PhoneRecord);
        }

        /// <summary>
        /// 更新多筆學生電話記錄
        /// </summary>
        /// <param name="PhoneRecords">多筆學生電話記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHPhoneRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHPhoneRecord record = JHPhone.SelectByStudentID(StudentID);
        ///     record.Permanent = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHPhoneRecord&gt; records = new List&lt;JHPhoneRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHPhone.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHPhoneRecord> PhoneRecords)
        {
            return K12.Data.Phone.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.PhoneRecord,JHPhoneRecord>(PhoneRecords));
        }
    }
}