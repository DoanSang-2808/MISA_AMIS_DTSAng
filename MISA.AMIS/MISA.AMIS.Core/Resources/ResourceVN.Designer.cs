//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MISA.AMIS.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceVN {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceVN() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MISA.AMIS.Core.Resources.ResourceVN", typeof(ResourceVN).Assembly);
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
        ///   Looks up a localized string similar to Thực hiện không thành công.
        /// </summary>
        internal static string Dev_Error {
            get {
                return ResourceManager.GetString("Dev_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Giá trị {0} đã tồn tại trong sơ sở dữ liệu.
        /// </summary>
        internal static string Input_Duplicate {
            get {
                return ResourceManager.GetString("Input_Duplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Giá trị {0} không được để trống.
        /// </summary>
        internal static string Input_Empty {
            get {
                return ResourceManager.GetString("Input_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Giá trị {0} chư đúng định dạng.
        /// </summary>
        internal static string Input_Format {
            get {
                return ResourceManager.GetString("Input_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thực hiện thành công.
        /// </summary>
        internal static string Success {
            get {
                return ResourceManager.GetString("Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thực hiện không thành công. Vui lòng kiểm tra lại thông tin..
        /// </summary>
        internal static string User_BadRequest_Msg {
            get {
                return ResourceManager.GetString("User_BadRequest_Msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thực hiện không thành công.
        /// </summary>
        internal static string User_Error {
            get {
                return ResourceManager.GetString("User_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Có lỗi xảy ra vui lòng liên hệ Misa !.
        /// </summary>
        internal static string User_Error_Serve_Msg {
            get {
                return ResourceManager.GetString("User_Error_Serve_Msg", resourceCulture);
            }
        }
    }
}
