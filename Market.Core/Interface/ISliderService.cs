using Market.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Interface
{
    public interface ISliderService
    {
        List<MainSlader> ShowAllSlider();
        MainSlader FindSliderBuyeId(int sliderId);
        int AddSlider(MainSlader slider);
        bool UpdateSlider(MainSlader slider);   
        bool DeleteSlider(MainSlader slider);

    }
}
