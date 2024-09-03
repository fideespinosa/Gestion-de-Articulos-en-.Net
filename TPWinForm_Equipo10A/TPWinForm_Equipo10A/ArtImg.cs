using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Equipo10A
{
    internal class ArtImg
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
         public override string ToString()
        {
            return ImgUrl;
        }
    }

}
