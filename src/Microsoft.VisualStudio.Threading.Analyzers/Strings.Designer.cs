﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Threading.Analyzers {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.Threading.Analyzers.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Await {0} instead.
        /// </summary>
        internal static string AwaitXInstead {
            get {
                return ResourceManager.GetString("AwaitXInstead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use await instead.
        /// </summary>
        internal static string UseAwaitInstead {
            get {
                return ResourceManager.GetString("UseAwaitInstead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Synchronously waiting on tasks or awaiters is dangerous and may cause dead locks. Please consider the following options: 1) Switch to asynchronous wait if the caller is already a &quot;async&quot; method. 2) Change the chain of callers to be &quot;async&quot; methods, and then change this code to be asynchronous await. 3) Use JoinableTaskFactory.Run() to wait on the tasks or awaiters. Refer to http://blogs.msdn.com/b/andrewarnottms/archive/2014/05/07/asynchronous-and-multithreaded-programming-within-vs-using-the-joinabletaskfa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string VSSDK001_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK001_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid problematic synchronous waits.
        /// </summary>
        internal static string VSSDK001_Title {
            get {
                return ResourceManager.GetString("VSSDK001_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Visual Studio service &quot;{0}&quot; should be used on main thread explicitly. 
        ///Please either verify the current thread is main thread, or switch to main thread asynchronously. 
        ///1) APIs to verify the current thread is main thread: ThreadHelper.ThrowIfNotOnUIThread(), or IThreadHandling.VerifyOnUIThread(). 
        ///2) APIs to switch to main thread asynchronously: JoinableTaskFactory.SwitchToMainThreadAsync(), or IThreadHandling.SwitchToUIThread(). 
        ///Refer to http://blogs.msdn.com/b/andrewarnottms/archive/2014/05/07/asynch [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string VSSDK002_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK002_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use VS services from UI thread.
        /// </summary>
        internal static string VSSDK002_Title {
            get {
                return ResourceManager.GetString("VSSDK002_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid Async Void method, because any exceptions thrown out of an async void method will be raised directly on the SynchronizationContext and will crash the process. 
        ///Refer to https://msdn.microsoft.com/en-us/magazine/jj991977.aspx for more info..
        /// </summary>
        internal static string VSSDK003_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK003_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid async void methods.
        /// </summary>
        internal static string VSSDK003_Title {
            get {
                return ResourceManager.GetString("VSSDK003_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid using async lambda as void returning delegate type, because any exceptions thrown out of an async lambda returning void will be raised directly on the SynchronizationContext and will crash the process. 
        ///Refer to https://msdn.microsoft.com/en-us/magazine/jj991977.aspx for more info..
        /// </summary>
        internal static string VSSDK004_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK004_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid unsupported async delegates.
        /// </summary>
        internal static string VSSDK004_Title {
            get {
                return ResourceManager.GetString("VSSDK004_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AsyncEventHandler delegates should be invoked via the extension method &quot;TplExtensions.InvokeAsync()&quot; defined in Microsoft.VisualStudio.Threading assembly..
        /// </summary>
        internal static string VSSDK005_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK005_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use InvokeAsync to raise async events.
        /// </summary>
        internal static string VSSDK005_Title {
            get {
                return ResourceManager.GetString("VSSDK005_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling await on a Task inside a JoinableTaskFactory.Run, when the task is initialized outside the delegate can cause potential deadlocks.
        ///You can avoid this problem by ensuring the task is initialized within the delegate or by using JoinableTask instead of Task..
        /// </summary>
        internal static string VSSDK006_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK006_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid awaiting non-joinable tasks in join contexts.
        /// </summary>
        internal static string VSSDK006_Title {
            get {
                return ResourceManager.GetString("VSSDK006_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling Lazy&lt;Task&lt;T&gt;&gt;.Value can deadlock when the value factory was previously started.
        ///You should use AsyncLazy&lt;T&gt; instead..
        /// </summary>
        internal static string VSSDK007_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK007_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid using Lazy&lt;T&gt; where T is a Task.
        /// </summary>
        internal static string VSSDK007_Title {
            get {
                return ResourceManager.GetString("VSSDK007_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} member synchronously blocks. Call {1} instead and await its result..
        /// </summary>
        internal static string VSSDK008_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK008_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} member synchronously blocks. Use await instead..
        /// </summary>
        internal static string VSSDK008_MessageFormat_UseAwaitInstead {
            get {
                return ResourceManager.GetString("VSSDK008_MessageFormat_UseAwaitInstead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call async methods when in an async method.
        /// </summary>
        internal static string VSSDK008_Title {
            get {
                return ResourceManager.GetString("VSSDK008_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Limit use of synchronously blocking method calls such as JoinableTaskFactory.Run or Task.Result to public entrypoint members where you must be synchronous. Using it for internal members can needlessly add synchronous frames between asynchronous frames, leading to threadpool exhaustion..
        /// </summary>
        internal static string VSSDK009_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK009_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implement internal logic asynchronously.
        /// </summary>
        internal static string VSSDK009_Title {
            get {
                return ResourceManager.GetString("VSSDK009_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename to {0}.
        /// </summary>
        internal static string VSSDK010_CodeFix_Title {
            get {
                return ResourceManager.GetString("VSSDK010_CodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &quot;Async&quot; suffix in names of Task-returning methods..
        /// </summary>
        internal static string VSSDK010_MessageFormat {
            get {
                return ResourceManager.GetString("VSSDK010_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &quot;Async&quot; suffix for async methods.
        /// </summary>
        internal static string VSSDK010_Title {
            get {
                return ResourceManager.GetString("VSSDK010_Title", resourceCulture);
            }
        }
    }
}
