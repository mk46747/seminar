using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NannyApp.BaseLib;
using System.Windows.Forms;

   public class ParentController
    {
        public void ShowParentForm(IParentView ParentView)
        {
            var form = (Form)ParentView;
            form.Show();
        }
    }
