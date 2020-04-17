﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Sarif.Multitool.Rules {
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
    internal class RuleResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RuleResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Sarif.Multitool.Rules.RuleResources", typeof(RuleResources).Assembly);
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
        ///   Looks up a localized string similar to {0}: The name and id properties of rule &quot;{1}&quot; are the same..
        /// </summary>
        internal static string SARIF1001_Default {
            get {
                return ResourceManager.GetString("SARIF1001_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not use the same string for a rule&apos;s id and name properties. The id property must be a stable, opaque identifer such as &quot;SARIF1001&quot;. The name property should be a string that is understandable to an end user, such as &quot;DoNotUserFriendlyNameAsRuleId&quot;..
        /// </summary>
        internal static string SARIF1001_DoNotUseFriendlyNameAsRuleIdDescription {
            get {
                return ResourceManager.GetString("SARIF1001_DoNotUseFriendlyNameAsRuleIdDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The string &quot;{1}&quot; is not a valid URI reference..
        /// </summary>
        internal static string SARIF1003_Default {
            get {
                return ResourceManager.GetString("SARIF1003_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify a valid URI reference for every URI-valued property..
        /// </summary>
        internal static string SARIF1003_UrisMustBeValid {
            get {
                return ResourceManager.GetString("SARIF1003_UrisMustBeValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The array contains multiple objects with the value &quot;{1}&quot; for the algorithm property..
        /// </summary>
        internal static string SARIF1006_Default {
            get {
                return ResourceManager.GetString("SARIF1006_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In any given &quot;file&quot; object, every element of the &quot;hashes&quot; array must have a different value for its &quot;algorithm&quot; property. .
        /// </summary>
        internal static string SARIF1006_HashAlgorithmsMustBeUnique {
            get {
                return ResourceManager.GetString("SARIF1006_HashAlgorithmsMustBeUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The end time &quot;{1}&quot; is before the start time &quot;{2}&quot;..
        /// </summary>
        internal static string SARIF1007_Default {
            get {
                return ResourceManager.GetString("SARIF1007_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The end time of a run must not precede the start time. To allow for the possibility that the duration of the run is less than the resolution of the string representation of the time, the start time and the end time may be equal..
        /// </summary>
        internal static string SARIF1007_EndTimeMustNotBeBeforeStartTime {
            get {
                return ResourceManager.GetString("SARIF1007_EndTimeMustNotBeBeforeStartTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The message &quot;{1}&quot; does not end with a period..
        /// </summary>
        internal static string SARIF1008_Default {
            get {
                return ResourceManager.GetString("SARIF1008_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Messages should consist of one or more complete sentences, ending with a period..
        /// </summary>
        internal static string SARIF1008_MessagesShouldEndWithPeriod {
            get {
                return ResourceManager.GetString("SARIF1008_MessagesShouldEndWithPeriod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of the &quot;step&quot; property should be {1}, but is {2}. The step values must form a 1-based sequence starting at the first threadFlowLocation in the thread flow..
        /// </summary>
        internal static string SARIF1009_InvalidStepValue {
            get {
                return ResourceManager.GetString("SARIF1009_InvalidStepValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The &quot;step&quot; property is absent. The &quot;step&quot; property is present on some but not all threadFlowLocations in this threadFlow. If the &quot;step&quot; property is used on any threadFlowLocation in a threadFlow, it must be present on every threadFlowLocation in that threadFlow..
        /// </summary>
        internal static string SARIF1009_StepNotPresentOnAllLocations {
            get {
                return ResourceManager.GetString("SARIF1009_StepNotPresentOnAllLocations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the &quot;step&quot; property is used on any threadFlowLocation in a threadFlow, then it must be present for every threadFlowLocation in the threadFlow, its value must be 1 for the first threadFlowLocation, and its value must increase by 1 for each succeeding threadFlowLocation..
        /// </summary>
        internal static string SARIF1009_StepValuesMustFormOneBasedSequence {
            get {
                return ResourceManager.GetString("SARIF1009_StepValuesMustFormOneBasedSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of the &quot;endLine&quot; property is {1}, which is less than the value of the &quot;startLine&quot; property, which is {2}..
        /// </summary>
        internal static string SARIF1012_Default {
            get {
                return ResourceManager.GetString("SARIF1012_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;endLine&quot; property of a region object must not be less than the &quot;startLine&quot; property..
        /// </summary>
        internal static string SARIF1012_EndLineMustNotBeLessThanStartLine {
            get {
                return ResourceManager.GetString("SARIF1012_EndLineMustNotBeLessThanStartLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of the &quot;endColumn&quot; property is {1}, which is less than the value of the &quot;startColumn&quot; property, which is {2}..
        /// </summary>
        internal static string SARIF1013_Default {
            get {
                return ResourceManager.GetString("SARIF1013_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &quot;endColumn&quot; property of a region object must not be less than the &quot;startColumn&quot; property..
        /// </summary>
        internal static string SARIF1013_EndColumnMustNotBeLessThanStartColumn {
            get {
                return ResourceManager.GetString("SARIF1013_EndColumnMustNotBeLessThanStartColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This fileLocation object contains a &quot;uriBaseId&quot; property, which means that the value of the &quot;uri&quot; property must be a relative URI reference, but &quot;{1}&quot; is an absolute URI reference..
        /// </summary>
        internal static string SARIF1014_Default {
            get {
                return ResourceManager.GetString("SARIF1014_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If a fileLocation object contains a &quot;uriBaseId&quot; property, the value of the &quot;uri&quot; property must be a relative URI reference..
        /// </summary>
        internal static string SARIF1014_UriBaseIdRequiresRelativeUri {
            get {
                return ResourceManager.GetString("SARIF1014_UriBaseIdRequiresRelativeUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The value of this property is required to be an absolute URI, but &quot;{1}&quot; is a relative URI reference..
        /// </summary>
        internal static string SARIF1015_Default {
            get {
                return ResourceManager.GetString("SARIF1015_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certain URIs are required to be absolute..
        /// </summary>
        internal static string SARIF1015_UriMustBeAbsolute {
            get {
                return ResourceManager.GetString("SARIF1015_UriMustBeAbsolute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the &quot;contextRegion&quot; property is present, the &quot;region&quot; property must also be present..
        /// </summary>
        internal static string SARIF1016_ContextRegionRequiresRegion {
            get {
                return ResourceManager.GetString("SARIF1016_ContextRegionRequiresRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &quot;physicalLocation&quot; object contains a &quot;contextRegion&quot; property, but it does not contain a &quot;region&quot; property..
        /// </summary>
        internal static string SARIF1016_Default {
            get {
                return ResourceManager.GetString("SARIF1016_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: This &quot;{1}&quot; object contains a property &quot;{2}&quot; with value {3}, but either &quot;{4}&quot; is absent, or it has fewer than {5} elements..
        /// </summary>
        internal static string SARIF1017_Default {
            get {
                return ResourceManager.GetString("SARIF1017_Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If an object contains a property that is used as an array index, then that array must be present and must contain at least &quot;index + 1&quot; elements..
        /// </summary>
        internal static string SARIF1017_InvalidIndex {
            get {
                return ResourceManager.GetString("SARIF1017_InvalidIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In the artifactLocation objects contained in run.originalUriBaseIds, if uriBaseId is absent, then uri must either be an absolute URI or it must be absent. Also, uri must end with a slash, so that it can safely be combined with the relative URIs in artifactLocation objects elsewhere in the log file..
        /// </summary>
        internal static string SARIF1018_InvalidUriInOriginalUriBaseIds {
            get {
                return ResourceManager.GetString("SARIF1018_InvalidUriInOriginalUriBaseIds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In this artifactLocation object contained in run.originalUriBaseIds, the uri property &apos;{0}&apos; does not end with a slash..
        /// </summary>
        internal static string SARIF1018_LacksTrailingSlash {
            get {
                return ResourceManager.GetString("SARIF1018_LacksTrailingSlash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In this artifactLocation object contained in run.originalUriBaseIds, uriBaseId is absent, but the uri property &apos;{0}&apos; is not an absolute URI..
        /// </summary>
        internal static string SARIF1018_NotAbsolute {
            get {
                return ResourceManager.GetString("SARIF1018_NotAbsolute", resourceCulture);
            }
        }
    }
}
