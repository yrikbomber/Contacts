using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Camera
    {
        public string Photo { get; set; }

        public Camera()
        {
            this.Photo = String.Empty;

        }
        public Camera(string phonespeak)
        {
            Photo = phonespeak;

        }

        public override string ToString()
        {
            return $"Фото: {Photo}";
        }
    }
}
