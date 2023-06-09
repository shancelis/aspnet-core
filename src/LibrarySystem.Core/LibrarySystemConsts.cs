﻿using LibrarySystem.Debugging;

namespace LibrarySystem
{
    public class LibrarySystemConsts
    {
        public const string LocalizationSourceName = "LibrarySystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "6edad602587f42aa8301cbaeff7be3ad";
    }
}
