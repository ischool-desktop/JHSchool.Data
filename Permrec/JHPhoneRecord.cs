
namespace JHSchool.Data
{
    /// <summary>
    /// 學生電話資訊
    /// </summary>
    public class JHPhoneRecord : K12.Data.PhoneRecord
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