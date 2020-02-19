using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearch
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void choose_folder_btn_Click(object sender, EventArgs e)
        {
            handlers.chosing_folder();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            handlers.init(this);
        }
        
        
    }
}
