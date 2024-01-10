using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmweb.Carousel
{
    public class CarouselViewModel : ObservableObject
    {
        public ObservableCollection<CarouselItem> CarouselItems { get; set; } = new();

        public CarouselViewModel()
        {
            CarouselItems.Add(new CarouselItem()
            {
                Title = "Title1",
                Description = "Description1",
                ImageURL = "https://www.syncfusion.com/blogs/wp-content/uploads/2023/01/Exploring-the-New-.NET-MAUI-Backdrop.png"
            });

            CarouselItems.Add(new CarouselItem()
            {
                Title = "Title2",
                Description = "Description2",
                ImageURL = "https://www.syncfusion.com/blogs/wp-content/uploads/2023/01/Exploring-the-New-.NET-MAUI-Backdrop.png"
            });

            CarouselItems.Add(new CarouselItem()
            {
                Title = "Title3",
                Description = "Description3",
                ImageURL = "https://www.syncfusion.com/blogs/wp-content/uploads/2023/01/Exploring-the-New-.NET-MAUI-Backdrop.png"
            });

        }
    }
}
