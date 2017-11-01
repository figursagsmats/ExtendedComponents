using Gaia.Places.XamLibs.ExtendedComponents.Abstractions;
using System;
using Xamarin.Forms;
using Gaia.Places.XamLibs.ExtendedComponents.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ExtendedComponents.Abstractions.ExtendedEntry), typeof(ExtendedEntryRenderer))]
namespace Gaia.Places.XamLibs.ExtendedComponents.Android
{
    /// <summary>
    /// ExtendedComponents Renderer
    /// </summary>
    /// 
    public class ExtendedEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        ExtendedEntry _element;

        public static void Init() { }


        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            System.Diagnostics.Debug.WriteLine("\t >>>>>> OnElementChanged:  ExtendedEntryRenderer");

            _element = (ExtendedEntry)this.Element;
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