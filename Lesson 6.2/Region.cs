using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._2
{
    public class Region
    {
        public string Name;
        public int area;
        public TypePeople inregion;
        public Region(string Name, int area, TypePeople inregion)
        {
            this.Name = Name;
            this.area = area;
            this.inregion = inregion;
        }
    }
}
