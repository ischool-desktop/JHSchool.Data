
namespace JHSchool.Data
{
    /// <summary>
    /// 課程標籤資訊
    /// </summary>
    public class JHCourseTagRecord:K12.Data.CourseTagRecord
    {
        /// <summary>
        /// 取得所屬課程
        /// </summary>
        public new JHCourseRecord Course 
        { 
            get
            { 
                return !string.IsNullOrEmpty(RefEntityID)?JHSchool.Data.JHCourse.SelectByID(RefEntityID):null;
            }
        }        
    }
}