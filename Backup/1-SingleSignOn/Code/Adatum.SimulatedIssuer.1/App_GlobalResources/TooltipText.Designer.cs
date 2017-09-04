//===============================================================================
// Microsoft patterns & practices
// Cliams Identity Guide V2
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://claimsid.codeplex.com/license)
//===============================================================================


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "10.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TooltipText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TooltipText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.TooltipText", global::System.Reflection.Assembly.Load("App_GlobalResources"));
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hint: Adatum issuer will act as an identity provider..
        /// </summary>
        internal static string AdatumAsFederationProvider {
            get {
                return ResourceManager.GetString("AdatumAsFederationProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hint: Adatum issuer will act as a federation provider..
        /// </summary>
        internal static string AdatumAsIdentityProvider {
            get {
                return ResourceManager.GetString("AdatumAsIdentityProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hint: This is a simulated issuer for demonstration. In a real scenario, you would use a production quality issuer such as ADFS v2 that would be configured with Windows Integrated Authentication. The underlying protocols will be the same..
        /// </summary>
        internal static string SameAsAdfsHint {
            get {
                return ResourceManager.GetString("SameAsAdfsHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hint: This web page is &apos;simulating&apos; a Windows integrated authentication environment. We don&apos;t want to force you to create new users on your AD or local users and groups to experiment different logins..
        /// </summary>
        internal static string SimulatingWindowsAuthHint {
            get {
                return ResourceManager.GetString("SimulatingWindowsAuthHint", resourceCulture);
            }
        }
    }
}