using Gaia.Places.XamLibs.ExtendedComponents.Abstractions;
using System;
using Xamarin.Forms;
using Gaia.Places.XamLibs.ExtendedComponents.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ExtendedComponents.Abstractions.ExtendedButton), typeof(ExtendedButtonRenderer))]
namespace Gaia.Places.XamLibs.ExtendedComponents.Android
{
    /// <summary>
    /// ExtendedComponents Renderer
    /// </summary>
    /// 
    public class ExtendedButtonRenderer : ButtonRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        ExtendedButton _element;

        public static void Init() { }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            System.Diagnostics.Debug.WriteLine(">>>>>>>>> OnElementChanged:  ExtendedButtonButtonRenderer <<<<<<<<");

            _element = (ExtendedButton)this.Element;
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                //Subrscribe to the events stuff
            }
            else if (e.OldElement != null)
            {
                //Unsubscribe from events
            }

        }
    }
}