# PhotonDesignThemeXaml
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

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
