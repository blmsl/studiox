using System.ComponentModel.DataAnnotations;
using StudioX.Auditing;
using StudioX.Authorization.Users;
using StudioX.AutoMapper;
using StudioX.Boilerplate.Authorization.Users;

namespace StudioX.Boilerplate.Users.Dto
{
    [AutoMap(typeof(User))]
    public class CreateUserInput 
    {
        [Required]
        [StringLength(StudioXUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [Required]
        [StringLength(StudioXUserBase.MaxFirstNameLength)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [Required]
        [StringLength(StudioXUserBase.MaxLastNameLength)]
        public string LastName { get; set; }

        /// <summary>
        ///  Email address of the user.
        /// </summary>
        [Required]
        [EmailAddress]
        [StringLength(StudioXUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [StringLength(StudioXUserBase.MaxPhoneNumberLength)]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        ///  Password of the user.
        /// </summary>
        [Required]
        [StringLength(StudioXUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        public string[] RoleNames { get; set; }
    }
}