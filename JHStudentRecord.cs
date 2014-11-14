
namespace JHSchool.Data
{
    /// <summary>
    /// 學生資訊
    /// </summary>
    public class JHStudentRecord : K12.Data.StudentRecord
    {
        /// <summary>
        /// 覆蓋後的課程規劃
        /// </summary>
        public new JHProgramPlanRecord OverrideProgramPlan
        {
            get 
            { 
                return !string.IsNullOrEmpty(OverrideProgramPlanID)?JHSchool.Data.JHProgramPlan.SelectByID(OverrideProgramPlanID):null; 
            }
        }

        /// <summary>
        /// 自動判斷所屬課程規劃，若是學生身上有課程規劃，則用學生的，否則取得班級的課程規劃
        /// </summary>
        public new JHProgramPlanRecord ProgramPlan
        {
            get
            {
                if (!string.IsNullOrEmpty(OverrideProgramPlanID))
                    return OverrideProgramPlan;
                else
                    return Class!=null?Class.ProgramPlan:null;
            }
        }
        /// <summary>
        /// 覆蓋後的成績計算規則
        /// </summary>
        public new JHScoreCalcRuleRecord OverrideScoreCalcRule { get { return JHSchool.Data.JHScoreCalcRule.SelectByID(OverrideScoreCalcRuleID); } }
        /// <summary>
        /// 自動判斷所屬成績計算規則，若是學生身上有成績計算規則，則用學生的，否則取得班級的課程規劃
        /// </summary>
        public new JHScoreCalcRuleRecord ScoreCalcRule
        {
            get
            {
                if (!string.IsNullOrEmpty(OverrideScoreCalcRuleID))
                    return OverrideScoreCalcRule;
                else
                    return Class!=null?Class.ScoreCalcRule:null;
            }
        }
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
    }
}