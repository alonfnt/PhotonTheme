using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Effects;

namespace PhotonDesign.Wpf.Converters
{
    internal static class ShadowInfo
    {
        private static readonly IDictionary<ShadowDepth, DropShadowEffect> ShadowsDictionary;

        static ShadowInfo()
        {
            var resourceDictionary = new ResourceDictionary { Source = new Uri("pack://application:,,,/PhotonDesign.Wpf;component/Themes/PhotonDesign.Shadows.xaml", UriKind.Absolute) };

            ShadowsDictionary = new Dictionary<ShadowDepth, DropShadowEffect>
            {
                { ShadowDepth.Depth0, null },
                { ShadowDepth.Depth1, (DropShadowEffect)resourceDictionary["ShadowDepth1"] },
                { ShadowDepth.Depth2, (DropShadowEffect)resourceDictionary["ShadowDepth2"] },
                { ShadowDepth.Depth3, (DropShadowEffect)resourceDictionary["ShadowDepth3"] },
                { ShadowDepth.Depth4, (DropShadowEffect)resourceDictionary["ShadowDepth4"] },
                { ShadowDepth.Depth5, (DropShadowEffect)resourceDictionary["ShadowDepth5"] },
            };
        }

        public static DropShadowEffect GetDropShadow(ShadowDepth depth)
        {
            return ShadowsDictionary[depth];
        }
    }
}