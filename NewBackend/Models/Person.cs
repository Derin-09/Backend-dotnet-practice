using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace NewBackend.Models;


public class Person
{
    public int Id { get; set; }

    [Required]
    [MaxLength(30)]
    public string Fullname { get; set; } = string.Empty;

    [Required]
    [MinLength(8)]
    [MaxLength(100)]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).+$",
        ErrorMessage = "Password must contain upper, lower, number, and special character")]
        
    public string Password { get; set; } = string.Empty;
}
