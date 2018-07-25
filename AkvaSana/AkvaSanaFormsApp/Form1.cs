using Library.AppContext;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkvaSanaFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CitiesRepository r = new CitiesRepository(new MyAppDbContext("TestDatabase"));
            bool bOk=r.AddItem(new Library.Entities.City { Id = Guid.NewGuid(), Name = "Dnipro" });
            if (bOk)
                return;
        }
    }
}
