using System;
using System.Windows.Forms;

namespace EndgameCheckmatePractice.documents
{
    public partial class LargeTextInfoForm : Form
    {
        public LargeTextInfoForm(string formText, string mainText, int formWidth = 500)
        // Initializes this Form with specified width, formText in the strip at the top, and
        // mainText in the textBox. formWidth must be at least 120 (which is much too small for
        // a good user experience anyway).
        {
            if (formWidth < 120)
                throw new ArgumentException("formWidth < 120");
            
            InitializeComponent();

            this.Text = formText;
            textBox.Text = mainText;

            // In the [Design] window, the default widths, which look good, are
            // this.Width = 600 and textBox.Width = 560 = 600 - 40.
            this.Width = formWidth;
            textBox.Width = formWidth - 40;

            // Move blinking vertical line to end without scrolling
            textBox.Select(mainText.Length, 0);
        }
    }
}
