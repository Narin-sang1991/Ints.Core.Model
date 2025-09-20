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
        public ReadOnlyCollection<string> RoleCodes { get; init; }

        [DataMember]
        public string Name { get; init; }

        [DataMember]
        public string Realm { get; init; }

        [DataMember]
        public string? SourceIP { get; init; }
    }
}
