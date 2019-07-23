using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using PhotonTheme.Shared.Controls.Enums;

namespace PhotonTheme.Shared.Controls.Fields
{
    public interface IVerificationField
    {
        bool IsError { get; set; }

        bool IsSuccess { get; set; }

        Func<string, VerificationResult> VerificationFunction { get; set; }

        bool Verify();
    }
}
