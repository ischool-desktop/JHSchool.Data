using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 課程資訊
    /// </summary>
    public class JHCourseRecord : K12.Data.CourseRecord
    {
        /// <summary>
        /// 所屬班級
        /// </summary>
        public new JHClassRecord Class 
        {
            get 
            {
                return !string.IsNullOrEmpty(RefClassID)?JHSchool.Data.JHClass.SelectByID(RefClassID):null;
            }
        }
        /// <summary>
        /// 所屬試別設定
        /// </summary>
        public new JHAssessmentSetupRecord AssessmentSetup 
        { 
            get
            {
                return !string.IsNullOrEmpty(RefAssessmentSetupID)?JHSchool.Data.JHAssessmentSetup.SelectByID(RefAssessmentSetupID):null;
            }
        }
        /// <summary>
        /// 領域
        /// </summary>
        [Field(Caption = "領域", EntityName = "Course", EntityCaption = "課程")]
        public new string Domain
        {
            get { return base.Domain; }
            set { base.Domain = value; }
        }
        /// <summary>
        /// 是否列入學期成績計算，1:列入學期成績，2:不列入學期成績。
        /// </summary>
        [Field(Caption = "列入計算", EntityName = "Course", EntityCaption = "課程", Remark = "是否列入學期成績計算，1:列入學期成績，2:不列入學期成績。")]
        public new string CalculationFlag 
        {
            get { return base.CalculationFlag; }
            set { base.CalculationFlag = value; }
        }
    }
}