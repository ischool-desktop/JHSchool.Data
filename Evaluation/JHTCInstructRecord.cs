
namespace JHSchool.Data
{
    /// <summary>
    /// 教師教授課程資訊
    /// </summary>
    public class JHTCInstructRecord : K12.Data.TCInstructRecord 
    {
        /// <summary>
        /// 所屬學生
        /// </summary>
        public new JHTeacherRecord Teacher
        { 
            get 
            { 
                return !string.IsNullOrEmpty(RefTeacherID)?JHSchool.Data.JHTeacher.SelectByID(RefTeacherID):null;
            }
        }
        /// <summary>
        /// 所屬課程
        /// </summary>
        public new JHCourseRecord Course 
        {
            get 
            {
                return !string.IsNullOrEmpty(RefCourseID)?JHSchool.Data.JHCourse.SelectByID(RefCourseID):null; 
            }
        }
    }
}