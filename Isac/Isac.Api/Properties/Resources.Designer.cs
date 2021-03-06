﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Isac.Api.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
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
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Isac.Api.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The following commits are not associated with a reveiw:\n\n{0}.
        /// </summary>
        internal static string PullRequest_CommitsNotAssociatedWithAReview {
            get {
                return ResourceManager.GetString("PullRequest_CommitsNotAssociatedWithAReview", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This pull request contains conflicts, please follow the below steps to resolve them.\n\n**Step 1.** Make sure `{0}` is updated locally.\n\n```sh\ngit checkout {0}\ngit pull\n```\n\n**Step 2.** Checkout `{1}` and pull `{0}` in locally. This will try to merge and will reveal all of the conflicts.\n\n```sh\ngit checkout {1}\ngit pull origin {0}\n```\n\n**Step 3.** Resolve conflicts, add and commit the changes and push them to remote.\n\n```sh\ngit add &lt;files&gt;\ngit commit -m &apos;commit message&apos;\ngit push origin {1 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PullRequest_MergeConflictResolution {
            get {
                return ResourceManager.GetString("PullRequest_MergeConflictResolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @{0} I marked this pull request as \&quot;Needs Work\&quot; because of the following issues:\n\n{1}.
        /// </summary>
        internal static string PullRequest_NeedsWorkReviewConditions {
            get {
                return ResourceManager.GetString("PullRequest_NeedsWorkReviewConditions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to does not have at least {0} completed reviewers.
        /// </summary>
        internal static string PullRequest_ReviewCompletedReviewers {
            get {
                return ResourceManager.GetString("PullRequest_ReviewCompletedReviewers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to is not {0}.
        /// </summary>
        internal static string PullRequest_ReviewStateValidation {
            get {
                return ResourceManager.GetString("PullRequest_ReviewStateValidation", resourceCulture);
            }
        }
    }
}
