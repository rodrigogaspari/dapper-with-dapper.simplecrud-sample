﻿using Dapper;

namespace Sample.Dapper.Persistence.Entities;

public abstract class BaseEntity
{
    [Key]
    public long EntityId { get; set; }
}
