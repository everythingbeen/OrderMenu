﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderMenu
{
    public partial class Cook : Form
    {
        public Worker worker = new Worker();

        public Cook(Worker w)
        {
            InitializeComponent();
        }
    }
}
