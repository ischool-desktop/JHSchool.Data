using System.Xml;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生期中成績資訊
    /// </summary>
    public class JHSCETakeRecord:SCETakeRecord
    {
        /// <summary>
        /// 努力程度
        /// </summary>
        [Field(Caption = "努力程度", EntityName = "SCETake", EntityCaption = "評量成績")]
        public int? Effort
        {
            get
            {
                return K12.Data.Int.ParseAllowNull(Extension.SelectSingleNode("Effort").InnerText);
            }
            set
            {
                Extension.SelectSingleNode("Effort").InnerText = K12.Data.Int.GetString(value);
            }
        }

        /// <summary>
        /// 成績
        /// </summary>
        [Field(Caption = "成績", EntityName = "SCETake", EntityCaption = "評量成績")]
        public new decimal? Score
        {
            get
            {
                return K12.Data.Decimal.ParseAllowNull(Extension.SelectSingleNode("Score").InnerText);
            }
            set
            {
                Extension.SelectSingleNode("Score").InnerText = K12.Data.Decimal.GetString(value);
            }
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
        /// 所屬學生修課
        /// </summary>
        public new JHSCAttendRecord SCAttend
        {
            get 
            {
                return !string.IsNullOrEmpty(RefSCAttendID)?JHSchool.Data.JHSCAttend.SelectByID(RefSCAttendID):null; 
            }
        }
        /// <summary>
        /// 所屬試別設定
        /// </summary>
        public new JHExamRecord Exam
        {
            get 
            {
                return !string.IsNullOrEmpty(RefExamID)?JHSchool.Data.JHExam.SelectByID(RefExamID):null;
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

        /// <summary>
        /// 從XML參數載入設定值
        /// </summary>
        /// <param name="element"></param>
        public override void Load(XmlElement element)
        {
            base.Load(element);

            if (base.Extension.SelectSingleNode("Score") == null)
                base.Extension.AppendChild(base.Extension.OwnerDocument.CreateElement("Score"));

            if (base.Extension.SelectSingleNode("Effort") == null)
                base.Extension.AppendChild(base.Extension.OwnerDocument.CreateElement("Effort"));
        }

        /// <summary>
        /// 從XML字串參數載入設定值
        /// </summary>
        /// <param name="data"></param>
        public override void Load(string data)
        {
            #region 使用XMLDocument的方式來解析
            XmlDocument xmldoc = new XmlDocument();

            xmldoc.LoadXml(data);
            #endregion

            Load(xmldoc.DocumentElement);
        }
    }
}