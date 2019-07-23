using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PhotonTheme.Shared.Controls.Enums;

namespace PhotonTheme.Shared.Controls.Fields
{
    public sealed class VerificationBox : TextBox, IVerificationField
    {

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);
            if (VerificationFunction != null) Verify();
        }

        #region IsError

        public bool IsError
        {
            get => (bool)GetValue(IsErrorProperty);
            set => SetValue(IsErrorProperty, value);
        }

        public static readonly DependencyProperty IsErrorProperty =
            DependencyProperty.Register(nameof(IsError), typeof(bool), typeof(VerificationBox), new PropertyMetadata(false));

        #endregion

        #region IsSuccess

        public bool IsSuccess
        {
            get => (bool)GetValue(IsSuccessProperty);
            set => SetValue(IsSuccessProperty, value);
        }

        public static readonly DependencyProperty IsSuccessProperty =
            DependencyProperty.Register(nameof(IsSuccess), typeof(bool), typeof(VerificationBox), new PropertyMetadata(false));

        #endregion

        #region Verify

        public Func<string, VerificationResult> VerificationFunction { get; set; }

        public bool Verify()
        {
            var result = VerificationFunction?.Invoke(Text) ?? VerificationResult.None;
            switch (result)
            {
                case VerificationResult.None:
                    IsError = false;
                    IsSuccess = false;
                    return false;
                case VerificationResult.Fail:
                    IsError = true;
                    IsSuccess = false;
                    return true;
                case VerificationResult.Success:
                    IsError = false;
                    IsSuccess = true;
                    return true;
            }
            return false;
        }

        #endregion
    }
}
