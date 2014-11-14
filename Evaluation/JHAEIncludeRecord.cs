using System.Xml;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 評分樣板資訊
    /// </summary>
    public class JHAEIncludeRecord : AEIncludeRecord
    {
        [Field(Caption = "是否有成績", EntityName = "AEInclude", EntityCaption = "評分樣板")]
        public bool UseScore
        {
            get
            {
                return (base.Extension.SelectSingleNode("UseScore").InnerText.Equals("是")) ? true : false;
            }
            set
            {
                base.Extension.SelectSingleNode("UseScore").InnerText = (value == true ? "是" : "否");
            }
        }


        /// <summary>
        /// 是否有努力程度
        /// </summary>
        [Field(Caption = "是否有努力程度", EntityName = "AEInclude", EntityCaption = "評分樣板")]
        public bool UseEffort
        {
            get
            {
                return (base.Extension.SelectSingleNode("UseEffort").InnerText.Equals("是")) ? true : false;
            }
            set
            {
                base.Extension.SelectSingleNode("UseEffort").InnerText = (value == true ? "是" : "否");
            }
        }

        /// <summary>
        /// 是否有文字評量
        /// </summary>
        [Field(Caption = "是否有文字評量", EntityName = "AEInclude", EntityCaption = "評分樣板")]
        public bool UseText
        {
            get
            {
                return (base.Extension.SelectSingleNode("UseText").InnerText.Equals("是")) ? true : false;
            }
            set
            {
                base.Extension.SelectSingleNode("UseText").InnerText = (value == true ? "是" : "否");
            }
        }

        /// <summary>
        /// 試別樣版記錄物件
        /// </summary>
        public new  JHAssessmentSetupRecord AssessmentSetup 
        {
            get
            {
                return !string.IsNullOrEmpty(RefAssessmentSetupID)?JHSchool.Data.JHAssessmentSetup.SelectByID(RefAssessmentSetupID):null;
            }
        }
        /// <summary>
        /// 試別項目記錄物件
        /// </summary>
        public new JHExamRecord Exam 
        {
            get
            {
                return !string.IsNullOrEmpty(RefExamID)?JHSchool.Data.JHExam.SelectByID(RefExamID):null;
            } 
        }

        public JHAEIncludeRecord():base()
        {
            //初始化會將K12的OpenTeacherAccess屬性設為true，讓TeacherAccess永遠開放。
            //國中只使用StartTime及EndTime來控制TeacherAccess的時間，若是將TeacherAccess設為false則會無法使用TeacherAccess。
            base.OpenTeacherAccess = true;

            //此屬性只在高中用到，而國中是在Extension當中使用，所以高中都設為true。
            base.UseScore = true;
            base.UseText = true;
        }

        public override void Load(XmlElement element)
        {
            base.Load(element);

            if (base.Extension.SelectSingleNode("UseScore") == null)
            {

                XmlElement ElmUseScore = base.Extension.OwnerDocument.CreateElement("UseScore");

                ElmUseScore.InnerText = "否";

                base.Extension.AppendChild(ElmUseScore);
            }

            if (base.Extension.SelectSingleNode("UseText") == null)
            {
                XmlElement ElmUseText = base.Extension.OwnerDocument.CreateElement("UseText");

                ElmUseText.InnerText = "否";

                base.Extension.AppendChild(ElmUseText);
            }

            if (base.Extension.SelectSingleNode("UseEffort") == null)
            {
                XmlElement ElmUseEffort = base.Extension.OwnerDocument.CreateElement("Effort");
                
                ElmUseEffort.InnerText = "否";

                base.Extension.AppendChild(ElmUseEffort);
            }
        }

    }
}