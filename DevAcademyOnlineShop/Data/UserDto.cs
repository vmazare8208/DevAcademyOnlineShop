using System.ComponentModel.DataAnnotations;

namespace DevAcademyOnlineShop.Data
{
    public record  UserDto(
        [Required][StringLength(maximumLength: 100)] string FirstName,
        [Required][StringLength(maximumLength: 100)] string LastName,
        [Required][EmailAddress][StringLength(maximumLength: 200)] string Email,
        [Required][StringLength(maximumLength: 100)] string PasswordHash,
        [Required][StringLength(maximumLength: 15)] string PhoneNumber
    );
}
