namespace Armar.Core
{
    public class CSharpConfig
    {
        public required string NameSpace { get; set; } = "SampleCompany.ApplicationName.API";
        public required string ModelsNameSpace { get; set; } = "SampleCompany.ApplicationName.API.Models";
        public required string BusinessLogicNameSpace { get; set; } = "SampleCompany.ApplicationName.API.BusinessLogic";
        public required string ValidationNameSpace { get; set; } = "SampleCompany.ApplicationName.API.Validation";
    }
}