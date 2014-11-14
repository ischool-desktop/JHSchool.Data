
namespace JHSchool.Data
{
    /// <summary>
    /// 學生獎懲資訊
    /// </summary>
    public class JHDisciplineRecord:K12.Data.DisciplineRecord
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