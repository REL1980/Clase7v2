using Clase7v2.Debugging;

namespace Clase7v2
{
    public class Clase7v2Consts
    {
        public const string LocalizationSourceName = "Clase7v2";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5642c1688b7a4ca2850f7e11ce89d082";
    }
}
