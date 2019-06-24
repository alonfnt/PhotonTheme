# PhotonTheme
This is a Toolkit that tries to help on the modernization of WPF applications. 
The inital inspiration for this Design can be found in: [UI Design System](https://uidesignsystem.com/desktop.html)

A lot of the controls I based them on the [Material Design Library](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit), which has done an excelent job on bringing the [Material Design](https://material.io/design/) to WPF.

## Getting Started


+ Install the Nuget Package (*Pending*)
+ In the App.xaml file, add the followinf ResourceDictionary:
```
<Application . . . >
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/PhotonDesign.Wpf;component/Themes/PhotonDesign.Defaults.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```
+ You can start using all the styles and controls of the Toolkit now. 

## Demo (*Pending*)
Every realease comes with a precompile demo to test all the styles. You can dowload it here: (*missing*)

(*Add Screenshots of the Demo*)

## Contributing

Please read (*missing*) for details on our code of conduct, and the process for submitting pull requests to us.

## Styles discussions

| Control| Discussion Issue | Status | Wiki
| --- | --- | --- | ---
| Colors | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/1) | In Progress | 
| Typography | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/2) | In Progress |
| Icons | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/3) | In Progress |
| Alerts | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/4) | Pending |
| Avatars | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/5) | Pending |
| Buttons | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/6) | In Progress |
| Badges | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/7) | Pending |
| Combobox | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/8) | Pending |
| PopupBox | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/8) | Pending |
| TextBox |[Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/9) | Pending |
| PasswordBox | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/9) | Pending |
| CheckBox | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/9) | Pending |
| RadioButton | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/9) | Pending |
| ToggleButton | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/9) | Pending |
| Headers | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/10) | Pending |
| ProgressBar | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/11) | Pending |
| Slider | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/12) | Pending |
| Table | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/13) | Pending |
| TabControl | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/14) | Pending |
| Tooltip | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/15) | Pending |
| DateTimePicker | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/16) | Pending |
| Dialog | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/17) | Pending |
| Notifications | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/18) | Pending |
| Navigation | [Open Issue](https://github.com/AlbertAlonso/PhotonDesignTheme/issues/19) | Pending |

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
