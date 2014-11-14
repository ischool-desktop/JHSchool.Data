
namespace JHSchool.Data
{
    /// <summary>
    /// 入學前資訊
    /// 詳細規格：https://docs.google.com/a/ischool.com.tw/View?id=dcw7gq95_29ff6fpfhd
    /// </summary>
    public class JHBeforeEnrollmentRecord : K12.Data.BeforeEnrollmentRecord 
    {
        /// <summary>
        /// 所屬學生記錄物件
        /// </summary>
        public new JHStudentRecord Student
        {
            get
            {
                if (!string.IsNullOrEmpty(RefStudentID))
                    return JHStudent.SelectByID(RefStudentID);
                else
                    return null;
            }
        }
    }
}