using System.Configuration;

namespace WebAPI.Configurations.ConfigurationSections.Export
{
    public class PdfSettingsConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("secretKey", IsRequired = true)]
        public string SecretKey => (string)base["secretKey"];

        [ConfigurationProperty("authExpirationInMinutes", IsRequired = true)]
        public int AuthExpirationInMinutes => (int)base["authExpirationInMinutes"];

        [ConfigurationProperty("surveyConversionDelay", IsRequired = false, DefaultValue = 0)]
        public int SurveyConversionDelay => (int)base["surveyConversionDelay"];

        [ConfigurationProperty("surveyNavigationTimeout", IsRequired = false, DefaultValue = 110)]
        public int SurveyNavigationTimeout => (int)base["surveyNavigationTimeout"];

        [ConfigurationProperty("reportConversionDelay", IsRequired = false, DefaultValue = 0)]
        public int ReportConversionDelay => (int)base["reportConversionDelay"];

        [ConfigurationProperty("reportNavigationTimeout", IsRequired = false, DefaultValue = 420)]
        public int ReportNavigationTimeout => (int)base["reportNavigationTimeout"];
    }
}
