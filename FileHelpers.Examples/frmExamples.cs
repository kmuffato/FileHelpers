﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Examples;


namespace ExamplesFramework
{
    public partial class frmExamples : Form
    {
        public frmExamples()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            examplesContainer.LoadDemos(ExampleFactory.GetExamples());
        }

    

    }
}
