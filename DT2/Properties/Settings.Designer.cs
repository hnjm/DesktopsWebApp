﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DT2.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G379F22wYG_ISyG4Y-0saikSyUQNf9hVozwcep-LqsGNRvSBx81bN-mZ1bDyckMYNItYypIfzjU-MlFrS" +
            "5IEIw")]
        public string CloudStackSecretKey {
            get {
                return ((string)(this["CloudStackSecretKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NTbOqdGSM2KWzS0GIMO9fBO6TiKb2oEKo59t7hmPWNna4rQtftX3sarCO-sAMXfL8l3zm55mND__53bV-" +
            "wyZrA")]
        public string CloudStackApiKey {
            get {
                return ((string)(this["CloudStackApiKey"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XenServer")]
        public string CloudStackHypervisor {
            get {
                return ((string)(this["CloudStackHypervisor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xdc1.clouddesktop.cambourne.cloud.com:80")]
        public string XenDesktopAdminAddress {
            get {
                return ((string)(this["XenDesktopAdminAddress"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CloudPlatformHost")]
        public string XenDesktopHostingUnitName {
            get {
                return ((string)(this["XenDesktopHostingUnitName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("clouddesktop.cambourne.cloud.com")]
        public string XenDesktopDomain {
            get {
                return ((string)(this["XenDesktopDomain"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("xdc1.clouddesktop.cambourne.cloud.com")]
        public string XenDesktopDDC {
            get {
                return ((string)(this["XenDesktopDDC"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Zone1")]
        public string XenDesktopAvailabilityZone {
            get {
                return ((string)(this["XenDesktopAvailabilityZone"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2d1fe3c7-33bd-4e02-94a9-55ba34321942")]
        public string CloudStackZoneId {
            get {
                return ((string)(this["CloudStackZoneId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TestDisableCatalogCreate {
            get {
                return ((bool)(this["TestDisableCatalogCreate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://192.168.0.50/Citrix/StoreWeb/")]
        public string XenDesktopStoreFrontUrl {
            get {
                return ((string)(this["XenDesktopStoreFrontUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://192.168.2.1:8080/client/api")]
        public string CloudStackUrl {
            get {
                return ((string)(this["CloudStackUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LDAP://CN=users,DC=clouddesktop,DC=cambourne,DC=cloud,DC=com")]
        public string LdapPath {
            get {
                return ((string)(this["LdapPath"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SecurityGroups {
            get {
                return ((string)(this["SecurityGroups"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\administrator.CLOUDDESKTOP\\Documents\\GitHub\\CloudDesktop\\DT2\\Utils")]
        public string PowerShellScriptsFolder {
            get {
                return ((string)(this["PowerShellScriptsFolder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool CheckUserForCreatePrivileges {
            get {
                return ((bool)(this["CheckUserForCreatePrivileges"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("executable")]
        public string templatefilter {
            get {
                return ((string)(this["templatefilter"]));
            }
        }
    }
}