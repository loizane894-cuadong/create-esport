using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace home
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tao_giai_dau());
        }
    }

public class RoundedButton : Button
    {
        // Thuộc tính giúp bạn chỉnh độ bo tròn trực tiếp trong Properties
        public int BorderRadius { get; set; } = 20;

        public RoundedButton()
        {
            // Cài đặt mặc định cho nút để giao diện phẳng và hiện đại hơn
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new System.EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, System.EventArgs e)
        {
            if (BorderRadius > this.Height)
                BorderRadius = this.Height;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            GraphicsPath path = new GraphicsPath();
            int r = BorderRadius;

            // Vẽ 4 góc bo tròn
            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(this.Width - r, 0, r, r, 270, 90);
            path.AddArc(this.Width - r, this.Height - r, r, r, 0, 90);
            path.AddArc(0, this.Height - r, r, r, 90, 90);
            path.CloseFigure();

            // Cắt nút theo hình vẽ
            this.Region = new Region(path);
        }
    }
}
