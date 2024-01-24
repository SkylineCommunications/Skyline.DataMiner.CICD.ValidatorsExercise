namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Decimals.CheckDecimalTag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common.Attributes;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common.Extensions;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    [Test(CheckId.CheckDecimalTag, Category.Param)]
    internal class CheckDecimalTag : IValidate
    {
        // Please comment out the interfaces that aren't used together with the respective methods.

        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (var p in context.EachParamWithValidId())
            {
                // Early Return pattern. Only check number types.
                if (p?.Measurement?.Type?.Value != Models.Protocol.Enums.EnumParamMeasurementType.Number) continue;

                // Only check if there are options.
                var allOptions = p?.Measurement?.Type?.Options?.Value?.Split(';');
                if (allOptions == null) continue;

                // Is there an option involving date or datetime?
                List<string> possibleLowerCaseDateSyntax = new List<string>() { "date", "datetime", "datetime:minute" };
                bool foundDateTime = Array.Exists(allOptions, option => possibleLowerCaseDateSyntax.Contains(option.ToLower()));

                // Verify valid decimals.
                var decimalsTag = p.Display?.Decimals;
                if (foundDateTime && decimalsTag?.Value != 8)
                {
                    results.Add(Error.InvalidTagForDateTime(this, p, decimalsTag, "Protocol.Params.Param.Display.", "8", "datetime parameter", p.Id.RawValue));
                }
            }

            return results;
        }
    }
}