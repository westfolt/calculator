using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator
{
    class Presenter
    {
        private bool actionPressed;
        private MainWindow mainWindow;
        private Model model;
        private double x, y;
        private string action;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();
            actionPressed = false;
            x = 0;
            y = 0;
            action = "";

            //subscribing to events
            this.mainWindow.NumberClick += mainWindow_NumberClick;
            this.mainWindow.ActionClick += mainWindow_ActionClick;
            this.mainWindow.EqualsClick += mainWindow_EqualsClick;
            this.mainWindow.PointClick += mainWindow_PointClick;
            this.mainWindow.CancelClick += mainWindow_CancelClick;
        }

        void mainWindow_CancelClick(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            actionPressed = false;
            action = "";
            mainWindow.Display.Content = "0";
        }

        void mainWindow_PointClick(object sender, EventArgs e)
        {
            string temp = mainWindow.Display.Content.ToString();
            if (!temp.Contains(","))
                mainWindow.Display.Content += ",";
        }

        void mainWindow_EqualsClick(object sender, EventArgs e)
        {
            y = Convert.ToDouble(mainWindow.Display.Content);
            mainWindow.Display.Content = model.Input(action, x, y);
        }

        void mainWindow_ActionClick(object sender, EventArgs e)
        {
            action = ((Button) sender).Content.ToString();
            x = Convert.ToDouble(mainWindow.Display.Content);
            actionPressed = true;
        }

        void mainWindow_NumberClick(object sender, EventArgs e)
        {
            string number = ((Button)sender).Content.ToString();
            if (mainWindow.Display.Content.ToString() == "0"|| actionPressed)
            {
                mainWindow.Display.Content = number;
                actionPressed = false;
                return;
            }
            mainWindow.Display.Content += number;
        }
    }
}
