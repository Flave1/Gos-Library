using GOSLibraries.GOS_API_Response;
using MediatR;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GOSLibraries.GOS_Financial_Identity
{
    public class UserLoginReqObj
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class AuthFailedResponse
    {
        public APIResponseStatus Status { get; set; }
    }

    public class AuthSuccessResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public APIResponseStatus Status { get; set; }
    }
    public class UserPermission
    {
        public string UserId { get; set; }
        public IEnumerable<string> UserRoleIds { get; set; }
        public IEnumerable<string> UserRoleNames { get; set; }
        public IEnumerable<string> RoleActivityNames { get; set; }
    }
    public class UserPermissionRespObj
    {
        public UserPermission UserPermission { get; set; }
        public APIResponseStatus Staus { get; set; }
    }

    public class UserRegistrationReqObj : IRequest<AuthResponse>
    {

        public string UserName { get; set; }
        public string Email { get; set; } 
        public string FulName { get; set; } 
        public string MobileNumber { get; set; } 
        public string Password { get; set; }
    }


    public class ChangePassword
    {
        [EmailAddress]
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }

    

    public class UserRefreshTokenReqObj
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
      
    public class ConfirnmationRequest
    {
        public string Email { get; set; }
        public string Code { get; set; }
        public APIResponseStatus Status { get; set; }
    }

    public class ConfirnmationResponse
    {
        public string Email { get; set; }
        public APIResponseStatus Status { get; set; }
    }

    public class AuthenticationResult
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public APIResponseStatus Status { get; set; }
    }
    public class AuthResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public APIResponseStatus Status { get; set; }
    }

    public class LoginCommand : IRequest<AuthResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; } 
    }

    //public class RefreshTokenCommand : IRequest<AuthResponse>
    //{
    //    public string Token { get; set; }
    //    public string Re { get; set; }
    //}

    public class LogoutCommand : IRequest<AuthResponse> { }


    public class OTPLoginCommand : IRequest<AuthResponse>
    {
        public OTPLoginCommand() { }
        public string OTP { get; set; } 
        public string Email { get; set; }
        public OTPLoginCommand(string otp, string email) 
        { OTP = otp; Email = email; }
    }

}
