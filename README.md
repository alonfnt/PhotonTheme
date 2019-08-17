# PhotonTheme [ In development ]

This is a Toolkit that tries to help on the modernization of WPF applications. 
The inital inspiration for this Design can be found in: [UI Design System](https://uidesignsystem.com/desktop.html)

Some base controls and mostly the icon pack is from [Material Design Library](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit), which has done an excelent job on bringing the [Material Design](https://material.io/design/) to WPF.

This library currently works with **.Net Core 3.0**. 

[![Nuget](https://img.shields.io/nuget/v/PhotonTheme?color=blue&label=nuget)](https://www.nuget.org/packages/PhotonTheme/)
[![MIT license](http://img.shields.io/badge/license-MIT-brightgreen.svg)](http://opensource.org/licenses/MIT)

## Styles and Controls

<table>
<tr>
<td><a href="../../wiki/Alert">Alert</a></td>
<td><a href="../../wiki/Avatar">Avatar</a></td>
<td><a href="../../wiki/Badge">Badge</a></td>
<td><a href="../../wiki/Button">Button</a></td>
</tr>
<tr>
<td><a href="../../wiki/CheckBox">CheckBox</a></td>
<td><a href="../../wiki/Colors">Colors</a></td>
<td><a href="../../wiki/ComboBox">ComboBox</a></td>
 <td><a href="../../wiki/DataGrid">DataGrid</a></td>
</tr>
<tr>
<td><a href="../../wiki/DateTimePicker">DateTimePicker</a></td>
<td><a href="../../wiki/Dialog">Dialog</a></td>
<td><a href="../../wiki/Header">Header</a></td>
<td><a href="../../wiki/Icons">Icons</a></td>
</tr>
<tr>
<td><a href="../../wiki/Navigation">Navigation</a></td>
<td><a href="../../wiki/Notifications">Notifications</a></td>
<td><a href="../../wiki/PasswordBox">PasswordBox</a></td>
<td><a href="../../wiki/PopupBox">PopupBox</a></td>
</tr>
<tr>
<td><a href="../../wiki/ProgressBar">ProgressBar</a></td>
<td><a href="../../wiki/RadioButton">RadioButton</a></td>
<td><a href="../../wiki/Slider">Slider</a></td>
<td><a href="../../wiki/TabControl">TabControl</a></td>
</tr>
<tr>
<td><a href="../../wiki/TextBlock">TextBlock</a></td>
<td><a href="../../wiki/TextBox">TextBox</a></td>
<td><a href="../../wiki/ToggleButton">ToggleButton</a></td>
<td><a href="../../wiki/Tooltip">Tooltip</a></td>
</tr>
 <tr>
<td><a href="../../wiki/VerificationBox">VerificationBox</a></td>
 </tr> 
</table>

## Getting Started


1. Install the Nuget Package 
 
 `Install-Package PhotonTheme`

2. In the App.xaml file, add the following ResourceDictionary:
```
<Application . . . >
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/PhotonTheme;component/Themes/Defaults.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```
3. You can start using all the styles and controls of the Toolkit now. 


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
