using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace XOX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        int hodi = 1;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Click1_1(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn1_1.Background = brush;
                Btn1_1.Tag = "nolik";
                Btn1_1.IsHitTestVisible = false;
                WinCheck();
            }

            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn1_1.Background = brush;
                Btn1_1.Tag = "krestik";
                Btn1_1.IsHitTestVisible = false;
                WinCheck();
            }


        }


        private void Click1_2(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn1_2.Background = brush;
                Btn1_2.Tag = "nolik";
                Btn1_2.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn1_2.Background = brush;
                Btn1_2.Tag = "krestik";
                Btn1_2.IsHitTestVisible = false;
                WinCheck();
            }


        }

        private void Click1_3(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn1_3.Background = brush;
                Btn1_3.Tag = "nolik";
                Btn1_3.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn1_3.Background = brush;
                Btn1_3.Tag = "krestik";
                Btn1_3.IsHitTestVisible = false;
                WinCheck();
            }



        }

        private void Click2_1(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn2_1.Background = brush;
                Btn2_1.Tag = "nolik";
                Btn2_1.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn2_1.Background = brush;
                Btn2_1.Tag = "krestik";
                Btn2_1.IsHitTestVisible = false;
                WinCheck();
            }


        }

        private void Click2_2(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn2_2.Background = brush;
                Btn2_2.Tag = "nolik";
                Btn2_2.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn2_2.Background = brush;
                Btn2_2.Tag = "krestik";
                Btn2_2.IsHitTestVisible = false;
                WinCheck();
            }

        }

        private void Click2_3(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn2_3.Background = brush;
                Btn2_3.Tag = "nolik";
                Btn2_3.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn2_3.Background = brush;
                Btn2_3.Tag = "krestik";
                Btn2_3.IsHitTestVisible = false;
                WinCheck();
            }


        }

        private void Click3_1(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn3_1.Background = brush;
                Btn3_1.Tag = "nolik";
                Btn3_1.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn3_1.Background = brush;
                Btn3_1.Tag = "krestik";
                Btn3_1.IsHitTestVisible = false;
                WinCheck();
            }


        }

        private void Click3_2(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn3_2.Background = brush;
                Btn3_2.Tag = "nolik";
                Btn3_2.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn3_2.Background = brush;
                Btn3_2.Tag = "krestik";
                Btn3_2.IsHitTestVisible = false;
                WinCheck();
            }


        }

        private void Click3_3(object sender, RoutedEventArgs e)
        {
            counter = counter + 1;
            hodi = hodi + 1;
            var brush = new ImageBrush();
            if ((counter & 1) == 0)
            {

                brush.ImageSource = new BitmapImage(new Uri("Images/nolik.jpg", UriKind.Relative));
                Btn3_3.Background = brush;
                Btn3_3.Tag = "nolik";
                Btn3_3.IsHitTestVisible = false;
                WinCheck();
            }
            else
            {
                brush.ImageSource = new BitmapImage(new Uri("Images/krestik.jpg", UriKind.Relative));
                Btn3_3.Background = brush;
                Btn3_3.Tag = "krestik";
                Btn3_3.IsHitTestVisible = false;
                WinCheck();
            }

        }


        private void WinCheck()
        {

            if (((Btn1_1.Tag) == (Btn1_2.Tag)) && ((Btn1_1.Tag) == (Btn1_3.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }
            else if (((Btn2_1.Tag) == (Btn2_2.Tag)) && ((Btn2_1.Tag) == (Btn2_3.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }

            else if (((Btn3_1.Tag) == (Btn3_2.Tag)) && ((Btn3_1.Tag) == (Btn3_3.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }

            else if (((Btn1_1.Tag) == (Btn2_1.Tag)) && ((Btn1_1.Tag) == (Btn3_1.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }

            else if (((Btn1_2.Tag) == (Btn2_2.Tag)) && ((Btn1_2.Tag) == (Btn3_2.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }

            else if (((Btn1_3.Tag) == (Btn2_3.Tag)) && ((Btn1_3.Tag) == (Btn3_3.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }

            else if (((Btn1_1.Tag) == (Btn2_2.Tag)) && ((Btn1_1.Tag) == (Btn3_3.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }

            else if (((Btn1_3.Tag) == (Btn2_2.Tag)) && ((Btn1_3.Tag) == (Btn3_1.Tag)))
            {
                if ((counter & 1) == 1)
                    MessageBox.Show("Player 1 (Krestiki) WINS!");
                if ((counter & 1) == 0)
                    MessageBox.Show("Player 2 (Noliki) WINS!");
            }

            else if (hodi == 10)
            {
                MessageBox.Show("NEIZŠĶIRTS!");
            }
        }

        //private void MsgBox() 
        //{
        //    string message = "New game?";
        //    string caption = "Confirmation";
        //    MessageBoxButton buttons = MessageBoxButton.YesNo;
        //    MessageBoxImage icon = MessageBoxImage.Question;
        //    if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.OK)
        //    {                
        //      
        //     
        //    }
        //    else
        //    {
        //        Application.Current.Shutdown();
        //    }
    
        }

    }
    



