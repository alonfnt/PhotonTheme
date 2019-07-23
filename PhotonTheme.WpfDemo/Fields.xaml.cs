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
using PhotonTheme.Shared.Controls.Enums;

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

            VerificationBox.VerificationFunction = Verify;
        }

        private VerificationResult Verify(string arg)
        {
            if (arg.ToLowerInvariant().Equals("success")) return VerificationResult.Success;
            if (arg.ToLowerInvariant().Equals("error")) return VerificationResult.Fail;

            return VerificationResult.None;
        }
    }
}
