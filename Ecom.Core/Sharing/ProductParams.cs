using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Sharing
{
    public class ProductParams
    {
        public string? sort { get; set; }
        public int? categoryId { get; set; }
        public string? search { get; set; }
        public int MaxPageSize { get; set; } = 6;

        private int _pageSize = 3;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value > MaxPageSize ? MaxPageSize : value; }
        }
        public int PageNumber { get; set; } = 1;

    }
}


// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone Q\qx4.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone Q\qx2.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone Q\qx.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone Q\qx2.avif
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone Q\qx3.webp
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone Q\qx4.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone Q\qx2.jpg


// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG Strix\713o1MrAdrL._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG Strix\71UZ4hlwT3L._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG Strix\71Z3SNa-3rL._AC_SX679_.jpg



// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\312 (2).jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\312 (2).jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\ASUS TUF Dash 15 (2022)312.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\71uFCV0PnSL._AC_SX466_.jpg


// https://localhost:7028/Images/cardoO Headphone\cardoO Headphone1.webp

// https://localhost:7028/Images/Images\ASUS TUF Dash 15 (2022)\312.jpg

// Headphone\cardoO Headphone5.webp
// https://localhost:7028/Images/Images\ASUS TUF Dash 15 (2022)\312.jpg
//  https://localhost:7028/Images/Images\ASUS TUF Dash 15 (2022)\312.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG Strix G16\713o1MrAdrL._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG Strix G16\71UZ4hlwT3L._AC_SX679_.jpg
//C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG TUF\61OYRwzcUoL._AC_SX466_.jpg


// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG TUF\61M831oph0L._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG TUF\51btJzcsbYL._AC_SX466_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG ZEPHRA\51btJzcsbYL._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG ZEPHRA\61OYRwzcUoL._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG ZEPHRA\61M831oph0L._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG ZEPHRA\51btJzcsbYL._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\HP Victus 15.6 i5 Gaming\61M831oph0L._AC_SX466_.jpg//


// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG TUF\51btJzcsbYL._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG TUF\61M831oph0L._AC_SX466_.jpg
//C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS ROG TUF\61OYRwzcUoL._AC_SX466_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\312.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\FOSSiBOT F106 Pro\710j6Ztq4uL._AC_SX522_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\312.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\71uFCV0PnSL._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Casio Men's\61nHUVwR65L._AC_SY695_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Casio Men's\61ud-2mLi0L.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Casio Men's\71tkEvnl+uL.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\FOSSiBOT F106 Pro\814xiTIPUfL._AC_SX522_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\FOSSiBOT F106 Pro\710j6Ztq4uL._AC_SX522_.jpg
//C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\FOSSiBOT F106 Pro\71Z4CHV1H8L._AC_SX522_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\FOSSiBOT F106 Pro\81Y9KfGlHoL._AC_SX522_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 13\616dWFinzLL._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 13\71Is4AhUomL._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 13\81OP29BhXLL._AC_SX679_.jpg

//C: \Users\SW - 15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 15 Pro\616dWFinzLL._AC_SX679_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 15 Pro\616dWFinzLL._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 15 Pro\71Is4AhUomL._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 15 Pro\81OP29BhXLL._AC_SX679_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Lenovo Legion Pro\51btJzcsbYL._AC_SX466_.jpg


// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\tester\71ixrysoD1L._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Casio Men's\71tkEvnl+uL.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Casio Men's\61ud-2mLi0L.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\71uFCV0PnSL._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Casio Men's\61nHUVwR65L._AC_SY695_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 13\616dWFinzLL._AC_SX679_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 13\71Is4AhUomL._AC_SX679_.jpg
// C: \Users\SW - 15\source\repos\ECom\Ecom.API\wwwroot\Images\Apple iPhone 13\81OP29BhXLL._AC_SX679_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Lenovo Legion Pro\51btJzcsbYL._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Lenovo Legion Pro\61M831oph0L._AC_SX466_.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\Lenovo Legion Pro\61OYRwzcUoL._AC_SX466_.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\312.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\ASUS TUF Dash 15 (2022)\71uFCV0PnSL._AC_SX466_.jpg


// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone\cardoO Headphone1.webp
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone\cardoO Headphone2.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone\cardoO Headphone3.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone\cardoO Headphone4.jpg

// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone x\cardoO Headphone6.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone x\cardoO Headphone7.jpg
// C:\Users\SW-15\source\repos\ECom\Ecom.API\wwwroot\Images\cardoO Headphone x\cardoO Headphone8.jpg
