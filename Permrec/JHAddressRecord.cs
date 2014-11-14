
namespace JHSchool.Data
{
    /// <summary>
    /// 學生地址資訊
    /// </summary>
    public class JHAddressRecord : K12.Data.AddressRecord
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