﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceGraph.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FaceGraph.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 117823528389237.
        /// </summary>
        internal static string APP_ID {
            get {
                return ResourceManager.GetString("APP_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 8b9edb6efb0d8cbc52c5f14fdf329d27.
        /// </summary>
        internal static string APP_SECRET {
            get {
                return ResourceManager.GetString("APP_SECRET", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap cancel {
            get {
                object obj = ResourceManager.GetObject("cancel", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://graph.facebook.com/.
        /// </summary>
        internal static string FACEBOOK_GRAPH {
            get {
                return ResourceManager.GetString("FACEBOOK_GRAPH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.facebook.com/dialog/oauth.
        /// </summary>
        internal static string FACEBOOK_LOGIN {
            get {
                return ResourceManager.GetString("FACEBOOK_LOGIN", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap generate {
            get {
                object obj = ResourceManager.GetObject("generate", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap last {
            get {
                object obj = ResourceManager.GetObject("last", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.facebook.com/connect/login_success.html.
        /// </summary>
        internal static string REDIRECT_SUCCESS {
            get {
                return ResourceManager.GetString("REDIRECT_SUCCESS", resourceCulture);
            }
        }
    }
}
