using System.Collections.Generic;
using RaptUx.Entities.UserAggregate;
using Volo.Abp.Domain.Entities;

namespace RaptUx.Entities.TagAggregate;

public class Tag: Entity<int>
{
    public required TagStateEnum State { get; set; } = TagStateEnum.Child;
    public required IEnumerable<User> Users { get; set; }
}