using Gaia.Places.XamLibs.ExtendedComponents.Abstractions;
using System;
using TestMan.ViewModels;
using Xamarin.Forms;

namespace TestMan.Views
{
    public partial class EntryPage : ContentPage
    {
        private EntryPageViewModel _viewModel;
        public EntryPage()
        {

            InitializeComponent();
            _viewModel = (EntryPageViewModel)BindingContext;
        }

        private void OnWidthRequestToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.WidthRequestProperty, "WidthRequest");
        }
        private void OnHeigtRequestToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.HeightRequestProperty, "HeightRequest");
        }
        private void OnFontSizeToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.FontSizeProperty, "FontSize");
        }
        private void OnBorderWidthToggled(object sender, EventArgs e)
        {

            //ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.BorderWidthProperty, "BorderWidth");
        }
        private void OnBorderRadiusToggled(object sender, EventArgs e)
        {
            //ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.BorderRadiusProperty, "BorderRadius");
        }
        private void OnBackgroundColorNameToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.BackgroundColorProperty, "SelectedBackgroundColorName");
        }
        private void OnBorderColorNameToggled(object sender, EventArgs e)
        {
            //ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Entry.BorderColorProperty, "SelectedBorderColorName");
        }
        private void OnBackgroundFocusColorNameToggled(object sender, EventArgs e)
        {
            //ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, ExtendedEntry.BorderColorProperty, "SelectedBorderColorName");
        }

        private void ToggleBinding(bool value, string targetObjectName, BindableProperty bindableProperty, string propertyName)
        {
            Entry targetObject = this.FindByName<Entry>(targetObjectName);
            if (!propertyName.Contains("Selected"))
            {
                propertyName = "Target" + propertyName;

            }
            if (value)
            {
                targetObject.SetBinding(bindableProperty, propertyName);
            }
            else
            {
                targetObject.RemoveBinding(bindableProperty);
            }
        }
    }
}
