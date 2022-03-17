using System.Configuration;

namespace WebAPI.Configurations.ConfigurationSections.Export
{
    public class ExportServiceSettingsConfigurationElement : ConfigurationElement
    {
        [ConfigurationProperty("concurrentExportProcessLimit", IsRequired = false, DefaultValue = 100)]
        public int ConcurrentExportProcessLimit => (int)base["concurrentExportProcessLimit"];

        [ConfigurationProperty("requestLifetimeInHours", IsRequired = false, DefaultValue = 3)]
        public int RequestLifetimeInHours => (int)base["requestLifetimeInHours"];       
    }
}
