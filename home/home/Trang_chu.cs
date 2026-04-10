using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using home.UserControls;

namespace home
{
    public partial class Trang_Chu : Form
    {
        private int currentGameId = 1; // 1 = Liên Quân, 2 = Free Fire

        public Trang_Chu()
        {
            InitializeComponent();

            // Ensure login/register visible on top right (guard nulls)
            if (linkLogin != null) linkLogin.ForeColor = Color.White;
            if (linkRegister != null) linkRegister.ForeColor = Color.White;

            // No game toggle buttons (removed)

            // Only load tournaments if panels exist
            if (flpLienQuan != null && flpFreeFire != null && flpPopular != null)
                LoadTournaments();
        }

        private void btnLienQuan_Click(object sender, EventArgs e)
        {
            currentGameId = 1;
            LoadTournaments();
        }

        private void btnFreeFire_Click(object sender, EventArgs e)
        {
            currentGameId = 2;
            LoadTournaments();
        }
        private void LoadTournaments()
        {
            // debug: list images found
            try
            {
                string imagesDirDebug = LocateImagesDir();
                if (Directory.Exists(imagesDirDebug))
                {
                    var files = Directory.GetFiles(imagesDirDebug);
                    System.Diagnostics.Debug.WriteLine("images found:\n" + string.Join("\n", files));
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("images folder not found: " + imagesDirDebug);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error listing images: " + ex.Message);
            }

            // Clear existing (but keep design-time LQ placeholders if present)
            // For LQ, prefer to reuse placeholders ucLQ1..ucLQ4 when available in designer
            var lqPlaceholders = new List<home.UserControls.UcTournamentCard>();
            try
            {
                if (this.ucLQ1 != null && flpLienQuan.Controls.Contains(this.ucLQ1)) lqPlaceholders.Add(this.ucLQ1);
                if (this.ucLQ2 != null && flpLienQuan.Controls.Contains(this.ucLQ2)) lqPlaceholders.Add(this.ucLQ2);
                if (this.ucLQ3 != null && flpLienQuan.Controls.Contains(this.ucLQ3)) lqPlaceholders.Add(this.ucLQ3);
                if (this.ucLQ4 != null && flpLienQuan.Controls.Contains(this.ucLQ4)) lqPlaceholders.Add(this.ucLQ4);
            }
            catch { }

            // If there are placeholders, remove other runtime controls but keep placeholders
            if (lqPlaceholders.Count > 0)
            {
                var toRemove = flpLienQuan.Controls.Cast<Control>().Where(c => !(c is home.UserControls.UcTournamentCard) || !lqPlaceholders.Contains((home.UserControls.UcTournamentCard)c)).ToList();
                foreach (var c in toRemove) flpLienQuan.Controls.Remove(c);
                // Example: if you want the first card to sit lower than the others, change its Margin
                // FlowLayoutPanel controls are auto-laid out; moving one in Designer will reflow others.
                // To offset a single card, set its Margin instead of dragging.
                if (lqPlaceholders.Count > 0 && lqPlaceholders[0] != null)
                {
                    lqPlaceholders[0].Margin = new Padding(10, 40, 10, 10); // left, top, right, bottom
                }
            }
            else
            {
                flpLienQuan.Controls.Clear();
            }

            // Clear other sections fully
            flpFreeFire.Controls.Clear();
            flpPopular.Controls.Clear();

            string imagesDir = LocateImagesDir();

            // Load Liên Quân images (explicit mapping: lq1..lq4)
            var lqImages = new List<Image>();
            var lqFilesUsed = new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                Image img = null;
                string selectedPath = null;
                if (Directory.Exists(imagesDir))
                {
                    // try exact filenames first
                    var names = new[] { $"lq{i}.png", $"lq{i}.jpg", $"lq{i}.jpeg", $"lq_{i}.png", $"lq_{i}.jpg", $"lienquan{i}.png", $"lienquan{i}.jpg" };
                    string found = names.Select(n => Path.Combine(imagesDir, n)).FirstOrDefault(File.Exists);

                    if (found == null)
                    {
                        // fall back to any file that starts with lq or contains lienquan and hasn't been used yet
                        var allFiles = Directory.GetFiles(imagesDir).Where(f => {
                            var nn = Path.GetFileName(f).ToLower();
                            return nn.StartsWith($"lq{i}") || nn.Contains($"lienquan{i}") || nn.StartsWith("lq") || nn.Contains("lienquan");
                        }).ToList();
                        if (allFiles.Any()) found = allFiles.First();
                    }

                    if (found != null)
                    {
                        img = LoadImage(found);
                        selectedPath = found;
                    }
                }

                if (img == null)
                    img = CreateSolidBitmap(Color.Magenta, 700, 400);

                lqImages.Add(img);
                lqFilesUsed.Add(selectedPath ?? "(none)");
            }

            for (int i = 0; i < lqImages.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"Assigning LQ card {i+1} <- {lqFilesUsed[i]}");
                if (i < lqPlaceholders.Count)
                {
                    // reuse placeholder
                    var ph = lqPlaceholders[i];
                    ph.SetData(lqImages[i], $"Liên Quân - Giải {i + 1}", "01/04/2026 - 30/04/2026", "Ghi chú: thông tin ngắn về giải đấu...");
                }
                else
                {
                    var card = new UcTournamentCard();
                    card.SetData(lqImages[i], $"Liên Quân - Giải {i + 1}", "01/04/2026 - 30/04/2026", "Ghi chú: thông tin ngắn về giải đấu...");
                    flpLienQuan.Controls.Add(card);
                }
            }

