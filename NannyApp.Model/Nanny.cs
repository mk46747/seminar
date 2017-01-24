using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
    class Nanny
    {
        private int _idNanny;
        private string _exstraServices; //mozda neko polje services koje moze ponuditi (kuhanje, ciscenje...), ako joj damo checkbox?
        private string _extraQualification;
        private string _education;
        private bool _smoking; //flag
        private bool _pets; //flag
        private bool _sickChildren; //flag
        private bool _car; //flag

        public virtual int IdNanny
        {
            get { return _idNanny; }
            set { _idNanny = value; }
        }
        public virtual string ExtraServices
        {
            get { return _exstraServices; }
            set { _exstraServices = value; }
        }
        public virtual string ExtraQualification
        {
            get { return _extraQualification; }
            set { _extraQualification = value; }
        }
        public virtual string Education
        {
            get { return _education; }
            set { _education = value; }
        }
        public virtual bool Smoking
        {
            get { return _smoking; }
            set { _smoking = value; }
        }
        public virtual bool Pets
        {
            get { return _pets; }
            set { _pets = value; }
        }
        public virtual bool SickChildren
        {
            get { return _sickChildren; }
            set { _sickChildren = value; }
        }
        public virtual bool Car
        {
            get { return _car; }
            set { _car = value; }
        }
    }
}
