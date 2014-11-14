
namespace JHSchool.Data
{
    /// <summary>
    /// 學生標籤資訊
    /// </summary>
    public class JHStudentTagRecord:K12.Data.StudentTagRecord 
    {
        /// <summary>
        /// 取得所屬學生
        /// </summary>
        public new JHStudentRecord Student 
        {
            get
            {
                return !string.IsNullOrEmpty(RefEntityID)?JHSchool.Data.JHStudent.SelectByID(RefEntityID):null;
            }
        }
    }
}