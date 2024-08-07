﻿using System.Text.Json.Serialization;

#pragma warning disable
namespace DataLayer.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; }    
    }
}
