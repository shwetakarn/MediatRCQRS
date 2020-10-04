using System.ComponentModel.DataAnnotations;
using System;

namespace AspNetCoreMediatRSample.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}