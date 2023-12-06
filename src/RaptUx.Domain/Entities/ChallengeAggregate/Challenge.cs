using System;
using System.Collections.Generic;
using RaptUx.Entities.UserAggregate;
using Volo.Abp.Domain.Entities;

namespace RaptUx.Entities.ChallengeAggregate;

public class Challenge: Entity<int>
{
    public required string Brief { get; set; }
    public required DateTime LimitedTime { get; set; }
    public required IEnumerable<User> Users { get; set; }
}