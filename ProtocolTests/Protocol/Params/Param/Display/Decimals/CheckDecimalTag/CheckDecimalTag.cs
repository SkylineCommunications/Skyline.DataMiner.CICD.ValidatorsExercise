namespace ProtocolTests.Protocol.Params.Param.Display.Decimals.CheckDecimalTag
{
    using System;
    using System.Collections.Generic;

    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Decimals.CheckDecimalTag;

    [TestClass]
    public class Validate
    {
        private readonly IValidate check = new CheckDecimalTag();

        #region Valid Checks

        [TestMethod]
        public void Param_CheckDecimalTag_Valid()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Valid,
                FileName = "Valid",
                ExpectedResults = new List<IValidationResult>()
            };

            Generic.Validate(check, data);
        }

        #endregion

        #region Invalid Checks

        [TestMethod]
        public void Param_CheckDecimalTag_InvalidTagForDateTime()
        {
            Generic.ValidateData data = new Generic.ValidateData
            {
                TestType = Generic.TestType.Invalid,
                FileName = "InvalidTagForDateTime",
                ExpectedResults = new List<IValidationResult>
                {
                    Error.InvalidTagForDateTime(null, null, null, "Protocol.Params.Param.Display.", "8", "datetime parameter", "10"),
                }
            };

            Generic.Validate(check, data);
        }

        #endregion
    }

    [TestClass]
    public class ErrorMessages
    {
        [TestMethod]
        public void Param_CheckDecimalTag_InvalidTagForDateTime()
        {
            // Create ErrorMessage
            var message = Error.InvalidTagForDateTime(null, null, null, "tagName", "expectedValue", "itemKind", "itemId");
                        
            var expected = new ValidationResult
            {
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = "Missing tag 'tagName' with expected value 'expectedValue' for itemKind 'itemId'.",
                Details = "By default, only 6 decimals are saved in memory. Parameters holding datetime needs at least 8 decimals to be accurate." + Environment.NewLine + "Otherwise you can see rounding issues when retrieving the parmater from an external source like an Automation Script.",
                HasCodeFix = false,
            };

            // Assert
            message.Should().BeEquivalentTo(expected, Generic.ExcludePropertiesForErrorMessages);
        }
    }

    [TestClass]
    public class Attribute
    {
        private readonly IRoot check = new CheckDecimalTag();

        [TestMethod]
        public void Param_CheckDecimalTag_CheckCategory() => Generic.CheckCategory(check, Category.Param);

        [TestMethod]
        public void Param_CheckDecimalTag_CheckId() => Generic.CheckId(check, CheckId.CheckDecimalTag);
    }
}