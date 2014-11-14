using System;
using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 課程規劃類別，提供方法用來取得、新增、修改及刪除課程規劃資訊
    /// </summary>
    public class JHProgramPlan : K12.Data.ProgramPlan
    {
        /// <summary>
        /// 取得所有課程規劃明細列表。
        /// </summary>
        /// <returns></returns>
        [SelectMethod("JHProgramPlan.JHProgramPlan.SelectAllDetail", "成績.課程規劃")]
        public new static List<ProgramSubject> SelectAllDetail()
        {
            return K12.Data.ProgramPlan.SelectAllDetail();
        }

        /// <summary>
        /// 取得所有課程規劃列表。
        /// </summary>
        /// <returns>List&lt;JHProgramPlanRecord&gt;，代表多筆課程規劃記錄物件。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     <code>
        ///     List&lt;JHProgramPlanRecord&gt; records = ProgramPlan.SelectAll();
        ///     </code>
        /// </example>
        public static new List<JHProgramPlanRecord> SelectAll()
        {
            return K12.Data.ProgramPlan.SelectAll<JHProgramPlanRecord>();
        }

        /// <summary>
        /// 根據單筆課程規劃編號取得課程規劃物件。
        /// </summary>
        /// <param name="ProgramPalnID">課程規劃篇號</param>
        /// <returns>JHProgramPlanRecord</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        public static JHProgramPlanRecord SelectByID(string ProgramPalnID)
        {
            return K12.Data.ProgramPlan.SelectByID<JHProgramPlanRecord>(ProgramPalnID);
        }

        /// <summary>
        /// 根據多筆課程規劃編號取得課程規劃列表。
        /// </summary>
        /// <param name="ProgramPlanIDs">多筆課程規劃編號</param>
        /// <returns>List&lt;JHProgramPlanRecord&gt;，代表多筆課程規劃記錄物件。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     List&lt;JHProgramPlanRecord&gt; records = JHProgramPlan.SelectByIDs(ProgramPlanIDs);
        /// </example>
        public static new List<JHProgramPlanRecord> SelectByIDs(IEnumerable<string> ProgramPlanIDs)
        {
            return K12.Data.ProgramPlan.SelectByIDs<JHProgramPlanRecord>(ProgramPlanIDs);
        }

        /// <summary>
        /// 新增單筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanRecord">課程規劃記錄物件</param>
        /// <returns>string，傳回新增物件的系統編號。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        public static string Insert(JHProgramPlanRecord ProgramPlanRecord)
        {
            return K12.Data.ProgramPlan.Insert(ProgramPlanRecord);
        }

        /// <summary>
        /// 新增多筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanRecords">多筆課程規劃記錄物件</param> 
        /// <returns>List&lt;string&gt，傳回新增物件的系統編號列表。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static List<string> Insert(IEnumerable<JHProgramPlanRecord> ProgramPlanRecords)
        {
            return K12.Data.ProgramPlan.Insert(K12.Data.Utility.Utility.GetBaseList<K12.Data.ProgramPlanRecord,JHProgramPlanRecord>(ProgramPlanRecords));
        }

        /// <summary>
        /// 更新單筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanRecord">課程規劃記錄物件</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(JHProgramPlanRecord ProgramPlanRecord)
        {
            return K12.Data.ProgramPlan.Update(ProgramPlanRecord);
        }

        /// <summary>
        /// 更新多筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanRecords">多筆課程規劃記錄</param> 
        /// <returns>int，傳回成功更新的筆數。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        public static int Update(IEnumerable<JHProgramPlanRecord> ProgramPlanRecords)
        {
            return K12.Data.ProgramPlan.Update(K12.Data.Utility.Utility.GetBaseList<K12.Data.ProgramPlanRecord, JHProgramPlanRecord>(ProgramPlanRecords));
        }

        /// <summary>
        /// 刪除單筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanRecord">課程規劃記錄物件</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(JHProgramPlanRecord ProgramPlanRecord)
        {
            return K12.Data.ProgramPlan.Delete(ProgramPlanRecord);
        }

        /// <summary>
        /// 刪除單筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanID">課程規劃編號</param> 
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(string ProgramPlanID)
        {
            return K12.Data.ProgramPlan.Delete(ProgramPlanID);
        }

        /// <summary>
        /// 刪除多筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanRecords">多筆課程規劃記錄物件</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <seealso cref="JHProgramPlanRecord"/>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public int Delete(IEnumerable<JHProgramPlanRecord> ProgramPlanRecords)
        {
            return K12.Data.ProgramPlan.Delete(K12.Data.Utility.Utility.GetBaseList<K12.Data.ProgramPlanRecord, JHProgramPlanRecord>(ProgramPlanRecords));
        }

        /// <summary>
        /// 刪除多筆課程規劃記錄
        /// </summary>
        /// <param name="ProgramPlanIDs">多筆課程規劃編號</param>
        /// <returns>int，傳回成功刪除的筆數。</returns>
        /// <exception cref="Exception">
        /// </exception>
        /// <example>
        ///     
        /// </example>
        static public new int Delete(IEnumerable<string> ProgramPlanIDs)
        {
            return K12.Data.ProgramPlan.Delete(ProgramPlanIDs);
        }
    }
}