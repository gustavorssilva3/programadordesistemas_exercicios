using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideBar
{
    public partial class frmSideBar : Form
    {
        public frmSideBar()
        {
            InitializeComponent();
        }

        // Transição da barra lateral

        bool sidebarExpand = true;
        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                FlowPanelSlide.Width -= 10;
                if(FlowPanelSlide.Width <= 60)
                {
                    sidebarExpand = false;
                    SidebarTransition.Stop();
                }
            } else
            {
                FlowPanelSlide.Width += 10;
                if(FlowPanelSlide.Width >= 200)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                }
            }
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        // Transição menu

        bool menuExpand = false;

        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 113)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 54)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
        }
    }
}
