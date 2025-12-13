using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Ints.Core.Model
{
    [DataContract]
    [Serializable]
    public record UserProfile
    {
        [DataMember]
        public Guid UserId { get; init; }

        [DataMember]
        public string Name { get; init; }

        [DataMember]
        public IEnumerable<string>? Roles { get; init; }

        [DataMember]
        public IEnumerable<int>? RoleLevels { get; init; }

        [DataMember]
        public IEnumerable<string>? Scopes { get; init; }

        [DataMember]
        public string? SourceIP { get; init; }

        [DataMember]
        public IEnumerable<MenuDataWithChildModel>? MenuWithChilds { get; init; }
    }
}
