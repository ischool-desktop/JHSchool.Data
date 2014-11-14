using System;
using System.Xml;
using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 評量設定資訊
    /// </summary>
    public class JHAssessmentSetupRecord:K12.Data.AssessmentSetupRecord 
    {
        /// <summary>
        /// 平時評量開始時間
        /// </summary>
        [Field(Caption = "平時評量開始時間", EntityName = "AssessmentSetup", EntityCaption = "評量設定")]
        public DateTime? OrdinarilyStartTime 
        {
            get
            {
                return K12.Data.DateTimeHelper.Parse(Extension.SelectSingleNode("OrdinarilyStartTime").InnerText);
            }
            set
            {
                //Extension.SelectSingleNode("OrdinarilyStartTime").InnerText = K12.Data.DateTimeHelper.ToDisplayString(value);
                // yyyy/MM/dd HH:mm
                Extension.SelectSingleNode("OrdinarilyStartTime").InnerText = value.HasValue ? value.Value.ToString("yyyy/MM/dd HH:mm") : string.Empty;
            }
        }

        /// <summary>
        /// 平時評量結束時間
        /// </summary>
        [Field(Caption = "平時評量結束時間", EntityName = "AssessmentSetup", EntityCaption = "評量設定")]
        public DateTime? OrdinarilyEndTime 
        {
            get
            {
                return K12.Data.DateTimeHelper.Parse(Extension.SelectSingleNode("OrdinarilyEndTime").InnerText);
            }
            set
            {
                //Extension.SelectSingleNode("OrdinarilyEndTime").InnerText = K12.Data.DateTimeHelper.ToDisplayString(value);
                // yyyy/MM/dd HH:mm
                Extension.SelectSingleNode("OrdinarilyEndTime").InnerText = value.HasValue ? value.Value.ToString("yyyy/MM/dd HH:mm") : string.Empty;
            }
        }

        /// <summary>
        /// 文用評量開始時間
        /// </summary>
        [Field(Caption = "文字評量開始時間", EntityName = "AssessmentSetup", EntityCaption = "評量設定")]
        public DateTime? TextStartTime
        {
            get
            {
                return K12.Data.DateTimeHelper.Parse(Extension.SelectSingleNode("TextStartTime").InnerText);
            }
            set
            {
                // yyyy/MM/dd HH:mm
                //Extension.SelectSingleNode("TextStartTime").InnerText = K12.Data.DateTimeHelper.ToDisplayString(value);  
                Extension.SelectSingleNode("TextStartTime").InnerText = value.HasValue ? value.Value.ToString("yyyy/MM/dd HH:mm") : string.Empty;
            }
        }

        /// <summary>
        /// 文字評量結束時間
        /// </summary>
        [Field(Caption = "文字評量結束時間", EntityName = "AssessmentSetup", EntityCaption = "評量設定")]
        public DateTime? TextEndTime
        {
            get
            {
                return K12.Data.DateTimeHelper.Parse(Extension.SelectSingleNode("TextEndTime").InnerText);
            }
            set
            {
                // yyyy/MM/dd HH:mm
                //Extension.SelectSingleNode("TextEndTime").InnerText = K12.Data.DateTimeHelper.ToDisplayString(value);  
                Extension.SelectSingleNode("TextEndTime").InnerText = value.HasValue ? value.Value.ToString("yyyy/MM/dd HH:mm") : string.Empty;
            }
        }

        /// <summary>
        /// 從XML參數載入設定值
        /// </summary>
        /// <param name="element"></param>
        public override void Load(XmlElement element)
        {
            base.Load(element);

            if (base.Extension == null)
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml("<Extension/>");
                base.Extension = xmldoc.DocumentElement;
            }

            if (base.Extension.SelectSingleNode("OrdinarilyStartTime") == null)
                base.Extension.AppendChild(base.Extension.OwnerDocument.CreateElement("OrdinarilyStartTime"));

            if (base.Extension.SelectSingleNode("OrdinarilyEndTime") == null)
                base.Extension.AppendChild(base.Extension.OwnerDocument.CreateElement("OrdinarilyEndTime"));

            if (base.Extension.SelectSingleNode("TextStartTime") == null)
                base.Extension.AppendChild(base.Extension.OwnerDocument.CreateElement("TextStartTime"));

            if (base.Extension.SelectSingleNode("TextEndTime") == null)
                base.Extension.AppendChild(base.Extension.OwnerDocument.CreateElement("TextEndTime"));
        }
    }
}