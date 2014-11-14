using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 試別項目類別，提供方法用來取得、新增、修改及刪除試別項目資訊
    /// </summary>
    public class JHExam : K12.Data.Exam
    {
        /// <summary>
        /// 取得所有考試項目列表。
        /// </summary>
        /// <returns>List&lt;JHExamRecord&gt;，代表多筆考試項目記錄物件。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHExamRecord&gt; records = JHExam.SelectAll();
        /// </example>
        [SelectMethod("JHSchool.JHExam.SelectAll", "成績.試別")]
        public static new List<JHExamRecord> SelectAll()
        {
            return SelectAll<JHExamRecord>();
        }

        /// <summary>
        /// 根據單筆考試項目編號取得考試項目。
        /// </summary>
        /// <param name="ExamID">單筆考試項目編號</param>
        /// <returns>JHExamRecord，代表單筆考試項目記錄物件。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     JHExamRecord record = JHExam.SelectByID(ExamID);
        /// </example>
        public static new JHExamRecord SelectByID(string ExamID)
        {
            return SelectByID<JHExamRecord>(ExamID);
        }

        /// <summary>
        /// 根據多筆考試項目編號取得考試項目列表。
        /// </summary>
        /// <param name="ExamIDs">多筆考試項目編號</param>
        /// <returns>List&lt;JHExamRecord&gt;，代表多筆考試項目記錄物件。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHExamRecord&gt; records = JHExam.SelectByIDs(ExamIDs);
        /// </example>
        public static new List<JHExamRecord> SelectByIDs(IEnumerable<string> ExamIDs)
        {
            return SelectByIDs<JHExamRecord>(ExamIDs);
        }

        /// <summary>
        /// 新增單筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecord">考試項目記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        public static new string Insert(JHExamRecord ExamRecord)
        {
            return K12.Data.Exam.Insert(ExamRecord);
        }

        /// <summary>
        /// 新增多筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecords">多筆考試項目記錄物件</param> 
        /// <returns>List&lt;string&gt，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static new List<string> Insert(IEnumerable<JHExamRecord> ExamRecords)
        {
            return K12.Data.Exam.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.ExamRecord, JHExamRecord>(ExamRecords));
        }

        /// <summary>
        /// 更新單筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecord">考試項目記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static new int Update(JHExamRecord ExamRecord)
        {
            return K12.Data.Exam.Update(ExamRecord);
        }

        /// <summary>
        /// 更新多筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecords">多筆考試項目記錄</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(IEnumerable<JHExamRecord> ExamRecords)
        {
            return K12.Data.Exam.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.ExamRecord, JHExamRecord>(ExamRecords));
        }

        /// <summary>
        /// 刪除單筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecord">考試項目記錄物件</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(JHExamRecord ExamRecord)
        {
            return K12.Data.Exam.Delete(ExamRecord);
        }

        /// <summary>
        /// 刪除單筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecordID">考試項目記錄編號</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(string ExamID)
        {
            return K12.Data.Exam.Delete(ExamID);
        }

        /// <summary>
        /// 刪除多筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecords">多筆考試項目記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="ExamRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(IEnumerable<JHExamRecord> ExamRecords)
        {
            return K12.Data.Exam.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.ExamRecord, JHExamRecord>(ExamRecords));
        }

        /// <summary>
        /// 刪除多筆考試項目記錄
        /// </summary>
        /// <param name="ExamRecordIDs">多筆考試項目記錄編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(IEnumerable<string> ExamIDs)
        {
            return K12.Data.Exam.Delete(ExamIDs);
        }
    }
}