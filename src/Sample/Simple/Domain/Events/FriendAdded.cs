﻿using MiniDDD;
using System;

namespace DDD.Simple.Domain.Events
{
    public class FriendAdded : DomainEvent
    {
        public Guid FriendUserId { get; set; }
        public FriendAdded(object aggregateRootKey, Guid friendUserId) : base(aggregateRootKey)
        {
            FriendUserId = friendUserId;
        }
    }
}
