using System.ComponentModel.DataAnnotations;

namespace Mowrer.WVCC.Challenges.PasswordGenerator.Data;

public class PasswordOptionsModel
{
    [Required]
    [Range(8, 127, ErrorMessage = "Password length must be at least 8 and no more than 127.")]
    public int? Length { get; set; }
    
    [Required]
    public bool WithDigits { get; set; }
    
    [Required]
    public bool WithSymbols { get; set; }
}