using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    //A delegate allows me to point to methods with a matching signature. A single delegate
    //can point to several methods, as long as the signature requirements are met.
    //This delegate allows me to point to a method that returns void and accepts two strings.
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
}
