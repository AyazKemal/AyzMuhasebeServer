﻿namespace AyzMuhasebeServer.Domain.AppEntities.Abstractions
{
    public abstract class Entity
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set;}
    }
}