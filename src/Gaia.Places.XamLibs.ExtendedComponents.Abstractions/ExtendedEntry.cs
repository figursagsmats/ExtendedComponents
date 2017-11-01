using System;
using Xamarin.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Xamarin.Forms.Internals;

namespace Gaia.Places.XamLibs.ExtendedComponents.Abstractions
{
    /// <summary>
    /// ExtendedComponents Interface
    /// </summary>
    public class ExtendedEntry : Entry
    {
        public static readonly Color NOT_YET_SET_COLOR = default(Color);
        private const double IosTopAndBottomPaddingFactor = 1.2;
        private bool _lock;
        private double _lastInternalHeightRequestValue;

        private bool _heightNotRequested;
        public bool HeightNotRequested
        {
            get
            {
                Debug.WriteLine(":::: _heightNotRequested RETURNED: " + _heightNotRequested);
                return _heightNotRequested;
            }
            set
            {

                _heightNotRequested = value;
                Debug.WriteLine(":::: _heightNotRequested SET: " + _heightNotRequested);
            }
        }
        private bool _isInitialized;
        public bool IsInitialized
        {
            get
            {
                Debug.WriteLine("---- IsInitialized RETURNED: " + _isInitialized);
                return _isInitialized;
            }
            set
            {

                _isInitialized = value;
                Debug.WriteLine("---- IsInitialized SET: " + _isInitialized);
            }
        }
        public ExtendedEntry()
        {
            //TextColor = Color.Black;
            //PlaceholderColor = Color.Gray;
            //BackgroundColor = Color.White;
            _isInitialized = false;
            HeightNotRequested = true;
            _lastInternalHeightRequestValue = -1;
        }
        public object GetPropertyValue(string propName)
        {
            Type type = this.GetType();
            System.Reflection.PropertyInfo info = type.GetProperty(propName);
            if (info == null) { return null; }

            return info.GetValue(this);
        }

        private void RequestNewHeight()
        {
            if (FontSize > 0)
            {
                var newHeight = FontSize * IosTopAndBottomPaddingFactor;
                Debug.WriteLine(">>>> Requested New Height:  FontSize: " + FontSize + " | newHeight: " + newHeight);
                _lastInternalHeightRequestValue = newHeight;
                //HeightRequest = newHeight;
            }
            else
            {
                Debug.WriteLine(">>>> Did NOT request new height");
            }

        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == ExtendedEntry.FontSizeProperty.PropertyName
                || propertyName == HeightRequestProperty.PropertyName
                || propertyName == WidthRequestProperty.PropertyName
                || propertyName == WidthProperty.PropertyName
                || propertyName == HeightProperty.PropertyName)
            {
                Debug.WriteLine("PROPERTY => " + propertyName + " changed to " + GetPropertyValue(propertyName));
            }

            if (propertyName == ExtendedEntry.HeightRequestProperty.PropertyName)
            {

                Debug.WriteLine("\t last internal HeightRequest: " + _lastInternalHeightRequestValue);
                Debug.WriteLine("\t HeightRequest: " + HeightRequest);

                if (_lastInternalHeightRequestValue != HeightRequest)
                {
                    Debug.WriteLine("\t NOT SAME => setting HeightNotRequested to false");

                    HeightNotRequested = false;
                }
                else
                {
                    Debug.WriteLine("\t SAME => no height request from outside");
                }

            }

            if (propertyName == ExtendedEntry.FontSizeProperty.PropertyName)
            {

                if (HeightNotRequested && IsInitialized)
                {
                    RequestNewHeight();
                }

            }

            base.OnPropertyChanged(propertyName);
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            Debug.WriteLine(">>>> OnSizeAllocated || (w,h): " + width + ", " + height + ")");
            //base.OnSizeAllocated(width, height);

            if (!IsInitialized && HeightNotRequested)
            {
                Debug.WriteLine("\t  => requesting new height!!");
                RequestNewHeight();
                _isInitialized = true;
            }
            else
            {
                Debug.WriteLine("\t => not requesting new height");
            }
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            Debug.WriteLine(">>>> OnMeasure || (wc,hc) = (" + widthConstraint + ", " + heightConstraint + ")");
            return base.OnMeasure(widthConstraint, heightConstraint);
        }

        #region BorderRadiusProperty
        public static readonly BindableProperty BorderRadiusProperty =
            BindableProperty.Create(nameof(BorderRadius), typeof(int), typeof(ExtendedEntry), 10, propertyChanged: OnBorderRadiusChanged);

        private static void OnBorderRadiusChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((ExtendedEntry)bindable).OnBorderRadiusChanged((int)oldValue, (int)newValue);
        }

        void OnBorderRadiusChanged(int oldValue, int newValue)
        {
            ;
            Debug.WriteLine(">>>>>>>>> OnBorderRadiusChanged: ExtendedEntry <<<<<<<<");
        }
        public int BorderRadius
        {
            get { return (int)base.GetValue(BorderRadiusProperty); }
            set { base.SetValue(BorderRadiusProperty, value); }
        }
        #endregion

        #region BorderWidthProperty
        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidth), typeof(double), typeof(ExtendedEntry), 1.0, propertyChanged: OnBorderWidthChanged);

        private static void OnBorderWidthChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((ExtendedEntry)bindable).OnBorderWidthChanged((double)oldValue, (double)newValue);
        }

        void OnBorderWidthChanged(double oldValue, double newValue)
        {
            ;
        }
        public double BorderWidth
        {
            get { return (double)base.GetValue(BorderWidthProperty); }
            set { base.SetValue(BorderWidthProperty, value); }
        }
        #endregion

        #region BorderColorProperty
        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(ExtendedEntry), Color.Black, propertyChanged: OnBorderColorChanged);

        private static void OnBorderColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((ExtendedEntry)bindable).OnBorderColorChanged((Color)oldValue, (Color)newValue);
        }

        void OnBorderColorChanged(Color oldValue, Color newValue)
        {
            ;
        }
        public Color BorderColor
        {
            get { return (Color)base.GetValue(BorderColorProperty); }
            set { base.SetValue(BorderColorProperty, value); }
        }
        #endregion

        #region TextFocusColorProperty
        public static readonly BindableProperty TextFocusColorProperty =
            BindableProperty.Create(nameof(TextFocusColor), typeof(Color), typeof(ExtendedEntry), NOT_YET_SET_COLOR, propertyChanged: OnTextFocusColorChanged);

        private static void OnTextFocusColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((ExtendedEntry)bindable).OnTextFocusColorChanged((Color)oldValue, (Color)newValue);
        }

        void OnTextFocusColorChanged(Color oldValue, Color newValue)
        {
            ;
        }
        public Color TextFocusColor
        {
            get { return (Color)base.GetValue(TextFocusColorProperty); }
            set { base.SetValue(TextFocusColorProperty, value); }
        }
        #endregion

        #region BackgroundFocusColorProperty
        public static readonly BindableProperty BackgroundFocusColorProperty =
            BindableProperty.Create(nameof(BackgroundFocusColor), typeof(Color), typeof(ExtendedEntry), NOT_YET_SET_COLOR, propertyChanged: OnBackgroundFocusColorChanged);

        private static void OnBackgroundFocusColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((ExtendedEntry)bindable).OnBackgroundFocusColorChanged((Color)oldValue, (Color)newValue);
        }

        void OnBackgroundFocusColorChanged(Color oldValue, Color newValue)
        {

            ;
        }
        public Color BackgroundFocusColor
        {
            get { return (Color)base.GetValue(BackgroundFocusColorProperty); }
            set { base.SetValue(BackgroundFocusColorProperty, value); }
        }
        #endregion
    }
}
