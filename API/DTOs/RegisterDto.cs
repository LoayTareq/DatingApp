using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public string DisplayName { get; set; } = "";
    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";
    [Required]
    [MinLength(4)]
    public string Password { get; set; } = "";
}
