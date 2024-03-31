using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Image> pictures = new List<Image>();
        List<Image> originalPictures = new List<Image>();
        List<PictureBox> boxes = new List<PictureBox>();
        int blackImage;
        int numberOfMoves = 0;
        int numberOfTry = 0;
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        


        public Form1()
        {
            InitializeComponent();
            createOriginalPicture();

            // Set up the timer to trigger the updateTimeElapsed method every 100 milliseconds
            Timer displayTimer = new Timer();
            displayTimer.Interval = 100;
            displayTimer.Tick += updateTimeElapsed;
            displayTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxOriginal.Image = Image.FromFile("cats.jpg");
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            timeLabel.Text = "00:00";
            movesLabel.Text += numberOfMoves;

            createPictureBoxes();
            
        }
        private void createOriginalPicture()
        {
            originalPictures.Add(Image.FromFile("00.jpg"));
            originalPictures.Add(Image.FromFile("10.jpg"));
            originalPictures.Add(Image.FromFile("20.jpg"));
            originalPictures.Add(Image.FromFile("01.jpg"));
            originalPictures.Add(Image.FromFile("11.jpg"));
            originalPictures.Add(Image.FromFile("21.jpg"));
            originalPictures.Add(Image.FromFile("02.jpg"));
            originalPictures.Add(Image.FromFile("12.jpg"));
            originalPictures.Add(Image.FromFile("22.jpg"));

            int[] numbers = { 0, 2, 6, 8 };
            int randomIndex = random.Next(numbers.Length);
            int randomNumber = numbers[randomIndex];
            blackImage = randomNumber;
            originalPictures[randomNumber] = Image.FromFile("black.jpg");
        }
        private void createPictureBoxes()
        {
            pictures.Add(Image.FromFile("00.jpg"));
            pictures.Add(Image.FromFile("10.jpg"));
            pictures.Add(Image.FromFile("20.jpg"));
            pictures.Add(Image.FromFile("01.jpg"));
            pictures.Add(Image.FromFile("11.jpg"));
            pictures.Add(Image.FromFile("21.jpg"));
            pictures.Add(Image.FromFile("02.jpg"));
            pictures.Add(Image.FromFile("12.jpg"));
            pictures.Add(Image.FromFile("22.jpg"));

            int[] numbers = { 0, 2, 6, 8 };
            int randomIndex = random.Next(numbers.Length);
            int randomNumber = numbers[randomIndex];
            blackImage = randomNumber;
            pictures[randomNumber] = Image.FromFile("black.jpg");

            PuzzleBox.Controls.Add(pictureBox11);
            PuzzleBox.Controls.Add(pictureBox12);
            PuzzleBox.Controls.Add(pictureBox13);
            PuzzleBox.Controls.Add(pictureBox21);
            PuzzleBox.Controls.Add(pictureBox22);
            PuzzleBox.Controls.Add(pictureBox23);
            PuzzleBox.Controls.Add(pictureBox31);
            PuzzleBox.Controls.Add(pictureBox32);
            PuzzleBox.Controls.Add(pictureBox33);

            boxes.Add(pictureBox11);
            boxes.Add(pictureBox12);
            boxes.Add(pictureBox13);
            boxes.Add(pictureBox21);
            boxes.Add(pictureBox22);
            boxes.Add(pictureBox23);
            boxes.Add(pictureBox31);
            boxes.Add(pictureBox32);
            boxes.Add(pictureBox33);
        }

        private void shuffleImages()
        {
            // Shuffle the list of images using Fisher-Yates algorithm

            for(int i = pictures.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                // Schimbăm pozițiile imaginilor
                var temp = pictures[i];
                pictures[i] = pictures[j];
                pictures[j] = temp;

                // Verificăm dacă imaginea mutată este imaginea neagră
                if (i == blackImage)
                {
                    blackImage = j; // Actualizăm indexul imaginii negre la noua poziție
                }
                else if (j == blackImage)
                {
                    blackImage = i; // Actualizăm indexul imaginii negre la noua poziție
                }
            }

            

        }

    private void displayImages()
    {
        //display the pictures in the pictureboxes
        for (int i = 0; i < 9; i++)
        {
             boxes[i].Image = pictures[i];
             boxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }

    private bool checkWin()
    {
        int i;
        for(i = 0; i < 9; i++)
        {
            if ((PuzzleBox.Controls[i] as PictureBox).Image != originalPictures[i])
             break;
        }
        if(i == 9)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void startBtn_Click(object sender, EventArgs e)
    {
        numberOfTry++;
        shuffleImages();
        displayImages();
        timer.Start();
    }

    private void quitBtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }


        private void updateTimeElapsed(object sender, EventArgs e)
        {
            if (timer.Elapsed > TimeSpan.Zero)
            {
                // Update label with elapsed time (formatting minutes and seconds)
                timeLabel.Text = string.Format("{0:mm\\:ss}", timer.Elapsed);
                startBtn.Enabled = false;
            }

            if (timer.Elapsed >= TimeSpan.FromMinutes(45))
            {
                // Reset the timer and other related values
                startBtn.Enabled = true;
                timer.Reset();
                movesLabel.Text = "Moves made: 0";
                timeLabel.Text = "00:00";
                numberOfMoves = 0;


                // Show a message indicating time is up

                if (checkWin() == false)
                {
                    MessageBox.Show("Time is up!\nTo try again click on Start!");
                }
                else if (timer.Elapsed == TimeSpan.FromMinutes(45))
                {
                    MessageBox.Show("Almost failed but you succed right on time!\nTo play again click on Start");

                    String number = numberOfTry.ToString();
                    Scores.Items.Add("Try number " + number + " 05:00");
                    this.Controls.Add(Scores);
                }
            }
        }
        private void switchPictureBoxes(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            int pictureBoxIndex = PuzzleBox.Controls.IndexOf(clickedPictureBox);
            Console.WriteLine("The index of clicked picturebox is " + pictureBoxIndex.ToString());
       
            int blackPictureIndex = blackImage;

            Console.WriteLine("The index of the black image is: " + blackPictureIndex.ToString());

            if (checkWin() == false)
            {

                if (blackPictureIndex == 0)
                {
                    if (pictureBoxIndex == 1 || pictureBoxIndex == 3)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 1)
                {
                    if (pictureBoxIndex == 0 || pictureBoxIndex == 2 || pictureBoxIndex == 4)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 2)
                {
                    if (pictureBoxIndex == 1 || pictureBoxIndex == 5)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 3)
                {
                    if (pictureBoxIndex == 0 || pictureBoxIndex == 4 || pictureBoxIndex == 6)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 4)
                {
                    if (pictureBoxIndex == 1 || pictureBoxIndex == 3 || pictureBoxIndex == 5 || pictureBoxIndex == 7)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 5)
                {
                    if (pictureBoxIndex == 2 || pictureBoxIndex == 4 || pictureBoxIndex == 8)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 6)
                {
                    if (pictureBoxIndex == 3 || pictureBoxIndex == 7)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 7)
                {
                    if (pictureBoxIndex == 4 || pictureBoxIndex == 6 || pictureBoxIndex == 8)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                if (blackPictureIndex == 8)
                {
                    if (pictureBoxIndex == 5 || pictureBoxIndex == 7)
                    {
                        blackImage = pictureBoxIndex;
                        var value = pictures[pictureBoxIndex];
                        pictures[pictureBoxIndex] = pictures[blackPictureIndex];
                        pictures[blackPictureIndex] = value;
                        numberOfMoves++;
                        movesLabel.Text = "Moves made: " + numberOfMoves.ToString();
                        displayImages();
                    }
                }

                Console.WriteLine("The index of the black image changet to: " + blackImage.ToString());

            }
            else if (timer.Elapsed < TimeSpan.FromMinutes(45))

            {
                String number = numberOfTry.ToString();
                String minutes = timer.Elapsed.Seconds.ToString();
                String seconds = timer.Elapsed.Seconds.ToString();
                Scores.Items.Add("Try number " + number + ",time " + minutes + ":" + seconds);
                this.Controls.Add(Scores);
                timer.Stop();
                MessageBox.Show("You succeed:)\nIf you want to play again click on Start!");
            }

        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox11 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox12 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox13 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox21 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox22 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox23 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox31 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox32 is clicked!");
            switchPictureBoxes(sender, e);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            Console.WriteLine("PictureBox33 is clicked!");
            switchPictureBoxes(sender, e);
        }
    }
}
