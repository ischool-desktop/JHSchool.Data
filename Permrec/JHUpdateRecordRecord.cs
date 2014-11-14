using K12.Data;

namespace JHSchool.Data
{
    /// <summary>
    /// 學生異動記錄資訊
    /// </summary>
    public class JHUpdateRecordRecord:K12.Data.UpdateRecordRecord 
    {
        /// <summary>
        /// 所屬學生
        /// </summary>
        public new JHStudentRecord Student
        {
            get
            {
                return !string.IsNullOrEmpty(StudentID) ? JHSchool.Data.JHStudent.SelectByID(StudentID) : null;
            }
        }

        /// <summary>
        /// 地址，一般是從學生（StudentRecord、AddressRecord）複製過來的地址
        /// </summary>
        [Field(Caption = "地址", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "一般是從學生複製過來的地址。")]
        public string OriginAddress
        {
            get
            {
                return base.Attributes["OriginAddress"];
            }
            set
            {
                base.Attributes["OriginAddress"] = value;
            }
        }

        /// <summary>
        /// 班級名稱，一般是從學生（StudentRecord）身上複製過來的班級名稱
        /// </summary>
        [Field(Caption = "班級名稱", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "一般是從學生所屬班級複製過來的班級名稱。")]
        public string OriginClassName
        {
            get 
            {
                return base.Attributes["OriginClassName"];
            }
            set 
            {
                base.Attributes["OriginClassName"] = value;
            }
        }

        /// <summary>
        /// 座號，一般是從學生（StudentRecord）身上複製過來的座號
        /// </summary>
        [Field(Caption = "座號", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "一般是從學生複製過來的座號。")]
        public string SeatNo
        {
            get
            {
                return base.Attributes["SeatNo"];
            }
            set
            {
                base.Attributes["SeatNo"] = value;
            }
        }

        /// <summary>
        /// 異動後的身份證字號
        /// </summary>
        [Field(Caption = "新身份證字號", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "異動後的身份證字號。")]
        public string NewIDNumber
        {
            get
            {
                return base.Attributes["NewIDNumber"];
            }
            set
            {
                base.Attributes["NewIDNumber"]=value;
            }
        }

        /// <summary>
        /// 異動後的姓名
        /// </summary>
        [Field(Caption = "新姓名", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "異動後的姓名。")]
        public string NewName
        {
            get
            {
                return base.Attributes["NewName"];
            }
            set
            {
                base.Attributes["NewName"]=value;
            }
        }

        /// <summary>
        /// 異動後的生日
        /// </summary>
        [Field(Caption = "新生日", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "異動後的生日。")]
        public string NewBirthday
        {
            get
            {
                return base.Attributes["NewBirthday"];
            }
            set
            {
                base.Attributes["NewBirthday"]=value;
            }
        }

        /// <summary>
        /// 異動後的性別
        /// </summary>
        [Field(Caption = "新性別", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "異動後的性別。")]
        public string NewGender
        {
            get
            {
                return base.Attributes["NewGender"];
            }
            set
            {
                base.Attributes["NewGender"]=value;
            }
        }

        /// <summary>
        /// 畢業國小
        /// </summary>
        [Field(Caption = "畢業國小", EntityName = "UpdateRecord", EntityCaption = "異動")]
        public string GraduateSchool
        {
            get
            {
                return base.Attributes["GraduateSchool"];
            }
            set
            {
                base.Attributes["GraduateSchool"] = value;
            }

        }

        /// <summary>
        /// 入學年月
        /// </summary>
        [Field(Caption = "入學年月", EntityName = "UpdateRecord", EntityCaption = "異動")]
        public string EnrollmentSchoolYear
        {
            get 
            {
                return base.Attributes["EnrollmentSchoolYear"];
            }
            set
            {
                base.Attributes["EnrollmentSchoolYear"] = value;
            }
        }

        /// <summary>
        /// 畢業證書字號
        /// </summary>
        [Field(Caption = "畢業證書字號", EntityName = "UpdateRecord", EntityCaption = "異動")]
        public string GraduateCertificateNumber
        {
            get 
            {
                return base.Attributes["GraduateCertificateNumber"];
            }
            set
            {
                base.Attributes["GraduateCertificateNumber"]=value;
            }
        }

        /// <summary>
        /// 畢業年月
        /// </summary>
        [Field(Caption = "畢業年月", EntityName = "UpdateRecord", EntityCaption = "異動")]
	    public string GraduateSchoolYear
        {
            get
            {
                return base.Attributes["GraduateSchoolYear"];
            }
            set
            {
                base.Attributes["GraduateSchoolYear"] = value;
            }
        }

        /// <summary>
        /// 出生地
        /// </summary>
        [Field(Caption = "出生地", EntityName = "UpdateRecord", EntityCaption = "異動")]
        public string BirthPlace
        {
            get 
            {
                return base.Attributes["BirthPlace"];
            }
            set
            {
                base.Attributes["BirthPlace"]=value;
            }
        }

        
	    /// <summary>
        /// 畢修業別，分為畢業及修業。
	    /// </summary>
        [Field(Caption = "畢修業別", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "畢業或修業")]
        public string Graduate
        {
            get 
            {
                return base.Attributes["Graduate"];
            }
            set
            {
                base.Attributes["Graduate"]=value;
            }
        }

        /// <summary>
        /// 轉出入學校，轉入或轉出學校。
        /// </summary>
        [Field(Caption = "轉出入學校", EntityName = "UpdateRecord", EntityCaption = "異動", Remark = "轉入或轉出學校")]
	    public string ImportExportSchool
        {
            get 
            {
                return base.Attributes["ImportExportSchool"];
            }
            set
            {
                base.Attributes["ImportExportSchool"]=value;
            }
        }
    }
}