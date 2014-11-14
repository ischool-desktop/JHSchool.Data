using System.Collections.Generic;

namespace JHSchool.Data
{
    /// <summary>
    /// 班級資訊
    /// </summary>
    public class JHClassRecord : K12.Data.ClassRecord
    {
        /// <summary>
        /// 班導師
        /// </summary>
        public new JHTeacherRecord Teacher
        {
            get
            {
                return !string.IsNullOrEmpty(RefTeacherID)?JHSchool.Data.JHTeacher.SelectByID(RefTeacherID):null;
            }
        }

        /// <summary>
        /// 所屬課程規劃
        /// </summary>
        public new JHProgramPlanRecord ProgramPlan
        {
            get
            {
                return !string.IsNullOrEmpty(RefProgramPlanID)?JHSchool.Data.JHProgramPlan.SelectByID(RefProgramPlanID):null;
            }
        }

        /// <summary>
        /// 所屬成績計算規則
        /// </summary>
        public new JHScoreCalcRuleRecord ScoreCalcRule
        {
            get 
            {
                return !string.IsNullOrEmpty(RefScoreCalcRuleID)?JHSchool.Data.JHScoreCalcRule.SelectByID(RefScoreCalcRuleID):null;
            }
        }

        /// <summary>
        /// 取得班級學生
        /// </summary>
        public new List<JHStudentRecord> Students
        {
            get 
            {
                return !string.IsNullOrEmpty(this.ID)?JHStudent.SelectByClassID(this.ID):new List<JHStudentRecord>(); 
            }
        }
    }
}