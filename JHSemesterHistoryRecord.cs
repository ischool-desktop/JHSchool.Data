
namespace JHSchool.Data
{
    /// <summary>
    /// 學生學期歷程資訊
    /// </summary>
    public class JHSemesterHistoryRecord:K12.Data.SemesterHistoryRecord
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