// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Decimals.CheckDecimalsTag
{
    using System;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult InvalidDecimalsForDatetime(IValidate test, IReadable referenceNode, IReadable positionNode, string itemId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckDecimalsTag,
                ErrorId = ErrorIds.InvalidDecimalsForDatetime,
                FullId = "2.75.1",
                Category = Category.Param,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing tag '{0}' with expected value '{1}' for {2} '{3}'.", "Display/Decimals", "8", "Param", itemId),
                HowToFix = "Add the Protocol/Params/Param/Display/Decimals tag with value 8.",
                ExampleCode = "<Display>" + Environment.NewLine + "   <RTDisplay>true</RTDisplay>" + Environment.NewLine + "   <Decimals>8</Decimals>" + Environment.NewLine + "</Display>" + Environment.NewLine + "<Measurement>" + Environment.NewLine + "   <Type options=\"datetime\">number</Type>" + Environment.NewLine + "</Measurement>" + Environment.NewLine + "",
                Details = "By default, only 6 decimals are saved in memory. Parameters holding datetime values need at least 8 decimals to be accurate." + Environment.NewLine + "Otherwise, there might be rounding issues when retrieving the parameter from an external source like an Automation script." + Environment.NewLine + "",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint InvalidDecimalsForDatetime = 1;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckDecimalsTag = 75;
    }
}