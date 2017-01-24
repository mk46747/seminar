using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    class Connection
    {
        private int _idParrent;
        private int _idNanny;
        private bool _accepted;

        public virtual int IdParrent
        {
            get { return _idParrent; }
            set { _idParrent = value; }
        }
        public virtual int IdNanny
        {
            get { return _idNanny; }
            set { _idNanny = value; }
        }
        public virtual bool Accepted
        {
            get { return _accepted; }
            set { _accepted = value; }
        }
    }
}
