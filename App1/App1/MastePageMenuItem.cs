using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{

    public class MastePageMenuItem
    {
        public MastePageMenuItem()
        {
            TargetType = typeof(MastePageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Color TitleColor { get; set; }
        public Color BarBackgroundColor  { get; set; }
        public FontAttributes TitleWeight { get; set; }
        public Type TargetType { get; set; }
    }
}