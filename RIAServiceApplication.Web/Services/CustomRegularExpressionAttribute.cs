using System;

namespace System.ComponentModel.DataAnnotations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class CustomRegularExpressionAttribute : RegularExpressionAttribute
    {
        public CustomRegularExpressionAttribute(string pattern) : base(pattern) { }

        public int MatchTimeoutInMilliseconds { get; set; }
    }
}