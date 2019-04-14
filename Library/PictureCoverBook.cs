using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class PictureCoverBook
    {
        private Image image;
        public Image Image { get => image; set => image = value; }

        public PictureCoverBook(Image image)
        {
            this.Image = image;
        }

    }
}
