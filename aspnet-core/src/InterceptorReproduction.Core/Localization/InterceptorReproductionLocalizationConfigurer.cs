using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace InterceptorReproduction.Localization
{
    public static class InterceptorReproductionLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(InterceptorReproductionConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(InterceptorReproductionLocalizationConfigurer).GetAssembly(),
                        "InterceptorReproduction.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
