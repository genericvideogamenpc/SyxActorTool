using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using Avalonia.Themes.Fluent;

namespace SyxActorTool;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();
        InitializeThemeSelection();
    }


    private void InitializeThemeSelection()
    {
        var app = Application.Current;
        if (app == null) return;

        var current = app.ActualThemeVariant;

        ThemeComboBox.SelectedIndex = current == ThemeVariant.Light ? 1 :
                                      current == ThemeVariant.Dark  ? 2 :
                                                                      0;
    }

    private void ThemeSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        var app = Application.Current;
        if (app == null) return;

        var fluentTheme = app.Styles.OfType<FluentTheme>().FirstOrDefault();
        if (fluentTheme == null) return;

        switch (ThemeComboBox.SelectedIndex)
        {
            case 0:
                app.RequestedThemeVariant = ThemeVariant.Default;
                break;
            case 1:
                app.RequestedThemeVariant = ThemeVariant.Light;
                break;
            case 2:
                app.RequestedThemeVariant = ThemeVariant.Dark;
                break;
        }
    }
}