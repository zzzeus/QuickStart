using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuickStart
{
    /// <summary>
    /// QuickStartPage.xaml 的交互逻辑
    /// </summary>
    public partial class QuickStartPage : Window
    {
    

        NotifyIcon notifyIcon;
        public QuickStartPage()
        {
            InitializeComponent();
            Closing += QuickStartPage_Closing;
            initTray();

        }

        private void QuickStartPage_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (notifyIcon != null)
                notifyIcon.Dispose();
        }

        public void initTray()
        {
            if (notifyIcon == null)
            {
                notifyIcon = new NotifyIcon();
                notifyIcon.Icon = SystemIcons.Application;

                var contextMenu1 = new System.Windows.Forms.ContextMenu();
                var menuItem1 = new System.Windows.Forms.MenuItem();
                contextMenu1.MenuItems.AddRange(
                    new System.Windows.Forms.MenuItem[] { menuItem1 });
                menuItem1.Index = 0;
                menuItem1.Text = "E&xit";
                menuItem1.Click += MenuItem1_Click;
            }

            
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
