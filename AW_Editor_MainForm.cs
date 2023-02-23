using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms.VisualStyles;

namespace TextEditor
{
    public partial class AW_Editor_MainForm : Form
    {

        /* Variables:
         *      Changed             -> is used to check if the text in the "main_richTextBox changed
         *      dragdropDone        -> turns true if a drag and drop have been done
         *      closingPending      -> turns true if the program is closing it is used to prevent a bug
         *      current_file_path   -> Stores the path for the current/opened text file
         *      file_name           -> Stores the default name of the new file or the file of the opened file
         **/  

        private bool Changed = false, dragdropDone = false, closingPending = false;
        private string current_file_path = "";
        private string file_name = "Nameless.txt";
        public AW_Editor_MainForm()
        {
            InitializeComponent();
        }

        private void AW_Editor_MainForm_Load(object sender, EventArgs e)
        {
            // Necessary for the drag and drop functionality
            this.main_richTextBox.AllowDrop = true;
            this.main_richTextBox.DragDrop += new DragEventHandler(this.main_richTextBox_DragDrop);
            this.main_richTextBox.DragEnter += new DragEventHandler(this.main_richTextBox_DragEnter);
        }


        /* Click events for ToolStripMenuItesm(s)
         *      New             : Creates a new text file.
         *      Open            : Opens a text file.
         *      Save            : Saves a text file directly if the currentpath is not empty, else Save As.
         *      Save As         : Saves a text file as a new file.
         *      Exit            : Exit the application.
         *      Fullscreen mode : Sets the window to fullScreen.
         *      Dark Mode       : Changes the Theme to Dark.
         *      Zoom + & -      : Zooms in or out
         *      Info Bar        : Displays the number of words, characters and lines.
         *      About           : Displays information about the application and the developer.
         *      Feedback        : Opens the default mail app to send feedback to the developer.
         *      Auto Save Mode  : Saves the file Automatically on text change.
         **/

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* If the text was not changed then no need to save, 
             *  delete the text in the richTextBox, reset the file name to default
             *  reset the current file path to empty
             *  
             * if the text was changed then create a messagebox_v2 and ask if the user
             *  wants to save, don't save or cancel
             *  if the user don't want to save, 
             *   delete the text in the richTextBox, set Changed to false
             *  else if the user wants to save the file
             *   try to save the file directly (If the current file path is not empty)
             *   if the current file path is empty -> save As 
             *    delete the text in the richTextBox
             *    reset the file name
             *   at the end set changed to false
             * At the end update the file name 
             **/
            if (!Changed)
            {
                main_richTextBox.Text = "";
                file_name = "Nameless.txt";
                current_file_path = "";
            }
            else if (Changed)
            {
                var result = MessageBox_V2_form.show("Do You want to save?", "Save!");
                if (result == "DontSave")
                {
                    main_richTextBox.Text = "";
                    Changed = false;
                }
                else if (result == "Save")
                {
                    if (!saveDirectly())
                    {
                        if (saveAs())
                        {
                            main_richTextBox.Text = "";
                            file_name = "Nameless.txt";
                            current_file_path = "";
                        }
                    }
                    else
                    {
                        main_richTextBox.Text = "";
                        file_name = "Nameless.txt";
                        current_file_path = "";
                    }
                    Changed = false;
                }
            }
            updateFormTitle();
        }
        
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /* If the file was not changed then -> open file directly
             * else if the file changed ask the user with messagesbox_v2,
             *  (save, don't save, cancel)
             *  if don't save then -> open the file directly
             *  else if the user choice was save,
             *   try to save directly else save As -> then open new file
             *  if the user choice was cancel then -> do nothing
             **/
            if (!Changed)
                open_file();
            else if (Changed)
            {
                var result = MessageBox_V2_form.show("Do You want to save?", "Save!");
                if (result == "DontSave")
                    open_file();
                else if (result == "Save")
                {
                    if (!saveDirectly())
                    {
                        if (saveAs())
                            open_file();
                    }
                    else
                        open_file();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Save:
             *  Try to save directly, 
             *  but if the current file path is empty then Save As
             **/
            if (!saveDirectly())
            {
                if (saveAs())
                {
                    Changed = false;
                }
            }
            else
            {
                Changed = false;
            }
            updateFormTitle();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save As
            if (saveAs())
            {
                Changed = false;
                updateFormTitle();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Exit:
             * if the program is closing from somewhere else 
             *  then no need to exit from here
             * 
             * set closingPending to true to indicate that the progarm is exiting
             * if there is no change, then application.Exit()
             *  
             * else if the text was changed -> Save first, then close
             * **/
            if (closingPending)
                return;

            closingPending = true;
            if (!Changed)
                System.Windows.Forms.Application.Exit();
            else
            {
                var result = MessageBox_V2_form.show("Save the file before exiting?", "Save before exiting!");
                if (result == "Save")
                {
                    if (!saveDirectly())
                    {
                        saveAs();
                        System.Windows.Forms.Application.Exit();
                    }
                }
                else if (result == "DontSave")
                    System.Windows.Forms.Application.Exit();
            }
        }

        private void fullscreenModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* To turn on fullscreen mode set the window state to maximized and
             *  the form borderstyle to none,
             * to exit the fullscreen mode reset the changes to the original values.
             **/
            if (fullscreenModeToolStripMenuItem.Text == "Fullscreen Mode")
            {
                fullscreenModeToolStripMenuItem.Text = "Window Mode";
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                fullscreenModeToolStripMenuItem.Text = "Fullscreen Mode";
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Dark mode:
             *  Change the Colors
             * **/
            if(darkModeToolStripMenuItem.Text == "Enable Dark Mode")
            {
                darkModeToolStripMenuItem.Text = "Disable Dark Mode";
                main_richTextBox.BackColor = Color.Black;
                main_richTextBox.ForeColor = Color.White;
                main_menuStrip.BackColor = Color.Black;
                main_menuStrip.ForeColor = Color.White;
                autoSaveModeToolStripMenuItem.BackColor = Color.Black;
                autoSaveModeToolStripMenuItem.ForeColor = Color.White;
            }
            else
            {
                darkModeToolStripMenuItem.Text = "Enable Dark Mode";
                main_richTextBox.BackColor = Color.White;
                main_richTextBox.ForeColor = Color.Black;
                main_menuStrip.BackColor = Color.White;
                main_menuStrip.ForeColor = Color.Black;
                autoSaveModeToolStripMenuItem.BackColor = Color.White;
                autoSaveModeToolStripMenuItem.ForeColor = Color.Black;
            }
        }
        
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Zoom In -> increase the text size
            main_richTextBox.Font = new Font(main_richTextBox.SelectionFont.FontFamily, main_richTextBox.Font.SizeInPoints + 1);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Zoom Out -> decrease the text size
            main_richTextBox.Font = new Font(main_richTextBox.SelectionFont.FontFamily, main_richTextBox.Font.SizeInPoints - 1);
        }

        private void documentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show or hide information bar at the bottom of the form
            if (documentInformationToolStripMenuItem.Text == "Hide info bar")
            {
                documentInformationToolStripMenuItem.Text = "Show info bar";
                bottomBar_menuStrip.Visible = false;

            }
            else
            {
                documentInformationToolStripMenuItem.Text = "Hide info bar";
                bottomBar_menuStrip.Visible = true;
            }
        }

