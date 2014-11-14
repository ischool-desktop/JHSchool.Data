
namespace JHSchool.Data
{
    /// <summary>
    /// 學生離校資訊
    /// </summary>
    public class JHLeaveInfoRecord : K12.Data.LeaveInfoRecord
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