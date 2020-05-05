using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutoImplement.V1
{
    public class MyContainor
    {
        public void RegisterType<T>() where T : class, new()
        {
            Type t = typeof(T);

            var obj = Activator.CreateInstance(t);
        }

    }
}
