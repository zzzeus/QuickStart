using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickStart.Tools
{
    class Tray
    {
        public NotifyIcon notifyIcon;
        public void init()
        {
            //设置托盘的各个属性  
            notifyIcon = new NotifyIcon();
            notifyIcon.BalloonTipText = "systray runnning...";
            notifyIcon.Text = "systray";
            notifyIcon.Icon = new System.Drawing.Icon("http://www.cnblogs.com/res/spring.ico");
            notifyIcon.Visible = true;
            //notifyIcon.ShowBalloonTip(2000);
            //notifyIcon.MouseClick += new MouseEventHandler(notifyIcon_MouseClick);

            //设置菜单项  
            MenuItem setting1 = new MenuItem("setting1");
            MenuItem setting2 = new MenuItem("setting2");
            MenuItem setting = new MenuItem("setting", new MenuItem[] { setting1, setting2 });

            //帮助选项  
            MenuItem help = new MenuItem("help");

            //关于选项  
            MenuItem about = new MenuItem("about");

            //退出菜单项  
            MenuItem exit = new MenuItem("exit");
            //exit.Click += new EventHandler(exit_Click);

            //关联托盘控件  
            MenuItem[] childen = new MenuItem[] { setting, help, about, exit };
            notifyIcon.ContextMenu = new ContextMenu(childen);
        }

    }
}
