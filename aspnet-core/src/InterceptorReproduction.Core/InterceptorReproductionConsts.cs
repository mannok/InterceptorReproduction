using InterceptorReproduction.Debugging;

namespace InterceptorReproduction
{
    public class InterceptorReproductionConsts
    {
        public const string LocalizationSourceName = "InterceptorReproduction";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1c8f0beb41834966973bf92e89a00666";
    }
}
