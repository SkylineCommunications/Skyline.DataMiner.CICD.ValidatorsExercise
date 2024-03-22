namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.Params.Param.Display.Decimals.CheckDecimalsTag
{
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common.Attributes;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common.Extensions;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    [Test(CheckId.CheckDecimalsTag, Category.Param)]
    internal class CheckDecimalsTag : IValidate
    {
        public List<IValidationResult> Validate(ValidatorContext context)
        {
            List<IValidationResult> results = new List<IValidationResult>();

            foreach (var param in context.EachParamWithValidId())
            {
                var displayTag = param.Display;

                // Early return pattern. Only check when there is a Display tag.
                if (displayTag == null) continue;

                // Only check number types.
                if (!param.IsNumber()) continue;

                // Only check if date or datetime parameter
                if (!param.IsDateTime()) continue;

                // Verify valid decimals.
                var decimalsTag = param.Display?.Decimals;
                if (decimalsTag?.Value != 8)
                {
                    var positionNode = decimalsTag ?? (IReadable)displayTag;
                    results.Add(Error.InvalidDecimalsForDatetime(this, param, positionNode, param.Id.RawValue));
                }
            }

            return results;
        }
    }
}