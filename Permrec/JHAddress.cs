using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生地址類別，提供方法用來取得及修改學生地址資訊
    /// </summary>
    public class JHAddress : K12.Data.Address
    {
        /// <summary>
        /// 取得所有學生地址記錄物件列表。
        /// </summary>
        /// <returns>List&lt;JHAddressRecord&gt;，代表多筆學生地址記錄物件。</returns>
        /// <seealso cref="JHAddressRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHAddressRecord&gt; records = JHAddress.SelectAll();
        ///     
        ///     foreach(JHAddressRecord record in records)
        ///         System.Console.WriteLine(record.Name); 
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHAddress.SelectAll", "學籍.學生地址")]
        public new static List<JHAddressRecord> SelectAll()
        {
            return SelectAll<JHAddressRecord>();
        }

        /// <summary>
        /// 根據單筆學生記錄物件取得學生地址記錄物件。
        /// </summary>
        /// <param name="Student">學生記錄物件</param>
        /// <returns>JHAddressRecord，代表學生地址物件。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <seealso cref="JHAddressRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHAddressRecord record = JHAddress.SelectByStudent(Student);
        ///         
        ///         if (record!=null)
        ///             System.Console.WriteLine(record.Permanent.ZipCode); 
        ///     </code>
        /// </example>
        /// <remarks>若是Student不存在則會傳回null</remarks>
        public static JHAddressRecord SelectByStudent(JHStudentRecord Student)
        {
            return K12.Data.Address.SelectByStudent<JHAddressRecord>(Student);
        }

        /// <summary>
        /// 根據單筆學生記錄編號取得學生地址記錄物件。
        /// </summary>
        /// <param name="StudentID">學生記錄編號</param>
        /// <returns>JHAddressRecord，代表學生地址記錄物件。</returns>
        /// <seealso cref="JHAddressRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHAddressRecord record = JHAddress.SelectByStudentID(StudentID);
        ///         
        ///         if (record!=null)
        ///             System.Console.WriteLine(record.Permanent.ZipCode); 
        ///     </code>
        /// </example>
        /// <remarks>若是StudentID不存在則會傳回null</remarks>
        public static new JHAddressRecord SelectByStudentID(string StudentID)
        {
            return K12.Data.Address.SelectByStudentID<JHAddressRecord>(StudentID);
        }

        /// <summary>
        /// 根據多筆學生記錄物件取得地址記錄物件列表。
        /// </summary>
        /// <param name="Students">多筆學生記錄物件</param>
        /// <returns>List&lt;JHAddressRecord&gt;，代表多筆學生地址記錄物件。</returns>
        /// <seealso cref="JHAddressRecord"/>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHAddressRecord&gt; records = JHAddress.SelectByStudents(Students);
        ///     
        ///     foreach(JHAddressRecord record in records)
        ///         System.Console.WriteLine(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆ID，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static List<JHAddressRecord> SelectByStudents(IEnumerable<JHStudentRecord> Students)
        {
            return K12.Data.Address.SelectByStudents<JHAddressRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord,JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據多筆學生記錄編號取得地址記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>List&lt;JHAddressRecord&gt;，代表多筆學生地址記錄物件。</returns>
        /// <seealso cref="JHAddressRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHAddressRecord&gt; records = JHAddress.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHAddressRecord record in records)
        ///         System.Console.WriteLine(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆ID，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static new List<JHAddressRecord> SelectByStudentIDs(IEnumerable<string> StudentIDs)
        {
            return K12.Data.Address.SelectByStudentIDs<JHAddressRecord>(StudentIDs);
        }

        /// <summary>
        /// 更新單筆學生地址記錄
        /// </summary>
        /// <param name="AddressRecord">學生地址記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHAddressRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHAddressRecord record = JHAddress.SelectByStudentID(StudentID);
        ///     record.PerPermanent.ZipCode = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHAddress.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHAddressRecord AddressRecord)
        {
            return K12.Data.Address.Update(AddressRecord);
        }

        /// <summary>
        /// 更新多筆學生地址記錄
        /// </summary>
        /// <param name="AddressRecords">多筆學生地址記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHAddressRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHAddressRecord record = JHAddress.SelectByStudentID(StudentID);
        ///     record.PerPermanent.ZipCode = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHAddressRecord&gt; records = new List&lt;JHAddressRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHAddress.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHAddressRecord> AddressRecords)
        {
            return K12.Data.Address.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.AddressRecord,JHAddressRecord>(AddressRecords));
        }
    }
}