using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_3
{
    class Kisi
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogum_tarih { get; set; }
        public int yas // Set'i silince sadece okunabilir bir property olur.
        {
            get // Get methodunu ezdik. Ezildiği için içerisinde C# tarafından yazılmış           kodlar çalışmaz.
            {
                return DateTime.Now.Year - dogum_tarih.Year;
            }
        }
        public string Bilgiler
        {
            get
            {
                return ad + " " + soyad;
            }
        }
    }
}