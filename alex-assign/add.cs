using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alex_assign
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        public add(Form1 frmhand)
        {
            InitializeComponent();
            handleform1 = frmhand;
         
        }
        private Form1 handleform1;
        
        private void button2_Click(object sender, EventArgs e)
        {
            {
                
                int num = Convert.ToInt32(numtxt.Text);
                int coun = Convert.ToInt32(counter.Text);
                int result = coun + num;
                counter.Text = result.ToString();

                handleform1.WriteTobutton(counter.Text);
                }
        }
       
        private void add_Load(object sender, EventArgs e)
        {

        }
        
        private void numtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
