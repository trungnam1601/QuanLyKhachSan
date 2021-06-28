using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers
{
    public partial class Helper : Form
    {
        Button CurrentButton;
        public Helper()
        {
            InitializeComponent();
            btnClick(addRHelperBTN);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER,CATSTATE.Room);
        }
        void btnClick(Button btn)
        {
            if (CurrentButton == null)
            {
                CurrentButton = btn;
                Utilities.setButtonState(true, ref CurrentButton);
                return;
            }
            if (CurrentButton == btn)
                return;
            Utilities.setButtonState(false, ref CurrentButton);
            CurrentButton = btn;
            Utilities.setButtonState(true, ref CurrentButton);
        }
        #region READER
        private void addStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER,CATSTATE.Room);
        }

        private void editStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.Room);
        }

        private void delStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.Room);
        }

        private void searchStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.Room);
        }
        #endregion
        #region LENDING
        private void addLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER, CATSTATE.Customer);
        }

        private void editLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.Customer);
        }

        private void delLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.Customer);
        }

        private void searchLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.Customer);
        }
        #endregion
        #region BOOL
        private void addBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER, CATSTATE.Service);
        }

        private void editBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.Service);
        }

        private void delBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.Service);
        }

        private void searchBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.Service);
        }
        #endregion

        private void nvAdd_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER, CATSTATE.Staff);
        }

        private void nvEdit_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.Staff);
        }

        private void nvDel_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.Staff);
        }

        private void nvSearch_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.Staff);
        }

        private void propertyAdd_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER, CATSTATE.Property);
        }

        private void propertyEdit_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.Property);
        }

        private void propertyDel_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.Property);
        }
    }
}
