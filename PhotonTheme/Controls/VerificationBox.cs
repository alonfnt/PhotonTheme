using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PhotonTheme.Controls
{
    public sealed class VerificationBox : TextBox, IVerificationField
    {

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);
            if (VerificationFunction != null && VerificationTrigger == BindingUpdateTrigger.OnPropertyChanged)
            {
                Verify();
            }
        }

        protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            base.OnLostKeyboardFocus(e);
            if (VerificationFunction != null && VerificationTrigger == BindingUpdateTrigger.LostFocus)
            {
                Verify();
            }
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

        #region VerificationTrigger

        public BindingUpdateTrigger VerificationTrigger
        {
            get => (BindingUpdateTrigger)GetValue(VerificationTriggerProperty);
            set => SetValue(VerificationTriggerProperty, value);
        }

        public static readonly DependencyProperty VerificationTriggerProperty =
            DependencyProperty.Register(nameof(VerificationTrigger), typeof(BindingUpdateTrigger), typeof(VerificationBox), new PropertyMetadata(BindingUpdateTrigger.OnPropertyChanged));

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
