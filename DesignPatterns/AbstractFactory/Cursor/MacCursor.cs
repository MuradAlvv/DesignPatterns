using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Cursor
{
    internal class MacCursor : ICursor
    {
        public void Hide()
        {
            Console.WriteLine("mac cursor hided");
        }

        public void Render(){
            Console.WriteLine("rendering");
        }

        public void Show()
        {
            Console.WriteLine("mac cursor shown");
        }
    }
}
