
namespace JHSchool.Data
{
    /// <summary>
    /// 學生獎勵資訊
    /// </summary>
    public class JHMeritRecord : K12.Data.MeritRecord
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