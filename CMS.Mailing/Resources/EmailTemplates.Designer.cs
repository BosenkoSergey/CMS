﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.Mailing.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class EmailTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EmailTemplates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CMS.Mailing.Resources.EmailTemplates", typeof(EmailTemplates).Assembly);
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
        ///   Looks up a localized string similar to &lt;p&gt;Dear &lt;strong&gt;{0}&lt;/strong&gt;,&lt;/p&gt;
        ///&lt;p&gt;Your password has been successfully reset. You can now log in to your account using the following credentials:&lt;/p&gt;
        ///&lt;ul&gt;
        ///    &lt;li&gt;&lt;strong&gt;Login:&lt;/strong&gt;{1}&lt;/li&gt;
        ///    &lt;li&gt;&lt;strong&gt;Temporary Password:&lt;/strong&gt; {2}&lt;/li&gt;
        ///&lt;/ul&gt;
        ///&lt;p&gt;For security reasons, we strongly recommend changing your password after logging in.&lt;/p&gt;
        ///&lt;p&gt;Access your account here: &lt;a href=&quot;{3}&quot;&gt;{3}&lt;/a&gt;&lt;/p&gt;
        ///&lt;p&gt;If you did not request a password reset, please contact our support team immediately.&lt;/p&gt;
        ///&lt;p&gt;Bes [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PasswordReset_Html {
            get {
                return ResourceManager.GetString("PasswordReset.Html", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dear {0},
        ///
        ///Your password has been successfully reset. You can now log in to your account using the following credentials:
        ///
        ///- Login: {1}
        ///- Temporary Password: {2}
        ///
        ///For security reasons, we strongly recommend changing your password after logging in.
        ///
        ///Access your account here: {3}
        ///
        ///If you did not request a password reset, please contact our support team immediately.
        ///
        ///Best regards,  
        ///{4}.
        /// </summary>
        internal static string PasswordReset_PlainText {
            get {
                return ResourceManager.GetString("PasswordReset.PlainText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Password Has Been Reset.
        /// </summary>
        internal static string PasswordReset_Subject {
            get {
                return ResourceManager.GetString("PasswordReset.Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Dear &lt;strong&gt;{0}&lt;/strong&gt;,&lt;/p&gt;
        ///&lt;p&gt;We are excited to inform you that your account has been successfully created on our company portal.&lt;/p&gt;
        ///&lt;p&gt;You can now log in using the following credentials:&lt;/p&gt;
        ///&lt;ul&gt;
        ///    &lt;li&gt;&lt;strong&gt;Login:&lt;/strong&gt; {1}&lt;/li&gt;
        ///    &lt;li&gt;&lt;strong&gt;Password:&lt;/strong&gt; {2}&lt;/li&gt;
        ///&lt;/ul&gt;
        ///&lt;p&gt;Please make sure to change your password after your first login for security reasons.&lt;/p&gt;
        ///&lt;p&gt;Access the portal here: &lt;a href=&quot;{3}&quot;&gt;{3}&lt;/a&gt;&lt;/p&gt;
        ///&lt;p&gt;If you have any questions or need assistance, feel free to [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UserCreated_Html {
            get {
                return ResourceManager.GetString("UserCreated.Html", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dear {0},
        ///
        ///We are excited to inform you that your account has been successfully created on our company portal.
        ///
        ///You can now log in using the following credentials:
        ///- Login: {1}
        ///- Password: {2}
        ///
        ///Please make sure to change your password after your first login for security reasons.
        ///
        ///Access the portal here: {3}
        ///
        ///If you have any questions or need assistance, feel free to contact our support team.
        ///
        ///Best regards,  
        ///{4}.
        /// </summary>
        internal static string UserCreated_PlainText {
            get {
                return ResourceManager.GetString("UserCreated.PlainText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your Account Has Been Created.
        /// </summary>
        internal static string UserCreated_Subject {
            get {
                return ResourceManager.GetString("UserCreated.Subject", resourceCulture);
            }
        }
    }
}
