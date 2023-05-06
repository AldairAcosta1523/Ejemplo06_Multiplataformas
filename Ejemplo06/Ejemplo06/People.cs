using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo06
{
    public class People : List<Datos>
    {
        public string Title { get; set; }

        public People(string title)
        {
            Title = title;
        }
    }
}
