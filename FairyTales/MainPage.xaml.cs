
using FairyTales.Models;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace FairyTales
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<FairyTale> FairyTales { get; set; }

        public ObservableCollection<FairyTale> FairyTales2 { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ModifySearchBar();
            InitializeTales();
            BindingContext = this;
        }

        private void InitializeTales()
        {
            FairyTales =
            [
                new() { Name = "Cinderella", ReadTime = new TimeSpan(0, 30, 0), Image = "cinderella.png" },
                new() { Name = "Snow White", ReadTime = new TimeSpan(0, 25, 0), Image = "snow.png" },
                new() { Name = "Rapunzel", ReadTime = new TimeSpan(0, 20, 0), Image = "rapunzel.png" },
                new() { Name = "Little Red Riding Hood", ReadTime = new TimeSpan(0, 15, 0), Image = "hood.png" },
                new() { Name = "Beauty and the beats", ReadTime = new TimeSpan(0, 30, 0), Image = "beauty.png" }
            ];

            FairyTales2 =
                [
                    new() { Name = "Snow White", ReadTime = new TimeSpan(0, 25, 0), Image = "snow.png" },
                    new() { Name = "Rapunzel", ReadTime = new TimeSpan(0, 20, 0), Image = "rapunzel.png" },
                    new() { Name = "Little Red Riding Hood", ReadTime = new TimeSpan(0, 15, 0), Image = "hood.png" },
                    new() { Name = "Beauty and the beats", ReadTime = new TimeSpan(0, 30, 0), Image = "beauty.png" },
                    new() { Name = "Cinderella", ReadTime = new TimeSpan(0, 30, 0), Image = "cinderella.png" },

                ];

        }

        private void ModifySearchBar()
        {
            SearchBarHandler.Mapper.AppendToMapping("CustomSearchIconColor", (handler, view) =>
            {

#if ANDROID
                var context = handler.PlatformView.Context;
                var seachIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
                if (seachIconId != 0)
                {
                    var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(seachIconId);
                    searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157, 185), Android.Graphics.PorterDuff.Mode.DstIn);
                }
#endif
            });
        }
    }

}
