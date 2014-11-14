
namespace JHSchool.Data
{
    /// <summary>
    /// 家長及監護人資訊
    /// </summary>
    public class JHParentRecord : K12.Data.ParentRecord
    {
        /// <summary>
        /// 所屬學生記錄物件
        /// </summary>
        public new JHStudentRecord  Student 
        {
            get 
            {
                return !string.IsNullOrEmpty(RefStudentID)?JHSchool.Data.JHStudent.SelectByID(RefStudentID):null;
            }
        }
    }
}