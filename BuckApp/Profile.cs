﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuckApp
{
    public partial class Profile : Form
    {
        User user;
        public Profile(User user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
