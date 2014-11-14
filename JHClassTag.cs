using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 班級標籤類別，提供方法用來取得、新增、修改及刪除班級標籤資訊
    /// </summary>
    public class JHClassTag : K12.Data.ClassTag
    {
        /// <summary>
        /// 取得所有班級標籤列表。
        /// </summary>
        /// <returns>List&lt;JHClassTagRecord&gt;，代表多筆班級標籤物件。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHClassTagRecord&gt; records = JHClassTag.SelectAll();
        ///         
        ///         foreach(JHClassTagRecord record in records)
        ///             System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks></remarks>       
        [SelectMethod("JHSchool.JHClassTag.SelectAll", "學籍.班級類別")]
        public static new List<JHClassTagRecord> SelectAll()
        {
            return K12.Data.ClassTag.SelectAll<JHClassTagRecord>();
        }

        /// <summary>
        /// 根據單筆班級編號取得班級標籤列表。
        /// </summary>
        /// <param name="ClassID">班級編號</param>
        /// <returns>List&lt;JHClassTagRecord&gt;，代表多筆班級標籤物件。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHClassTagRecord&gt; records = JHClassTag.SelectByClassID(ClassID);
        ///         
        ///         foreach(JHClassTagRecord record in records)
        ///           System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        /// <remarks></remarks>
        public static new List<JHClassTagRecord> SelectByClassID(string ClassID)
        {
            return K12.Data.ClassTag.SelectByClassID<JHClassTagRecord>(ClassID);
        }

        /// <summary>
        /// 根據多筆班級編號取得班級標籤列表。
        /// </summary>
        /// <param name="ClassIDs">多筆班級編號</param>
        /// <returns>List&lt;JHClassTagRecord&gt;，代表多筆班級標籤物件。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHClassTagRecord&gt; records = JHClassTag.SelectByClassIDs(ClassIDs);
        ///     
        ///     forech(JHClassTagRecord record in records)
        ///         System.Console.WriteLine(record.Name);
        ///     </code>
        /// </example>
        public new static List<JHClassTagRecord> SelectByClassIDs(IEnumerable<string> ClassIDs)
        {
            return K12.Data.ClassTag.SelectByClassIDs<JHClassTagRecord>(ClassIDs);
        }

        /// <summary>
        /// 新增單筆班級標籤記錄
        /// </summary>
        /// <param name="ClassTagRecord">班級標籤記錄物件</param> 
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHClassTagRecord record = new JHClassTagRecord(ClassID, TagConfigID); 
        ///     string NewID = JHClassTag.Insert(record);  
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增傳入的參數為班級編號以及標籤編號。
        /// 2.回傳值為新增物件的系統編號。
        /// </remarks>        
        public static string Insert(JHClassTagRecord ClassTagRecord)
        {
            return K12.Data.ClassTag.Insert(ClassTagRecord);
        }

        /// <summary>
        /// 新增多筆班級標籤記錄
        /// </summary>
        /// <param name="ClassTagRecords">多筆班級記錄物件</param> 
        /// <returns>List&lt;string&gt;，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     JHClassTagRecord record = new JHClassTagRecord(ClassID, TagConfigID); 
        ///     List&lt;JHClassTagRecord&gt; records = new List&lt;JHClassTagRecord&gt;();
        ///     records.Add(record);
        ///     List&lt;string&gt; NewIDs = JHClassTag.Insert(records);  
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.新增傳入的參數為班級編號以及標籤編號。
        /// 2.回傳值為新增物件的系統編號。
        /// </remarks>
        public static List<string> Insert(IEnumerable<JHClassTagRecord> ClassTagRecords)
        {
            return K12.Data.ClassTag.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.ClassTagRecord, JHClassTagRecord>(ClassTagRecords));
        }

        /// <summary>
        /// 更新單筆班級標籤記錄
        /// </summary>
        /// <param name="ClassTagRecord">班級標籤記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHClassTagRecord&gt; records = JHClassTag.SelectByClassID(ClassID);        
        ///         records[0].RefEntityID = ClassID;
        ///         records[0].RefTagID = TagConfigID;
        ///         int UpdateCount = JHClassTag.Update(record[0]);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.更新的欄位值只有ClassID及TagConfigID，其它為唯讀欄位。
        /// 2.傳回值為成功更新的筆數。
        /// </remarks>
        public static int Update(JHClassTagRecord ClassTagRecord)
        {
            return K12.Data.ClassTag.Update(ClassTagRecord);
        }

        /// <summary>
        /// 更新多筆班級標籤記錄
        /// </summary>
        /// <param name="ClassTagRecords">多筆班級標籤記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHClassTagRecord&gt; records = JHClassTag.SelectByClassID(ClassID);
        ///         records[0].RefEntityID = ClassID;
        ///         records[0].RefTagID = TagConfigID;
        ///         int UpdateCount = JHClassTag.Update(records);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 1.更新的欄位值只有ClassID及TagConfigID，其它為唯讀欄位。
        /// 2.傳回值為成功更新的筆數。
        /// </remarks>
        public static int Update(IEnumerable<JHClassTagRecord> ClassTagRecords)
        {
            return K12.Data.ClassTag.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.ClassTagRecord, JHClassTagRecord>(ClassTagRecords));
        }

        /// <summary>
        /// 刪除多筆班級標籤記錄
        /// </summary>
        /// <param name="ClassTagRecords">多筆班級標籤記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHClassTagRecord&gt; records = JHClassTag.SelectByClassID(ClassID);
        ///         int DeleteCount = JHClassTag.Delete(records);
        ///     </code>
        /// </example>
        /// <remarks>
        /// 傳回值為成功刪除的筆數。
        /// </remarks>
        static public int Delete(IEnumerable<JHClassTagRecord> ClassTagRecords)
        {
            return K12.Data.ClassTag.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.ClassTagRecord, JHClassTagRecord>(ClassTagRecords));
        }

        /// <summary>
        /// 刪除單筆班級記錄
        /// </summary>
        /// <param name="ClassTagRecord">班級記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHClassTagRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///         List&lt;JHClassTagRecord&gt; records = JHClassTag.SelectByClassID(ClassID);
        ///         int DeleteCount = JHClassTag.Delete(records[0]);
        ///     </code>
        /// </example>
        /// <remarks>傳回值為成功刪除的筆數。</remarks>


        static public int Delete(JHClassTagRecord ClassTagRecord)
        {
            return K12.Data.ClassTag.Delete(ClassTagRecord);
        }
    }
}