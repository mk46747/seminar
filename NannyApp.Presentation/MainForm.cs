using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NannyApp.BaseLib;
using NannyApp.Model;

namespace NannyApp.Presentation
{
    public partial class MainForm : Form, IMainView
    {
        private IMainFormController MainController;

        public MainForm(IMainFormController MainController)
        {
            this.MainController = MainController;
            InitializeComponent();
        }

        public User User { get; set; } //???
    }
}
