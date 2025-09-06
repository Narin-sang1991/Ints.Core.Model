using Ints.Core.Model.Enums;

namespace Ints.Core.Model
{
    public record AppConfigurationRequestModel
    {
        public Guid? Id { get; init; }
        public string Code { get; init; }
        public string? Name { get; init; }
        public string? Description { get; init; }
        public ConfigType ValueTypeEnum { get; init; }
        public string ConfigurationValue { get; init; }
    }
}
