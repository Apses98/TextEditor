using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class MessageBox_V2_form : Form
    {
        /* Simiular to the normal messageBox but has three buttons (Save, don't Save, cancel). */
        static MessageBox_V2_form newMessageBox;
        static string newMessageBoxButton;
        public MessageBox_V2_form()
        {
            InitializeComponent();
        }

        public static string Show(string mainMessage) 
        {
            newMessageBox = new MessageBox_V2_form();
            newMessageBox.mainMessage.Text = mainMessage;
            newMessageBox.ShowDialog();
            return newMessageBoxButton;
        }

        public static string show(string mainMessage, string mainLabel)
        {
            newMessageBox = new MessageBox_V2_form();
            newMessageBox.mainMessage.Text = mainMessage;
            newMessageBox.Text = mainLabel;
            newMessageBox.ShowDialog();
            return newMessageBoxButton;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            newMessageBoxButton = "Save";
            newMessageBox.Dispose();
        }

        private void DontSaveButton_Click(object sender, EventArgs e)
        {
            newMessageBoxButton = "DontSave";
            newMessageBox.Dispose();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            newMessageBoxButton = "Cancel";
            newMessageBox.Dispose();
        }
    }
}
