using System.Collections.Generic;
using System.Xml;

namespace JHSchool.Data
{
    /// <summary>
    /// 學期德行評量資訊
    /// </summary>
    public class JHMoralScoreRecord : K12.Data.MoralScoreRecord 
    {
        /// <summary>
        /// 所屬學生物件
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