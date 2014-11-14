using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生修課資訊
    /// </summary>
    public class JHSCAttendRecord:SCAttendRecord
    {
        /// <summary>
        /// 修課努力程度
        /// </summary>
        [Field(Caption = "努力程度", EntityName = "SCAttend", EntityCaption = "學生修課")]
        public new int? Effort 
        {
            get { return base.Effort; }
            set { base.Effort = value; }
        }
        /// <summary>
        /// 修課文字描述
        /// </summary>
        [Field(Caption = "文字描述", EntityName = "SCAttend", EntityCaption = "學生修課")]
        public new string Text 
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        /// <summary>
        /// 平時評量努力程度
        /// </summary>
        [Field(Caption = "平時評量努力程度", EntityName = "SCAttend", EntityCaption = "學生修課")]
        public new int? OrdinarilyEffort
        {
            get { return base.OrdinarilyEffort; }
            set { base.OrdinarilyEffort = value; }
        }
        /// <summary>
        /// 平時評量分數
        /// </summary>
        [Field(Caption = "平時評量分數", EntityName = "SCAttend", EntityCaption = "學生修課")]
        public new decimal? OrdinarilyScore
        {
            get { return base.OrdinarilyScore; }
            set { base.OrdinarilyScore = value; }
        }

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