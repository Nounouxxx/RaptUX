using System.Collections.Generic;
using RaptUx.Entities.ChallengeAggregate;
using RaptUx.Entities.TagAggregate;
using Volo.Abp.Identity;

namespace RaptUx.Entities.UserAggregate;

public class User: IdentityUser
{
    public required IEnumerable<Challenge> Challenges { get; set; }
    public required IEnumerable<Tag> Tags { get; set; }
}