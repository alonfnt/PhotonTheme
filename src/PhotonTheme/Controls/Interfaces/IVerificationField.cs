using System;

namespace PhotonTheme.Controls
{
    public interface IVerificationField
    {
        bool IsError { get; set; }

        bool IsSuccess { get; set; }

        Func<string, VerificationResult> VerificationFunction { get; set; }

        bool Verify();
    }
}