            // Load Free Fire images (explicit mapping: ff1..ff4)
            var ffImages = new List<Image>();
            var ffFilesUsed = new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                Image img = null;
                string selectedPath = null;
                if (Directory.Exists(imagesDir))
                {
                    var names = new[] { $"ff{i}.png", $"ff{i}.jpg", $"ff{i}.jpeg", $"ff_{i}.png", $"ff_{i}.jpg", $"freefire{i}.png", $"freefire{i}.jpg" };
                    string found = names.Select(n => Path.Combine(imagesDir, n)).FirstOrDefault(File.Exists);

                    if (found == null)
                    {
                        var allFiles = Directory.GetFiles(imagesDir).Where(f => {
                            var nn = Path.GetFileName(f).ToLower();
                            return nn.StartsWith($"ff{i}") || nn.Contains($"freefire{i}") || nn.StartsWith("ff") || nn.Contains("freefire");
                        }).ToList();
                        if (allFiles.Any()) found = allFiles.First();
                    }

                    if (found != null)
                    {
                        img = LoadImage(found);
                        selectedPath = found;
                    }
                }

                if (img == null)
                    img = CreateSolidBitmap(Color.OrangeRed, 700, 400);

                ffImages.Add(img);
                ffFilesUsed.Add(selectedPath ?? "(none)");
            }

            for (int i = 0; i < ffImages.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"Assigning FF card {i+1} <- {ffFilesUsed[i]}");
                // reuse FF placeholders if present
                try
                {
                    if (i == 0 && this.ucFF1 != null && flpFreeFire.Controls.Contains(this.ucFF1))
                    {
                        this.ucFF1.SetData(ffImages[i], $"Free Fire - Giải {i + 1}", "05/04/2026 - 20/04/2026", "Ghi chú: ...");
                        continue;
                    }
                    if (i == 1 && this.ucFF2 != null && flpFreeFire.Controls.Contains(this.ucFF2))
                    {
                        this.ucFF2.SetData(ffImages[i], $"Free Fire - Giải {i + 1}", "05/04/2026 - 20/04/2026", "Ghi chú: ...");
                        continue;
                    }
                    if (i == 2 && this.ucFF3 != null && flpFreeFire.Controls.Contains(this.ucFF3))
                    {
                        this.ucFF3.SetData(ffImages[i], $"Free Fire - Giải {i + 1}", "05/04/2026 - 20/04/2026", "Ghi chú: ...");
                        continue;
                    }
                    if (i == 3 && this.ucFF4 != null && flpFreeFire.Controls.Contains(this.ucFF4))
                    {
                        this.ucFF4.SetData(ffImages[i], $"Free Fire - Giải {i + 1}", "05/04/2026 - 20/04/2026", "Ghi chú: ...");
                        continue;
                    }
                }
                catch { }

