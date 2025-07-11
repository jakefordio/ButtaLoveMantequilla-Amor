// using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Mvc;
//
// namespace ButtaLove.ViewModels;
//
// public class  UserProfileViewModel
// {
//     #region Google
//     public string? GoogleReCaptchaResponseToken { get; set; }
//     #endregion
//     
//     #region UserFields
//         [DataType(DataType.Text, ErrorMessage = "User Id is invalid")]
//         [Display(Name = "User Id")]
//         public string? Id { get; set; }
//
//         [Display(Name = "UserName (Email)")]
//         public string? UserName
//         {
//
//             get { return UserName; }
//             set
//             {
//                 UserName = value; 
//             }
//         }
//         public string EmailAddress { get; set; }
//         [DataType(DataType.Text, ErrorMessage = "Birthday Month is Invalid")]
//         [Display(Name = "Birthday")]
//         public string? BirthDate { get; set; }
//         [DataType(DataType.Text, ErrorMessage = "First Name is Invalid")]
//         [Display(Name = "First")]
//         public string? FirstName { get; set; }
//         [DataType(DataType.Text, ErrorMessage = "Last Name is Invalid")]
//         [Display(Name = "Last")]
//         public string? LastName { get; set; }
//         [Display(Name = "Street Street")]
//         public string? AddrStreet { get; set; }
//         [Display(Name = "City")]
//         public string? AddrCity { get; set; }
//         [Display(Name = "State")]
//         public string? AddrState { get; set; }
//         [Display(Name = "Zip Code")]
//         public string? AddrZip { get; set; }
//         [Display(Name = "Last Online")]
//         public DateTime? LastSignOn { get; set; }
//         [Display(Name = "Join Date")]
//         public DateTime CreatedOn { get; set; } = DateTime.Now;
//         [Display(Name = "Online Now")]
//         public bool IsOnline { get; set; }
//         public IFormFile? ProfilePicture { get; set; }
//         [Display(Name = "Phone")]
//         public string? Phone { get; set; }
//         public bool ChangePassword { get; set; } = false;
//         [Display(Name = "Current Password")]
//         public string? CurrentPassword { get; set; }
//         [Display(Name = "New Password")]
//         public string? NewPassword { get; set; }
//         #endregion
// }