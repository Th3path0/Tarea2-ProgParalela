using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessKiller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void UpdateProcessList()
        {
            ServiceController[] services = ServiceController.GetServices();

            lstProcesses.Items.Clear();
       

            
            int id = 1;
            foreach (ServiceController service in services)
            {
                lstProcesses.Items.Add(id + ":" + service.ServiceName); // nombre del proceso
              
            

               

                id = id + 1;
            }
            tslProcessCount.Text = "Procesos Actuales: " + lstProcesses.Items.Count.ToString();    //  cant de procesos   
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
