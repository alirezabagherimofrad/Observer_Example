using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Example
{
    public interface ISubscriber
    {
       public void Update(string videoTitle);
    }
}
