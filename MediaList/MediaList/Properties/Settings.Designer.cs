﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaList.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// The list of folder paths that contain Movies.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The list of folder paths that contain Movies.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection MovieFolders {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["MovieFolders"]));
            }
            set {
                this["MovieFolders"] = value;
            }
        }
        
        /// <summary>
        /// The list of folder paths that contain TV show folders.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The list of folder paths that contain TV show folders.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection TVFolders {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TVFolders"]));
            }
            set {
                this["TVFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection ExcludedFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ExcludedFiles"]));
            }
            set {
                this["ExcludedFiles"] = value;
            }
        }
    }
}
