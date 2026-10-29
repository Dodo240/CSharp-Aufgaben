using System.Drawing;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

namespace Troll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using System;
            using System.Drawing;
            using System.IO;
            using System.Windows.Forms;

internal static class Program
        {
            [STAThread]
            static void Main()
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new TrollQuizForm());
            }
        }

        public class TrollQuizForm : Form
        {
            private const string FallbackUrl =
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuTaiRjYp8Tl5DNvtfGDaybpP7--c3cNeIJ9OXPGd6gg&s=10";

            private readonly TextBox answerBox;
            private readonly Button submitButton;

            public TrollQuizForm()
            {
                Text = "Mathe-Test";
                Size = new Size(350, 180);
                StartPosition = FormStartPosition.CenterScreen;

                var question = new Label
                {
                    Text = "Wie viel ist 5 + 3?",
                    Location = new Point(25, 20),
                    AutoSize = true,
                    Font = new Font("Arial", 14)
                };

                answerBox = new TextBox
                {
                    Location = new Point(25, 55),
                    Width = 280,
                    Font = new Font("Arial", 12)
                };

                submitButton = new Button
                {
                    Text = "Antwort prüfen",
                    Location = new Point(25, 95),
                    Width = 280,
                    Height = 30
                };

                submitButton.Click += CheckAnswer;
                AcceptButton = submitButton; // Enter löst den Button aus, ohne "Ding"

                Controls.Add(question);
                Controls.Add(answerBox);
                Controls.Add(submitButton);
            }

            private void CheckAnswer(object? sender, EventArgs e)
            {
                bool correct = answerBox.Text.Trim() == "8";
                string imagePath = Path.Combine(AppContext.BaseDirectory, "trollface.png");

                using var trollWindow = new Form
                {
                    Text = "Problem?",
                    StartPosition = FormStartPosition.CenterParent,
                    ClientSize = new Size(350, 270)
                };

                var picture = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(60, 10),
                    Size = new Size(230, 185)
                };

                try
                {
                    if (File.Exists(imagePath))
                    {
                        using var img = Image.FromFile(imagePath);
                        picture.Image = new Bitmap(img); // Kopie, damit die Datei nicht gesperrt bleibt
                    }
                    else
                    {
                        picture.Load(FallbackUrl); // Bild aus dem Internet laden
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bild konnte nicht geladen werden: " + ex.Message);
                }

                var message = new Label
                {
                    Text = correct ? "Richtig! ...aber PROBLEM?" : "Falsch! GET TROLLED!",
                    Location = new Point(10, 205),
                    Size = new Size(330, 40),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };

                trollWindow.Controls.Add(picture);
                trollWindow.Controls.Add(message);
                trollWindow.ShowDialog(this);

                picture.Image?.Dispose();
            }
        }

    }
        }


    }
}
}
