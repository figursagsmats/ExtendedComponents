using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace TestMan.ViewModels
{
	public class ButtonPageViewModel : BindableBase
	{
        ColorTypeConverter colorTypeConverter = new ColorTypeConverter();

        private double _targetHeightRequest;
        private double _targetWidthRequest;
        private double _targetFontSize;
        private double _targetBorderWidth;
        private double _targetBorderRadius;
        public double TargetHeightRequest
        {
            get { return _targetHeightRequest; }
            set { SetProperty(ref _targetHeightRequest, value); }
        }
        public double TargetWidthRequest
        {
            get { return _targetWidthRequest; }
            set { SetProperty(ref _targetWidthRequest, value); }
        }
        public double TargetFontSize
        {
            get { return _targetFontSize; }
            set { SetProperty(ref _targetFontSize, value); }
        }


        public double TargetBorderWidth
        {
            get { return _targetBorderWidth; }
            set { SetProperty(ref _targetBorderWidth, value); }

        }


        public double TargetBorderRadius
        {
            get { return _targetBorderRadius; }
            set { SetProperty(ref _targetBorderRadius, value); }

        }

        public IList<string> ColorNames
        {
            get
            {
                return typeof(Color).GetRuntimeFields()
                                    .Where(f => f.IsPublic && f.IsStatic)
                                    .Select(f => f.Name).ToList();
            }
        }

        string selectedBackgroundColorName;
        public string SelectedBackgroundColorName
        {
            get { return selectedBackgroundColorName; }
            set
            {
                if (selectedBackgroundColorName != value)
                {
                    selectedBackgroundColorName = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("SelectedBackgroundColor");
                }
            }
        }
        public Color SelectedBackgroundColor
        {
            get
            {
                if (string.IsNullOrWhiteSpace(selectedBackgroundColorName))
                {
                    return Color.Default;
                }
                return (Color)colorTypeConverter.ConvertFromInvariantString(selectedBackgroundColorName);
            }
        }

        string selectedBorderColorName;
        public string SelectedBorderColorName
        {
            get { return selectedBorderColorName; }
            set
            {
                if (selectedBorderColorName != value)
                {
                    selectedBorderColorName = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged("SelectedBorderColor");
                }
            }
        }

        public Color SelectedBorderdColor
        {
            get
            {
                if (string.IsNullOrWhiteSpace(selectedBorderColorName))
                {
                    return Color.Default;
                }
                return (Color)colorTypeConverter.ConvertFromInvariantString(selectedBorderColorName);
            }
        }
        public ButtonPageViewModel()
        {
            TargetHeightRequest = 40;
            TargetWidthRequest = 150;
            TargetFontSize = 15;
            TargetBorderWidth = 2;
            TargetBorderRadius = 10;
            
        }
	}
}
