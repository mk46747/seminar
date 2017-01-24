using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    class Parrent
    {
        private int _idParrent;

        public virtual int IdParrent
        {
            get { return _idParrent; }
            set { _idParrent = value; }
        }
    }
}
