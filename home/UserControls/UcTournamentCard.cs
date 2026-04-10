using System;
using System.Drawing;
using System.Windows.Forms;

namespace home.UserControls
{
    public class UcTournamentCard : UserControl
    {
        private PictureBox picBanner;
        private Label lblTournamentName;
        private Label lblTime;
        private Label lblNote;
        private Button btnFollow;

        public UcTournamentCard()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Width = 250;
            this.Height = 350;
            this.Margin = new Padding(10);
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

            picBanner = new PictureBox();
            picBanner.Dock = DockStyle.Top;
            picBanner.Height = 160;
            picBanner.SizeMode = PictureBoxSizeMode.Zoom;
            picBanner.BackColor = Color.LightGray;

            lblTournamentName = new Label();
            lblTournamentName.Dock = DockStyle.Top;
            lblTournamentName.Height = 48;
            lblTournamentName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTournamentName.TextAlign = ContentAlignment.MiddleLeft;
            lblTournamentName.Padding = new Padding(8, 8, 8, 8);

            lblTime = new Label();
            lblTime.Dock = DockStyle.Top;
            lblTime.Height = 24;
            lblTime.Font = new Font("Segoe UI", 8F);
            lblTime.ForeColor = Color.Gray;
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            lblTime.Padding = new Padding(8, 2, 8, 2);

            lblNote = new Label();
            lblNote.Dock = DockStyle.Top;
            lblNote.Height = 40;
            lblNote.Font = new Font("Segoe UI", 8F);
            lblNote.ForeColor = Color.DimGray;
            lblNote.TextAlign = ContentAlignment.TopLeft;
            lblNote.Padding = new Padding(8, 4, 8, 4);

            btnFollow = new Button();
            btnFollow.Text = "Theo dõi";
            btnFollow.ForeColor = Color.Red;
            btnFollow.BackColor = Color.White;
            btnFollow.FlatStyle = FlatStyle.Flat;
            btnFollow.FlatAppearance.BorderColor = Color.Red;
            btnFollow.FlatAppearance.BorderSize = 1;
            btnFollow.Width = 100;
            btnFollow.Height = 30;
            btnFollow.Location = new Point(8, 280);

            this.Controls.Add(btnFollow);
            this.Controls.Add(lblNote);
            this.Controls.Add(lblTime);
            this.Controls.Add(lblTournamentName);
            this.Controls.Add(picBanner);
        }

        // Default mouse wheel behavior: do not intercept; let parent controls handle scrolling.
        public void SetData(Image banner, string name, string time, string note = "")
        {
            picBanner.Image = banner;
            lblTournamentName.Text = name;
            lblTime.Text = time;
            lblNote.Text = note;
        }
    }
}
