using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika04
{
    public partial class SizeDialog : Form
    {
        int _value;
        public int Value { get { return _value; } }

        public SizeDialog(int value = 0)
        {
            InitializeComponent();
            _value = value;
            trackSize.Value = _value;
        }

        private void trackSize_Scroll(object sender, EventArgs e)
        {
            _value = trackSize.Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