                var card = new UcTournamentCard();
                card.SetData(ffImages[i], $"Free Fire - Giải {i + 1}", "05/04/2026 - 20/04/2026", "Ghi chú: thông tin ngắn về giải đấu...");
                flpFreeFire.Controls.Add(card);
            }

            // If a specific featured image exists (lienquan1.jpg) add it first to LQ
            var featuredPath = Path.Combine(imagesDir, "lienquan1.jpg");
            if (File.Exists(featuredPath))
            {
                var img = LoadImage(featuredPath);
                if (img != null)
                {
                    var featured = new UcTournamentCard();
                    featured.SetData(img, "AOV Đấu Trường Danh Vọng", "01/04/2026 - 30/04/2026", "Giải chuyên nghiệp");
                    flpLienQuan.Controls.Add(featured);
                    flpLienQuan.Controls.SetChildIndex(featured, 0);
                }
            }
        }

        private Image CreateSolidBitmap(Color c, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(c);
                // Draw simple white circle to simulate a badge
                Brush brush = Brushes.White;
                g.FillEllipse(brush, w / 4, h / 4, w / 2, h / 2);
            }
            return bmp;
        }

        private void lblPopularHeader_Click(object sender, EventArgs e)
        {

        }
        private Image LoadImage(string path)
        {
            if (!File.Exists(path)) return null; // Nếu không tìm thấy ảnh thì bỏ qua để không bị crash app

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return new Bitmap(Image.FromStream(fs));
            }
        }

        private void ucLQ1_Load(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnTeams_Click(object sender, EventArgs e)
        {

        }

        private void pnlNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Try to locate the images directory in several common locations so you can keep images in the project
        /// (for example: "...\home\home\Resources\images" or "...\home\Resources\images").
        /// </summary>
        private string LocateImagesDir()
        {
            try
            {
                var startup = AppDomain.CurrentDomain.BaseDirectory;
                var candidates = new List<string>()
                {
                    Path.Combine(startup, "images"),
                    Path.Combine(startup, "Resources", "images"),
                    Path.Combine(startup, "..", "Resources", "images"),
                    Path.Combine(startup, "..", "..", "Resources", "images"),
                    Path.Combine(startup, "..", "..", "..", "Resources", "images"),
                    Path.Combine(startup, "..", "..", "..", "home", "Resources", "images"),
                    // common VS layout where project files sit two levels up
                    Path.Combine(startup, "..", "..", "home", "Resources", "images")
                };

                // Also try the workspace-specific path the user mentioned (handles double 'home' folder)
                try
                {
                    var workspaceCandidate = Path.Combine("C:\\NguyenVinhKham\\giao dien\\home", "home", "Resources", "images");
                    candidates.Insert(0, workspaceCandidate);
                }
                catch { }

                foreach (var c in candidates)
                {
                    var full = Path.GetFullPath(c);
                    if (Directory.Exists(full)) return full;
                }

                // Walk up parents looking for Resources\\images or home\\Resources\\images
                var dirInfo = new DirectoryInfo(startup);
                for (int i = 0; i < 6; i++)
                {
                    if (dirInfo == null) break;
                    var p1 = Path.Combine(dirInfo.FullName, "Resources", "images");
                    var p2 = Path.Combine(dirInfo.FullName, "home", "Resources", "images");
                    if (Directory.Exists(p1)) return p1;
                    if (Directory.Exists(p2)) return p2;
                    dirInfo = dirInfo.Parent;
                }

                // As a more robust fallback, try to find a folder named "Resources" that contains an "images" subfolder
                try
                {
                    var searchRoot = new DirectoryInfo(startup).Parent; // search up one level from bin folder
                    if (searchRoot != null && Directory.Exists(searchRoot.FullName))
                    {
                        // limit search depth by only enumerating "Resources" directories (should be few)
                        var resourcesDirs = Directory.EnumerateDirectories(searchRoot.FullName, "Resources", SearchOption.AllDirectories).Take(20);
                        foreach (var rd in resourcesDirs)
                        {
                            var candidate = Path.Combine(rd, "images");
                            if (Directory.Exists(candidate)) return candidate;
                        }
                    }
                }
                catch { }

                 // As last fallback, return a path inside the startup folder (may not exist)
                 return Path.Combine(startup, "images");
             }
             catch
             {
                 return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
             }
         }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Tao_doi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Quan_ly_doi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pnlHero_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
