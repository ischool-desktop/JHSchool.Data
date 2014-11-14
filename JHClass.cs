using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 班級類別，提供方法用來取得、新增、修改及刪除班級資訊
    /// </summary>
    public class JHClass : K12.Data.Class
    {
        /// <summary>
        /// 取得所有班級列表。
        /// </summary>
        /// <returns>List&lt;JHClassRecord&gt;，代表班級物件列表。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHClassRecord&gt; records = JHClass.SelectAll();
        ///     
        ///     foreach(JHClassRecord record in records)
        ///         System.Console.Writeln(record.Name); 
        ///     </code>
        /// </example>
        /// <remarks>
        /// 請先using K12.Data;
        /// </remarks>
        [SelectMethod("JHSchool.JHClass.SelectAll", "學籍.班級")]
        public static new List<JHClassRecord> SelectAll()
        {
            return K12.Data.Class.SelectAll<JHClassRecord>();
        }

        /// <summary>
        /// 根據單筆班級編號取得班級物件。
        /// </summary>
        /// <param name="ClassID">班級編號</param>
        /// <returns>JHClassRecord，代表班級物件。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHClassRecord&gt; records = JHClass.SelectAll();
        /// 
        ///     JHClassRecord record = JHClass.SelectByID(records[(new System.Random()).Next(records.Count - 1)].ID);
        ///
        ///    if (record != null)
        ///        System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>若是ClassID不則在則會傳回null</remarks>
        public static new JHClassRecord SelectByID(string ClassID)
        {
            return K12.Data.Class.SelectByID<JHClassRecord>(ClassID);
        }

        /// <summary>
        /// 根據多筆班級編號取得班級物件列表。
        /// </summary>
        /// <param name="ClassIDs">多筆班級編號</param>
        /// <returns>List&lt;JHClassRecord&gt;，代表班級物件。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHClassRecord&gt; allrecords = JHClass.SelectAll();
        ///     
        ///     List&lt;string&gt; IDs = new List&lt;string&gt;();
        ///     
        ///     foreach(JHClassRecord record in allrecords)
        ///         IDs.Add(record.ID);
        /// 
        ///     List&lt;JHClassRecord&gt; records = JHClass.SelectByIDs(IDs);
        ///     </code>
        /// </example>
        /// <remarks>可能情況若是傳5筆ID，但是其中1筆沒有資料，就只會回傳4筆資料</remarks>

        public static new List<JHClassRecord> SelectByIDs(IEnumerable<string> ClassIDs)
        {
            return K12.Data.Class.SelectByIDs<JHClassRecord>(ClassIDs);
        }

        /// <summary>
        /// 新增單筆班級記錄
        /// </summary>
        /// <param name="ClassRecord">班級記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHClassRecord newrecord = new JHClassRecord();
        ///         newrecord.Name = (new System.Random()).NextDouble().ToString();
        ///         strng NewID = JHClass.Insert(newrecord)
        ///         JHClassRecord record = JHClass.SelectByID(NewID);
        ///         System.Console.Writeln(record.Name);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增一律傳回新增物件的編號。
        /// 2.新增必填欄位為課程名稱（Name）。
        /// </remarks>
        public static string Insert(JHClassRecord ClassRecord)
        {
            return K12.Data.Class.Insert(ClassRecord);
        }

        /// <summary>
        /// 新增多筆班級記錄
        /// </summary>
        /// <param name="ClassRecords">多筆班級記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         JHClassRecord record = new JHClassRecord();
        ///         record.Name = (new System.Random()).NextDouble().ToString();
        ///         List&lt;JHClassRecord&gt; records = new List&lt;JHClassRecord&gt;();
        ///         records.Add(record);
        ///         List&lt;string&gt; NewID = JHClass.Insert(records);
        ///     </code>
        /// </example>
        public static List<string> Insert(IEnumerable<JHClassRecord> ClassRecords)
        {
            List<K12.Data.ClassRecord> Classes = new List<K12.Data.ClassRecord>();

            foreach (JHClassRecord ClassRecord in ClassRecords)
                Classes.Add(ClassRecord);

            return K12.Data.Class.Insert(Classes);       
        }

        /// <summary>
        /// 更新單筆班級記錄
        /// </summary>
        /// <param name="ClassRecord">班級記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHClassRecord record = JHClass.SelectByID(ClassID);
        ///     record.Name = (new System.Random()).NextDouble().ToString();
        ///     int UpdateCount = JHClass.Update(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(JHClassRecord ClassRecord)
        {
            return K12.Data.Class.Update(ClassRecord);
        }

        /// <summary>
        /// 更新多筆班級記錄
        /// </summary>
        /// <param name="ClassRecords">班級記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHClassRecord record = JHClass.SelectByID(ClassID);
        ///     record.Name = (new System.Random()).NextDouble().ToString();
        ///     List&lt;JHClassRecord&gt; records = new List&lt;JHClassRecord&gt;();
        ///     records.Add(record);
        ///     int UpdateCount = JHClass.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功更新的筆數。</remarks>
        public static int Update(IEnumerable<JHClassRecord> ClassRecords)
        {
            List<K12.Data.ClassRecord> Classes = new List<K12.Data.ClassRecord>();

            foreach (JHClassRecord ClassRecord in ClassRecords)
                Classes.Add(ClassRecord);

            return K12.Data.Class.Update(Classes);
        }

        /// <summary>
        /// 刪除多筆班級記錄
        /// </summary>
        /// <param name="ClassRecords">多筆班級記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHClassRecord&gt; records = JHClass.SelectByIDs(ClassIDs);
        ///       int DeleteCount = JHClass.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(IEnumerable<JHClassRecord> ClassRecords)
        {
            List<K12.Data.ClassRecord> Classes = new List<K12.Data.ClassRecord>();

            foreach (JHClassRecord ClassRecord in ClassRecords)
                Classes.Add(ClassRecord);

            return K12.Data.Class.Delete(Classes);
        }

        /// <summary>
        /// 刪除單筆班級記錄
        /// </summary>
        /// <param name="ClassRecord">班級記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHClassRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       List&lt;JHClassRecord&gt; record = JHClass.SelectByID(ClassID);
        ///       int DeleteCount = JHClass.Delete(record);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public int Delete(JHClassRecord ClassRecord)
        {
            return K12.Data.Class.Delete(ClassRecord);
        }

        /// <summary>
        /// 刪除單筆班級記錄
        /// </summary>
        /// <param name="ClassID">班級記錄系統編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHClass.Delete(ClassID);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(string ClassID)
        {
            return K12.Data.Class.Delete(ClassID);
        }

        /// <summary>
        /// 刪除多筆班級記錄
        /// </summary>
        /// <param name="ClassIDs">多筆班級記錄系統編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///       int DeleteCount = JHClass.Delete(ClassIDs);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>
        static public new int Delete(IEnumerable<string> ClassIDs)
        {
            return K12.Data.Class.Delete(ClassIDs);
        }
    }
}