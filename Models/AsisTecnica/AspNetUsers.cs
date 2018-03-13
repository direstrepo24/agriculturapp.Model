using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace agricultureapp.Model.Models.AsisTecnica
{
    [Table("AspNetUsers")]
    public class AspNetUsers
    {
     [Column("Id")]   
     public string Id{get;set;} // text COLLATE pg_catalog."default" NOT NULL,
     [Column("AccessFailedCount")] 
     public int  AccessFailedCount{get;set;}//" integer NOT NULL,
     
     [Column("ConcurrencyStamp")] 
     public string ConcurrencyStamp{get;set;}//" text COLLATE pg_catalog."default",
     [Column("Email")] 
     public string Email{get;set;} //character varying(256) COLLATE pg_catalog."default",
     [Column("EmailConfirmed")] 
     public bool EmailConfirmed{get;set;}// boolean NOT NULL,
     [Column("LockoutEnabled")] 
     public bool LockoutEnabled{get;set;}// boolean NOT NULL,
    [Column("LockoutEnd")] 
    public DateTimeOffset LockoutEnd{get;set;}//" timestamp with time zone,
    [Column("NormalizedEmail")] 
    public string NormalizedEmail{get;set;}// character varying(256) COLLATE pg_catalog."default",
    [Column("NormalizedUserName")] 
    public string NormalizedUserName{get;set;}// character varying(256) COLLATE pg_catalog."default",
    [Column("PasswordHash")] 
    public string PasswordHash{get;set;}// text COLLATE pg_catalog."default",
     [Column("PhoneNumber")]     
    public string PhoneNumber{get;set;}// text COLLATE pg_catalog."default",
    [Column("PhoneNumberConfirmed")]   
    public bool PhoneNumberConfirmed{get;set;}// boolean NOT NULL,
    [Column("SecurityStamp")]  
    public string SecurityStamp{get;set;}// text COLLATE pg_catalog."default",
    [Column("TwoFactorEnabled")]  
    public bool TwoFactorEnabled{get;set;}// boolean NOT NULL,
    
    [Column("UserName")]  
    public string UserName{get;set;}// character varying(256) COLLATE pg_catalog."default",
    
    [Column("TelefonoMovil")]  
    public string TelefonoMovil{get;set;}// text COLLATE pg_catalog."default",
    }
}