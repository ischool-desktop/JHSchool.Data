
namespace JHSchool.Data
{
    /// <summary>
    /// 學生懲戒資訊
    /// </summary>
    public class JHDemeritRecord : K12.Data.DemeritRecord
    {
        /// <summary>
        /// 所屬學生
        /// </summary>
        public new JHStudentRecord Student
        {
            get
            {
                return !string.IsNullOrEmpty(RefStudentID)?JHSchool.Data.JHStudent.SelectByID(RefStudentID):null;
            }
        }
    }
}