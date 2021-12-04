using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DefaultPrinter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListAllPrinters();
        }

        private void ListAllPrinters()
        {
            foreach (var item in PrinterSettings.InstalledPrinters)
            {
                this.ListBoxPrinters.Items.Add(item.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnSavePrinterSelection_Click(object sender, EventArgs e)
        {
            string pname = this.ListBoxPrinters.SelectedItem.ToString();
            myPrinters.SetDefaultPrinter(pname);
            System.Windows.Forms.Application.Exit();
        }
    }

    public static class myPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
    }
}
