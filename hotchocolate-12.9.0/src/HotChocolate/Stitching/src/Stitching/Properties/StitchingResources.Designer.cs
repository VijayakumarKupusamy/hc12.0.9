//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Stitching.Properties {
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
    internal class StitchingResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StitchingResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HotChocolate.Stitching.Properties.StitchingResources", typeof(StitchingResources).Assembly);
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
        ///   Looks up a localized string similar to The directive `{0}` was not specified in this schema and cannot be used..
        /// </summary>
        internal static string AddSchemaExtensionRewriter_DirectiveDoesNotExist {
            get {
                return ResourceManager.GetString("AddSchemaExtensionRewriter_DirectiveDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directive `{0}` is not marked as repeatable and can only be declared once..
        /// </summary>
        internal static string AddSchemaExtensionRewriter_DirectiveIsUnique {
            get {
                return ResourceManager.GetString("AddSchemaExtensionRewriter_DirectiveIsUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to `{0}` is of type `{1}` and cannot be extended with `{2}`..
        /// </summary>
        internal static string AddSchemaExtensionRewriter_TypeMismatch {
            get {
                return ResourceManager.GetString("AddSchemaExtensionRewriter_TypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This resolver can only handle argument scopes..
        /// </summary>
        internal static string ArgumentScopedVariableResolver_CannotHandleVariable {
            get {
                return ResourceManager.GetString("ArgumentScopedVariableResolver_CannotHandleVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An argument with the name `{0}` does not exist..
        /// </summary>
        internal static string ArgumentScopedVariableResolver_InvalidArgumentName {
            get {
                return ResourceManager.GetString("ArgumentScopedVariableResolver_InvalidArgumentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The request must contain a query document..
        /// </summary>
        internal static string BufferedRequest_Create_QueryCannotBeNull {
            get {
                return ResourceManager.GetString("BufferedRequest_Create_QueryCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the fields on which a computed field is dependent on..
        /// </summary>
        internal static string ComputedDirectiveType_Description {
            get {
                return ResourceManager.GetString("ComputedDirectiveType_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This resolver can only handle contextData scopes..
        /// </summary>
        internal static string ContextDataScopedVariableResolver_CannotHandleVariable {
            get {
                return ResourceManager.GetString("ContextDataScopedVariableResolver_CannotHandleVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delegates a resolver to a remote schema..
        /// </summary>
        internal static string DelegateDirectiveType_Description {
            get {
                return ResourceManager.GetString("DelegateDirectiveType_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path to the field on the remote schema..
        /// </summary>
        internal static string DelegateDirectiveType_Path_FieldDescription {
            get {
                return ResourceManager.GetString("DelegateDirectiveType_Path_FieldDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the schema to which this field shall be delegated to..
        /// </summary>
        internal static string DelegateDirectiveType_Schema_FieldDescription {
            get {
                return ResourceManager.GetString("DelegateDirectiveType_Schema_FieldDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path element argument `{0}` was not found..
        /// </summary>
        internal static string DelegationMiddleware_ArgumentNotFound {
            get {
                return ResourceManager.GetString("DelegationMiddleware_ArgumentNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only query results are supported in the delegation middleware..
        /// </summary>
        internal static string DelegationMiddleware_OnlyQueryResults {
            get {
                return ResourceManager.GetString("DelegationMiddleware_OnlyQueryResults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The path element `{0}` has no corresponding field on type `{1}`..
        /// </summary>
        internal static string DelegationMiddleware_PathElementInvalid {
            get {
                return ResourceManager.GetString("DelegationMiddleware_PathElementInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scalar path elements are only allowed at the end..
        /// </summary>
        internal static string DelegationMiddleware_PathElementTypeUnexpected {
            get {
                return ResourceManager.GetString("DelegationMiddleware_PathElementTypeUnexpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The extensions document mustn&apos;t be null or empty..
        /// </summary>
        internal static string Extensions_EmptyOrNull {
            get {
                return ResourceManager.GetString("Extensions_EmptyOrNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema extensions file path mustn&apos;t be null or empty..
        /// </summary>
        internal static string ExtensionsFilePath_EmptyOrNull {
            get {
                return ResourceManager.GetString("ExtensionsFilePath_EmptyOrNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This resolver can only handle field scopes..
        /// </summary>
        internal static string FieldScopedVariableResolver_CannotHandleVariable {
            get {
                return ResourceManager.GetString("FieldScopedVariableResolver_CannotHandleVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A field with the name `{0}` does not exist..
        /// </summary>
        internal static string FieldScopedVariableResolver_InvalidFieldName {
            get {
                return ResourceManager.GetString("FieldScopedVariableResolver_InvalidFieldName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown variable value kind..
        /// </summary>
        internal static string HttpRequestClient_UnknownVariableValueKind {
            get {
                return ResourceManager.GetString("HttpRequestClient_UnknownVariableValueKind", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to json mustn&apos;t be null or empty..
        /// </summary>
        internal static string IntrospectionDeserializer_Json_NullOrEmpty {
            get {
                return ResourceManager.GetString("IntrospectionDeserializer_Json_NullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No schema was specified..
        /// </summary>
        internal static string MergeSyntaxNodeExtensions_NoSchema {
            get {
                return ResourceManager.GetString("MergeSyntaxNodeExtensions_NoSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified operation `{0}` does not exist..
        /// </summary>
        internal static string QueryRequestBuilder_OperationNameInvalid {
            get {
                return ResourceManager.GetString("QueryRequestBuilder_OperationNameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify an operation name in order to create a query request that contains multiple operations..
        /// </summary>
        internal static string QueryRequestBuilder_OperationNameMissing {
            get {
                return ResourceManager.GetString("QueryRequestBuilder_OperationNameMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify a query in order to create a query request..
        /// </summary>
        internal static string QueryRequestBuilder_QueryIsNull {
            get {
                return ResourceManager.GetString("QueryRequestBuilder_QueryIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot build a remote executor without a schema..
        /// </summary>
        internal static string RemoteExecutorBuilder_NoSchema {
            get {
                return ResourceManager.GetString("RemoteExecutorBuilder_NoSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot build a remote executor without a schema name..
        /// </summary>
        internal static string RemoteExecutorBuilder_NoSchemaName {
            get {
                return ResourceManager.GetString("RemoteExecutorBuilder_NoSchemaName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified scope `{0}` is not supported..
        /// </summary>
        internal static string RootScopedVariableResolver_ScopeNotSupported {
            get {
                return ResourceManager.GetString("RootScopedVariableResolver_ScopeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided type must extend `HotChocolate.Types.ScalarType` in order to be recognised as valid scalar type..
        /// </summary>
        internal static string ScalarType_InvalidBaseType {
            get {
                return ResourceManager.GetString("ScalarType_InvalidBaseType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema mustn&apos;t be null or empty..
        /// </summary>
        internal static string Schema_EmptyOrNull {
            get {
                return ResourceManager.GetString("Schema_EmptyOrNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema file path mustn&apos;t be null or empty..
        /// </summary>
        internal static string SchemaFilePath_EmptyOrNull {
            get {
                return ResourceManager.GetString("SchemaFilePath_EmptyOrNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A type merge handler has to have one constructor that has only one parameter of the type MergeTypeDelegate..
        /// </summary>
        internal static string SchemaMergerExtensions_NoValidConstructor {
            get {
                return ResourceManager.GetString("SchemaMergerExtensions_NoValidConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema name mustn&apos;t be null or empty..
        /// </summary>
        internal static string SchemaName_EmptyOrNull {
            get {
                return ResourceManager.GetString("SchemaName_EmptyOrNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no schema with the given name `{0}`..
        /// </summary>
        internal static string SchemaName_NotFound {
            get {
                return ResourceManager.GetString("SchemaName_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This resolver can only handle scopedContextData scopes..
        /// </summary>
        internal static string ScopedCtxDataScopedVariableResolver_CannotHandleVariable {
            get {
                return ResourceManager.GetString("ScopedCtxDataScopedVariableResolver_CannotHandleVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Annotates the original name of a type..
        /// </summary>
        internal static string SourceDirectiveType_Description {
            get {
                return ResourceManager.GetString("SourceDirectiveType_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The original name of the annotated type..
        /// </summary>
        internal static string SourceDirectiveType_Name_Description {
            get {
                return ResourceManager.GetString("SourceDirectiveType_Name_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the schema to which this type belongs to..
        /// </summary>
        internal static string SourceDirectiveType_Schema_Description {
            get {
                return ResourceManager.GetString("SourceDirectiveType_Schema_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified schema name was already beeing used..
        /// </summary>
        internal static string StitchingBuilder_SchemaNameInUse {
            get {
                return ResourceManager.GetString("StitchingBuilder_SchemaNameInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided remote query does not contain the specified operation.\r\n\r\n`{0}`.
        /// </summary>
        internal static string ThrowHelper_BufferedRequest_OperationNotFound {
            get {
                return ResourceManager.GetString("ThrowHelper_BufferedRequest_OperationNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified variable `{0}` does not exist or is of an invalid type..
        /// </summary>
        internal static string ThrowHelper_BufferedRequest_VariableDoesNotExist {
            get {
                return ResourceManager.GetString("ThrowHelper_BufferedRequest_VariableDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type definition is not yet supported..
        /// </summary>
        internal static string Type_NotSupported {
            get {
                return ResourceManager.GetString("Type_NotSupported", resourceCulture);
            }
        }
    }
}
