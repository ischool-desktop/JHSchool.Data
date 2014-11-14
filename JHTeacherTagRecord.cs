
namespace JHSchool.Data
{
    /// <summary>
    /// 教師標籤資訊
    /// </summary>
    public class JHTeacherTagRecord:K12.Data.TeacherTagRecord 
    {
        /// <summary>
        /// 取得所屬教師
        /// </summary>
        public new JHTeacherRecord Teacher
        {
            get 
            {
                return !string.IsNullOrEmpty(RefEntityID)?JHSchool.Data.JHTeacher.SelectByID(RefEntityID):null;
            }
        }
    }
}