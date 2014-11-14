using System.Collections.Generic;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生學期成績資訊
    /// </summary>
    public class JHSemesterScoreRecord:SemesterScoreRecord
    {
        /// <summary>
        /// 學期學習領域成績，由ischool介面所計算
        /// </summary>
        [Field(Caption = "學習領域成績", EntityName = "SemesterScoreRecord", EntityCaption = "學習成績")]
        public new decimal? LearnDomainScore 
        {
            get { return base.LearnDomainScore; }
            set { base.LearnDomainScore = value; }
        }

        /// <summary>
        /// 學期領域成績明細
        /// </summary>
        public new Dictionary<string, K12.Data.DomainScore> Domains
        {
            get { return base.Domains;}
            set { base.Domains = value; }
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
    }
}