using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生家長及監護人類別，提供方法用來取得及修改學生家長及監護人資訊
    /// </summary>
    public class JHParent : K12.Data.Parent
    {
        /// <summary>
        /// 取得所有學生家長及監護人記錄物件列表。
        /// </summary>
        /// <returns>List&lt;JHParentRecord&gt;，代表多筆學生家長及監護人記錄物件。</returns>
        /// <seealso cref="JHParentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHParentRecord&gt; records = JHParent.SelectAll();
        ///     
        ///     foreach(JHParentRecord record in records)
        ///         Console.WrlteLine(record.Mother.Name);
        ///     </code>
        /// </example>
        [SelectMethod("JHSchool.JHParent.SelectAll", "學籍.學生家長及監護人")]
        public new static List<JHParentRecord> SelectAll()
        {
            return SelectAll<JHParentRecord>();
        }

        /// <summary>
        /// 根據單筆學生記錄物件取得學生家長及監護人記錄物件。
        /// </summary>
        /// <param name="Student">學生記錄物件</param>
        /// <returns>JHParentRecord，代表學生家長及監人記錄物件。</returns>
        /// <seealso cref="JHStudentRecord"/>
        /// <seealso cref="JHParentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHPaerntRecord record = JHParent.SelectByStudent(Student);
        ///     
        ///    if (record != null)
        ///        System.Console.WriteLine(record.Mother.Name);
        ///     </code>
        /// </example>
        /// <remarks>若是Student不則在則會傳回null</remarks>
        public static JHParentRecord SelectByStudent(JHStudentRecord Student)
        {
            return K12.Data.Parent.SelectByStudent<JHParentRecord>(Student);
        }

        /// <summary>
        /// 根據單筆學生記錄編號取得學生家長及監護人記錄物件。
        /// </summary>
        /// <param name="StudentID">學生記錄編號</param>
        /// <returns>JHParentRecord，代表學生家長及監護人記錄物件。</returns>
        /// <seealso cref="JHParentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHParentRecord record = JHParent.SelectByStudent(StudentID);
        ///     
        ///     if (record != null)
        ///        System.Console.WriteLine(record.Mother.Name);
        ///     </code>
        /// </example>
        /// <remarks>若是StudentID不則在則會傳回null</remarks>
        public static new JHParentRecord SelectByStudentID(string StudentID)
        {
            return K12.Data.Parent.SelectByStudentID<JHParentRecord>(StudentID);
        }

        /// <summary>
        /// 根據多筆學生記錄物件取得學生家長及監護人記錄物件列表。
        /// </summary>
        /// <param name="Students">多筆學生記錄物件</param>
        /// <returns>List&lt;JHParentRecord&gt;，代表多筆學生家長及監護人記錄物件。</returns>
        /// <seealso cref="JHParentRecord"/>
        /// <seealso cref="JHStudentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHParentRecord&gt; records = JHParent.SelectByStudents(Students);
        ///     
        ///     foreach(JHParentRecord record in records)
        ///         Console.WrlteLine(record.Mother.Name);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static List<JHParentRecord> SelectByStudents(List<JHStudentRecord> Students)
        {
            return K12.Data.Parent.SelectByStudents<JHParentRecord>(K12.Data.Utility.Utility.GetBaseList<K12.Data.StudentRecord, JHStudentRecord>(Students));
        }

        /// <summary>
        /// 根據多筆學生記錄編號取得學生家長及監護人記錄物件列表。
        /// </summary>
        /// <param name="StudentIDs">多筆學生記錄編號</param>
        /// <returns>List&lt;JHParentRecord&gt;，代表多筆學生家長及監護人記錄物件。</returns>
        /// <seealso cref="JHParentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHParentRecord&gt; records = JHParent.SelectByStudentIDs(StudentIDs);
        ///     
        ///     foreach(JHParentRecord record in records)
        ///         Console.WrlteLine(record.Mother.Name);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆學生，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>
        public static new List<JHParentRecord> SelectByStudentIDs(List<string> StudentIDs)
        {
            return K12.Data.Parent.SelectByStudentIDs<JHParentRecord>(StudentIDs);
        }

        /// <summary>
        /// 更新單筆家長及監護人記錄
        /// </summary>
        /// <param name="ParentRecord">家長及監護人記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHParentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHParentRecord record = JHParent.SelectByStudentID(StudentID);
        ///     record.Mother.Name = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHParent.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHParentRecord ParentRecord)
        {
            return K12.Data.Parent.Update(ParentRecord);
        }

        /// <summary>
        /// 更新多筆家長及監護人記錄
        /// </summary>
        /// <param name="ParentRecords">多筆家長及監護人記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHParentRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHParentRecord record = JHParent.SelectByStudentID(StudentID);
        ///     record.Mother.Name = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHParentRecord&gt; records = new List&lt;JHParentRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHParent.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHParentRecord> ParentRecords)
        {
            return K12.Data.Parent.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.ParentRecord, JHParentRecord>(ParentRecords));            
        }
    }
}