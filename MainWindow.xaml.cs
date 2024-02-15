using System;
using System.Collections.Generic;
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

namespace gen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class biomes
    {
        public string tdata { get; set; }
    
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Random rnd = new Random();
            string final = "";
            int imax = 50;
            int jmax = 50;
            bool Flag = false;
            string[,] world = new string[imax, jmax];


            for (int i = 0; i < world.GetLength(0); i++)
            {
                for(int j = 0; j < world.GetLength(1); j++)
                {
                    switch (rnd.Next(4))
                    {
                        case 0:
                            world[i, j] = "0";
                            break;
                        case 1:
                            world[i, j] = "1";
                            break;
                        case 2:
                            world[i, j] = "2";
                            break;
                        case 3:
                            world[i, j] = "3";
                            break;
                    }
                    if (rnd.Next(4) == 0)
                    {
                        switch (world[i, j])
                        {
                            case "0":
                                if (rnd.Next(2) == 0)
                                {
                                    for (int k = (i - 2 < 0 ? 0 : i - 2); k < (i + 2 > imax ? 0 : i + 2); k++)
                                    {
                                        for (int l = (j - 2 < 0 ? 0 : j - 2); l < (j + 2 > jmax ? 0 : j + 2); l++)
                                        {
                                            if (world[k, l] == "b" && world[k, l] == "f")
                                            {
                                                Flag = true;
                                            }
                                        }
                                    }
                                    if (!Flag) world[i, j] = "f";
                                    Flag = false;
                                }
                                else
                                {
                                    for (int k = (i - 3 < 0 ? 0 : i - 3); k < (i + 3 > imax ? 0 : i + 3); k++)
                                    {
                                        for (int l = (j - 3 < 0 ? 0 : j - 3); l < (j + 3 > jmax ? 0 : j + 3); l++)
                                        {
                                            if (world[k, l] == "t")
                                            {
                                                Flag = true;
                                            }
                                        }
                                    }
                                    if (!Flag) world[i, j] = "t";
                                    Flag = false;
                                }
                                break;
                            case "1":
                                if (rnd.Next(1) == 0)
                                {
                                    for (int k = (i - 1 < 0 ? 0 : i - 1); k < (i + 1 > imax ? 0 : i + 1); k++)
                                    {
                                        for (int l = (j - 1 < 0 ? 0 : j - 1); l < (j + 1 > jmax ? 0 : j + 1); l++)
                                        {
                                            if (world[k, l] == "b" && world[k, l] == "f")
                                            {
                                                Flag = true;
                                            }
                                        }
                                    }
                                    if (!Flag) world[i, j] = "b";
                                    Flag = false;
                                } else
                                {
                                    for (int k = (i - 3 < 0 ? 0 : i - 3); k < (i + 3 > imax ? 0 : i + 3); k++)
                                    {
                                        for (int l = (j - 3 < 0 ? 0 : j - 3); l < (j + 3 > jmax ? 0 : j + 3); l++)
                                        {
                                            if (world[k, l] == "t")
                                            {
                                                Flag = true;
                                            }
                                        }
                                    }
                                    if (!Flag) world[i, j] = "t";
                                    Flag = false;
                                }
                                break;
                            case "3":
                                for (int k = (i - 1 < 0 ? 0 : i - 1); k < (i + 1 > imax ? 0 : i + 1); k++)
                                {
                                    for (int l = (j - 1 < 0 ? 0 : j - 1); l < (j + 1 > jmax ? 0 : j + 1); l++)
                                    {
                                        if (world[k, l] == "c")
                                        {
                                            Flag = true;
                                        }
                                    }
                                }
                                if (!Flag) world[i, j] = "c";
                                Flag = false;

                                break;
                                
                        }
                    }
                    final += "   " + world[i, j];
                }
                final += "\n";
            }
            InitializeComponent();
            currentscreen.DataContext = new biomes() { tdata = final };
        }
    }
}
