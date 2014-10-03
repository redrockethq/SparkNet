using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlitBit.Dto;

namespace SparkNet.Common.Dtos.Databases
{
    [DTO]
    public interface IDatabaseUser
    {
        [Required]
        string Username { get; set; }

        string Password { get; set; }

        bool Active { get; set; }
    }

    [DTO]
    public interface ICreateDatabase : IBasicDatabase, IDatabaseUser
    {
        
    }
    
    [DTO] 
    public interface ICreateWithUsersDatabase : IBasicDatabase
    {
        List<IDatabaseUser> Users { get; set; }
    }
}