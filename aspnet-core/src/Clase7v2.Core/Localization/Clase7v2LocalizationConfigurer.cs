using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Clase7v2.Localization
{
    public static class Clase7v2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Clase7v2Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Clase7v2LocalizationConfigurer).GetAssembly(),
                        "Clase7v2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
