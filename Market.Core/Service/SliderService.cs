using Market.Core.Interface;
using Market.DataLayer.Context;
using Market.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Core.Service
{
    public class SliderService : ISliderService
    {
        #region Constractor
        private readonly ApplicationContext _applicationContext;
        public SliderService(ApplicationContext applicationContext)
        {
            _applicationContext= applicationContext;
        }
        #endregion


        public int AddSlider(MainSlader slider)
        {
            try
            {
                _applicationContext.MainSladers.Add(slider);
                _applicationContext.SaveChanges();
                return slider.SliderId;
            }
            catch (Exception)
            {

               return 0;
            }
           
        }

        public bool DeleteSlider(MainSlader slider)
        {
            try
            {
                _applicationContext.Remove(slider);
                _applicationContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            
            }
        }

        public MainSlader FindSliderBuyeId(int sliderId)
        {
            return _applicationContext.MainSladers.Find(sliderId);
        }

        public List<MainSlader> ShowAllSlider()
        {
            return _applicationContext.MainSladers.ToList();
        }

        public bool UpdateSlider(MainSlader slider)
        {
            try
            {
                _applicationContext.Update(slider);
                _applicationContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
