
namespace JHSchool.Data
{
    /// <summary>
    /// 提供學校相關資訊。
    /// </summary>
    public class JHSchoolInfo : K12.Data.School
    {
        /// <summary>
        /// 取得學校英文地址。
        /// </summary>
        public static string EnglishAddress
        {
            get { return GetConfigurationString(ref SchoolConfig, "學校資訊", "EnglishAddress"); }
        }

        /// <summary>
        /// 取得校長中文名稱。
        /// </summary>
        public static string ChancellorChineseName
        {
            get { return GetConfigurationString(ref SchoolConfig, "學校資訊", "ChancellorChineseName"); }
        }

        /// <summary>
        /// 取得校長英文名稱。
        /// </summary>
        public static string ChancellorEnglishName
        {
            get { return GetConfigurationString(ref SchoolConfig, "學校資訊", "ChancellorEnglishName"); }
        }

        /// <summary>
        /// 取得教務主任名稱。
        /// </summary>
        public static string EduDirectorName
        {
            get { return GetConfigurationString(ref SchoolConfig, "學校資訊", "EduDirectorName"); }
        }

        /// <summary>
        /// 取得學務主任名稱。
        /// </summary>
        public static string StuDirectorName
        {
            get { return GetConfigurationString(ref SchoolConfig, "學校資訊", "StuDirectorName"); }
        }
    }
}
