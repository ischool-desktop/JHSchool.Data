using System.Xml;
using System.Collections.Generic;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生缺曠資訊
    /// </summary>
    public class JHAttendanceRecord : K12.Data.AttendanceRecord
    {
        //public JHAttendanceRecord():base()
        //{
        //    PeriodDetail = new List<JHAttendancePeriod>();
        //}

        //public override void Load(XmlElement data)
        //{
        //    base.Load(data);

        //    PeriodDetail = new List<JHAttendancePeriod>();

        //    foreach (XmlElement each in data.SelectNodes("Detail/Attendance/Period"))
        //    {
        //        PeriodDetail.Add(new JHAttendancePeriod(each));
        //    }
        //}


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

        ///// <summary>
        ///// 學生缺曠記錄詳細內容，以節為單位記錄缺曠資訊
        ///// </summary>
        //public new List<JHAttendancePeriod> PeriodDetail { get; set; }        //記錄內容
    }

    //<Period AbsenceType="病假1" AttendanceType="一般">二</Period>
    //<Period AbsenceType="病假1" AttendanceType="一般">三</Period>

    ///// <summary>
    ///// 學生缺曠記錄詳細內容，以節為單位記錄缺曠資訊
    ///// </summary>
    //public class JHAttendancePeriod:K12.Data.AttendancePeriod
    //{
    //    public JHAttendancePeriod():base()
    //    {
    //    }

    //    public JHAttendancePeriod(XmlElement element):base(element)
    //    {
    //    }
    //}
}