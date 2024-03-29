// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.QActions.QAction.CSharpCheckEntryPoints
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult MissingEntryPoint(IValidate test, IReadable referenceNode, IReadable positionNode, string entryPointClass, string entryPointMethod, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckEntryPoints,
                ErrorId = ErrorIds.MissingEntryPoint,
                FullId = "3.12.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Entry point '{0}.{1}' not found in QAction. QAction ID {2}.", entryPointClass, entryPointMethod, qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The QAction@entryPoint attribute can optionally be used to overwrite the default entry point of a QAction." + Environment.NewLine + "" + Environment.NewLine + "By default, the entry point will be the method 'Run' that can be found under the class 'QAction'." + Environment.NewLine + "Defining multiple entry points can be done by providing a semicolon list of entry points." + Environment.NewLine + "In that case, each entry point corresponds to a QAction trigger." + Environment.NewLine + "" + Environment.NewLine + "One of the two following format can be used in order to overwrite default entry points (curly braces are here used as place holder indicators in the below explanation so are not to be included when defining your entry points):" + Environment.NewLine + "- {entryPointMethod}: the given method name in the 'QAction' class will be the new entry point." + Environment.NewLine + "- {entryPointClass}.{entryPointMethod}: the given method name in the given class name will be the new entry point." + Environment.NewLine + "" + Environment.NewLine + "Note that both the entry point class and methods are expected to be public and the first argument of the entry point is expected to be of type SLProtocol or SLProtocolExt.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnexpectedAccessModifierForEntryPointMethod(IValidate test, IReadable referenceNode, IReadable positionNode, string entryPointClass, string entryPointMethod, string currentAccessModifier, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckEntryPoints,
                ErrorId = ErrorIds.UnexpectedAccessModifierForEntryPointMethod,
                FullId = "3.12.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Entry point method '{0}.{1}' has unexpected access modifier '{2}'. QAction ID {3}.", entryPointClass, entryPointMethod, currentAccessModifier, qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The QAction@entryPoint attribute can optionally be used to overwrite the default entry point of a QAction." + Environment.NewLine + "" + Environment.NewLine + "By default, the entry point will be the method 'Run' that can be found under the class 'QAction'." + Environment.NewLine + "Defining multiple entry points can be done by providing a semicolon list of entry points." + Environment.NewLine + "In that case, each entry point corresponds to a QAction trigger." + Environment.NewLine + "" + Environment.NewLine + "One of the two following format can be used in order to overwrite default entry points (curly braces are here used as place holder indicators in the below explanation so are not to be included when defining your entry points):" + Environment.NewLine + "- {entryPointMethod}: the given method name in the 'QAction' class will be the new entry point." + Environment.NewLine + "- {entryPointClass}.{entryPointMethod}: the given method name in the given class name will be the new entry point." + Environment.NewLine + "" + Environment.NewLine + "Note that both the entry point class and methods are expected to be public and the first argument of the entry point is expected to be of type SLProtocol or SLProtocolExt.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnexpectedAccessModifierForEntryPointClass(IValidate test, IReadable referenceNode, IReadable positionNode, string entryPointClass, string currentAccessModifier, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckEntryPoints,
                ErrorId = ErrorIds.UnexpectedAccessModifierForEntryPointClass,
                FullId = "3.12.3",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Entry point class '{0}' has unexpected access modifier '{1}'. QAction ID {2}.", entryPointClass, currentAccessModifier, qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The QAction@entryPoint attribute can optionally be used to overwrite the default entry point of a QAction." + Environment.NewLine + "" + Environment.NewLine + "By default, the entry point will be the method 'Run' that can be found under the class 'QAction'." + Environment.NewLine + "Defining multiple entry points can be done by providing a semicolon list of entry points." + Environment.NewLine + "In that case, each entry point corresponds to a QAction trigger." + Environment.NewLine + "" + Environment.NewLine + "One of the two following format can be used in order to overwrite default entry points (curly braces are here used as place holder indicators in the below explanation so are not to be included when defining your entry points):" + Environment.NewLine + "- {entryPointMethod}: the given method name in the 'QAction' class will be the new entry point." + Environment.NewLine + "- {entryPointClass}.{entryPointMethod}: the given method name in the given class name will be the new entry point." + Environment.NewLine + "" + Environment.NewLine + "Note that both the entry point class and methods are expected to be public and the first argument of the entry point is expected to be of type SLProtocol or SLProtocolExt.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnexpectedArg0TypeForEntryPointMethod(IValidate test, IReadable referenceNode, IReadable positionNode, string entryPointClass, string entryPointMethod, string arg0Type, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CSharpCheckEntryPoints,
                ErrorId = ErrorIds.UnexpectedArg0TypeForEntryPointMethod,
                FullId = "3.12.4",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Entry point method '{0}.{1}' has a first argument with unexpected type '{2}'. QAction ID {3}.", entryPointClass, entryPointMethod, arg0Type, qactionId),
                HowToFix = "",
                ExampleCode = "",
                Details = "The QAction@entryPoint attribute can optionally be used to overwrite the default entry point of a QAction." + Environment.NewLine + "" + Environment.NewLine + "By default, the entry point will be the method 'Run' that can be found under the class 'QAction'." + Environment.NewLine + "Defining multiple entry points can be done by providing a semicolon list of entry points." + Environment.NewLine + "In that case, each entry point corresponds to a QAction trigger." + Environment.NewLine + "" + Environment.NewLine + "One of the two following format can be used in order to overwrite default entry points (curly braces are here used as place holder indicators in the below explanation so are not to be included when defining your entry points):" + Environment.NewLine + "- {entryPointMethod}: the given method name in the 'QAction' class will be the new entry point." + Environment.NewLine + "- {entryPointClass}.{entryPointMethod}: the given method name in the given class name will be the new entry point." + Environment.NewLine + "" + Environment.NewLine + "Note that both the entry point class and methods are expected to be public and the first argument of the entry point is expected to be of type SLProtocol or SLProtocolExt.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint MissingEntryPoint = 1;
        public const uint UnexpectedAccessModifierForEntryPointMethod = 2;
        public const uint UnexpectedAccessModifierForEntryPointClass = 3;
        public const uint UnexpectedArg0TypeForEntryPointMethod = 4;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CSharpCheckEntryPoints = 12;
    }
}