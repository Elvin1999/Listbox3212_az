using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student
    {
        public string Id { get; set; }=Guid.NewGuid().ToString().Substring(0,8);
        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"{Id}  {Name}";
        }
    }
}
