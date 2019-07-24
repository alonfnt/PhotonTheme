using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PhotonTheme.Controls;

namespace PhotonTheme.WpfDemo
{
    /// <summary>
    /// Interaction logic for Fields.xaml
    /// </summary>
    public partial class Fields : UserControl
    {
        public Fields()
        {
            InitializeComponent();

            VerificationBox.VerificationFunction = VerifyPrefix;
            VerificationBoxFocus.VerificationFunction = VerifyText;
        }

        private static VerificationResult VerifyText(string arg)
        {
            if (arg.ToLowerInvariant().Equals("success")) return VerificationResult.Success;
            if (arg.ToLowerInvariant().Equals("error")) return VerificationResult.Fail;

            return VerificationResult.None;
        }

        private static VerificationResult VerifyPrefix(string arg)
        {
            if (arg.StartsWith("pre")) return VerificationResult.Success;
            if (arg.StartsWith("post")) return VerificationResult.Fail;

            return VerificationResult.None;
        }
    }
}