        private void aboutAWEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Information about the app, and the developer
            MessageBox.Show("AW-Editor, is a simple and efficient text editor developed by Ahmad Abo Warda.\n" +
                " With its full-screen mode, dark mode, and auto-save mode, you can focus on your writing without distractins.\n" +
                "\nIn addition to the standard text editing capabilities, AW-Editor also keeps track of the number of words, characters, and lines in our document.\n" +
                " Whether you're taking notes, writing a novel, or just need a basic text editor, AW-Editor has you covered.\n" +
                "\nYou can visit the website of the developer at https://ahmad.abowarda.com for more information.",
                "About AW-Editor",
                MessageBoxButtons.OK
            );

        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Feedback: send mail from the default mail app
            try
            {
                Process.Start("mailto:ahmad@abowarda.com");
            }
            catch (Exception)
            {
                MessageBox.Show("You do not have a default mail application set up,\n you can send your feedback to Ahmad@abowarda.com");
            }

        }
        
        private void autoSaveModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Turn Auto save mode on and off
            if (autoSaveModeToolStripMenuItem.Text == "AutoSave Mode: on")
            {
                autoSaveModeToolStripMenuItem.Text = "AutoSave Mode: off";
                autoSaveModeToolStripMenuItem.BackColor = default;
                
            }
            else
            {
                autoSaveModeToolStripMenuItem.Text = "AutoSave Mode: on";
                autoSaveModeToolStripMenuItem.BackColor = Color.LightGreen;
            }
            
        }


        /* Other needed events:
         *  richtextbox_textChanged : Sets changed to true and auto save if autoSaveMode is on
         *  richTextBox_DragEnter   : Changes the DragDropEffects on DragEnter
         *  richTextBox_DragDrop    : Open the draged file or appends the text of the draged file to the current text (if ctrl is held) or inserts the text of the draged file (if the shift is held).
         *  MainForm_FormClosing    : saves 
         **/

        private void Event_richtextbox_event_textChanged(object sender, EventArgs e)
        {
            /* Draging&Droping a file is triggering this event and setting changed to true, 
             *  therefor the bool variable dragdropDone have been used to solve this issue.
             *  
             *  This event is used to set changed to true on text change 
             *  It is also used to save the text automatically if autosave mode is set to on.
             **/
            if (!dragdropDone)
                Changed = true;

            if (autoSaveModeToolStripMenuItem.Text == "AutoSave Mode: on")
            {
                if (!saveDirectly())
                {
                    if (saveAs())
                        Changed = false;
                }
                else
                    Changed = false;
            }

            dragdropDone = false;
            updateFormTitle();
            updateDocInfo();

        }
        private void main_richTextBox_DragEnter(object sender, DragEventArgs e)
        {
            // Changes the DragDropEffects on DragEnter
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void main_richTextBox_DragDrop(object sender, DragEventArgs e)
        {
            /* Get the path(s) for the droped file(s) and save them in result as string[] 
             * 
             * The variables ctrl and shift defines the values that represents the keys 
             *  ctrl and shift in the e.KeyState.Equals(Value)
             *  
             * This program accepts only 1 file as a drag and drop file, 
             * therefor it checks if the result.length is !1 
             * 
             * using retriveTextFromFile we can get the text from the droped file.
             * if ctrl is held while drag and drop then the text will be appended to the end of the current file.
             * if shift is held while drag and drop then the text will be inserted at the marker's location ( with the help of insert method)
             * 
             * if no key is held down and a file is draged and droped the it will be opened, 
             * and any unsaved text will be handeld by asking the user to (save, don't save, cancel).
             **/
            var result = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int ctrl = 8, shift = 4;

            //only one file allowed
            if (result.Length != 1)
                MessageBox.Show("You can't drop more than 1 file at a time!\nTry again.");
            else
            {
                if (e.KeyState.Equals(ctrl))
                    main_richTextBox.AppendText(retriveTextFromFile(result[0]));
                else if (e.KeyState.Equals(shift))
                    main_richTextBox.Text = main_richTextBox.Text.Insert(main_richTextBox.SelectionStart, retriveTextFromFile(result[0]));
                else
                {
                    if (!Changed)
                        open_file(result[0]);
                    // The file changed and is not empty
                    else if (Changed)
                    {
                        // Save the current file first then open the new file
                        var result_message = MessageBox_V2_form.show("Do You want to save?", "Save!");
                        if (result_message == "DontSave")
                            open_file(result[0]);
                        // if save pressed
                        else if (result_message == "Save")
                        {
                            // if path is not empty Directly save
                            if (!saveDirectly())
                            {
                                //Else save as
                                if (saveAs())
                                    open_file(result[0]);
                            }
                            else
                                open_file(result[0]);
                        }
                    }
                }
            }
        }

        private void AW_Editor_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* Event on closing the form from the X
             *  If closingPending then no need to close.
             *  
             *  if the text was changed then the used should be asked (save, don't save, cancel).
             *  if cancel then cancel the closing process and set closingPending to false.
             *  if save was choosen then save then exit.
             **/
            if (closingPending)
                return;
            closingPending = true;
            if (Changed)
            {
                var result = MessageBox_V2_form.show("Save the file before exiting?", "Save before exiting!");
                if (result == "Save")
                {
                    if (!saveDirectly())
                        saveAs();
                }
                else if (result == "Cancel")
                {
                    e.Cancel = true;
                    closingPending = false;
                }
            }
        }

        /* Other used functins:
         *  open_file           : Opens a new file with the help of OpenFileDialog, or the parameter path.
         *  saveDirectly        : If the current file have a current file path, then save else return false.
         *  saveAs              : Saves the file using SaveFileDialog.
         *  updateDocInfo       : Counts and displays the number of words, characters and lines in the text.
         *  updateFormTitle     : Updates the file name and puts a * in front of the file name if the text was changed.
         *  retriveTextFromFile : Get the text from a text at the path (path) and return it.
         **/

        private void open_file(string path = "")
        {
            /* The function opens a new file with the help of OpenFileDialog,
             * or if the path string is not empty it opens the file, 
             * it then updates the current_file_path and the form title.
             **/
            if (path == "")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text files (*.txt)| *.txt";
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    current_file_path = dialog.FileName;
                    file_name = dialog.FileName.Split('\\').Last();
                    main_richTextBox.Text = System.IO.File.ReadAllText(dialog.FileName);
                    Changed = false;
                    updateFormTitle();
                }
            }
            else
            {
                if (path.EndsWith(".txt"))
                {
                    
                    current_file_path = path;
                    file_name = path.Split('\\').Last();
                    main_richTextBox.Text = System.IO.File.ReadAllText(path);
                    Changed = false;
                    dragdropDone = true;
                    updateFormTitle();
                }
                else
                    MessageBox.Show($"The file {path.Split('\\').Last()} can't be opened.\nTry another file.");
            }
        }

        private bool saveDirectly()
        {
            /* if the current file path is is empty return false
             * else write the text in the main_richtextbox to the file 
             * and update the formtitle and the bool changed
             **/
            if (current_file_path == "")
                return false;

            System.IO.File.WriteAllText(current_file_path, main_richTextBox.Text);
            Changed = false;
            updateFormTitle();
            return true;
        }

        private bool saveAs()
        {
            /* open SaveFileDialog and save the file if the dialog result was ok,
             * then update the bool changed and the form title.
             * else 
             *  if autosave mode was on turn it off
             **/
            var dialog = new SaveFileDialog();
            // Set default file name
            dialog.FileName = file_name;
            dialog.Filter = "Text File (*.txt)| *.txt";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                current_file_path = dialog.FileName;
                file_name = dialog.FileName.Split('\\').Last();
                System.IO.File.WriteAllText(current_file_path, main_richTextBox.Text);
                Changed = false;
                updateFormTitle();
                return true;
            }
            else
            {
                if (autoSaveModeToolStripMenuItem.Text == "AutoSave Mode: on")
                {
                    autoSaveModeToolStripMenuItem.Text = "AutoSave Mode: off";
                    autoSaveModeToolStripMenuItem.BackColor = default;
                }
                return false;
            }
        }

        private void updateDocInfo()
        {
            // Count the number of words, characers (with and without spaces), and number of lines.
            int char_with_no_spaces = 0, number_of_words = 0, number_of_lines = 0;
            var words_in_array = main_richTextBox.Text.Split(' ' , '\n');
            for (int i = 0; i < main_richTextBox.Text.Length; i++)
            {
                if(main_richTextBox.Text[i] != ' ')
                    char_with_no_spaces++;
                if (main_richTextBox.Text[i] == '\n')
                    number_of_lines++;
                if(i < words_in_array.Length)
                {
                    if (words_in_array[i] != "")
                        number_of_words++;
                }
                
            }
            charactersToolStripMenuItem.Text = (main_richTextBox.Text.Length - number_of_lines).ToString() + " " + "Characters (with spaces)";
            charactersExcludingSpacesToolStripMenuItem.Text = (char_with_no_spaces - number_of_lines).ToString() + " " + "Characters";
            wordsToolStripMenuItem1.Text = number_of_words.ToString() + " " + "Word(s)";
            wordsToolStripMenuItem.Text  = number_of_words.ToString() + " " + "Word(s)";
            numberOfLinesToolStripMenuItem.Text = (number_of_lines + 1).ToString() + " " + "Line(s)";
        }

        private void updateFormTitle()
        {
            // update the file name basen on the bool Changed.
            if (Changed)
                this.Text = "*" + file_name + " - " + "AW-Editor";
            else
                this.Text = file_name + " - " + "AW-Editor";
            
        }

        private string retriveTextFromFile(string path)
        {
            /* Get the text from a file located in the path (path) (only if the file contains .txt,
               and check if the file is empty, or if the file is not .txt */
            string result = "";
            if (path.Contains(".txt"))
                result = System.IO.File.ReadAllText(path);
            else if (result == "" && path.Contains(".txt"))
                MessageBox.Show($"The file {path.Split('\\').Last()} is empty.");
            else
                MessageBox.Show($"The file {path.Split('\\').Last()} can't be opened.\nTry another file.");
            return result;
        }
    }
}
