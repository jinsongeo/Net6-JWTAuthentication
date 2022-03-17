using System.Configuration;
using ConfigurationSection = System.Configuration.ConfigurationSection;

namespace WebAPI.Configurations.ConfigurationSections.Export
{
    public class ExportConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("service", IsRequired = true)]
        public ExportServiceSettingsConfigurationElement ExportServiceSettings
        {
            get { return (ExportServiceSettingsConfigurationElement)base["service"]; }
        }

        [ConfigurationProperty("pdfSettings", IsRequired = true)]
        public PdfSettingsConfigurationElement PdfSettings
        {
            get { return (PdfSettingsConfigurationElement)base["pdfSettings"]; }
        }
    }
}
