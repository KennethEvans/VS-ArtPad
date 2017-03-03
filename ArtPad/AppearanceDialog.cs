﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtPad {
    public partial class AppearanceDialog : Form {
        public AppearanceDialog() {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonFg_click(object sender, EventArgs e) {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                Color color = dlg.Color;
                TextBoxFg.Text = Utils.colorToHexString(color);
            }
        }

        private void buttonBg_click(object sender, EventArgs e) {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                Color color = dlg.Color;
                TextBoxBg.Text = Utils.colorToHexString(color);
            }
        }
    }
}
