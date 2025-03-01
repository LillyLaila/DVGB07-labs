using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Lab3_DVGB07
{
    public partial class TextEditor : Form
    {

        private string filePath = "namnlös.txt"; //standardnamn för en fil
        private bool isTextChanged = false; //kollar om man har ändrat i texten eller inte.
        public TextEditor()
        {
            InitializeComponent();
            UpdatefileTitle();
        }

        //Anropas varje gång användaren ändrar innehållet i textfältet.
        private void TextBox_ifChange(object sender, EventArgs e)
        {
            isTextChanged = true;
            UpdatefileTitle(); //Uppdatera fil titel med "*" ifall man har ändrat i textbozen. 
            UpdateStatusBar(); //Uppdaterar status bar. 
        }

        //Hanterar "Open File" knappen och  gör så att man kan öppna en befintlig fil
        private void OpenFilesButton(object sender, EventArgs e)
        {
            if (ConfirmSave()) //Kollar först så att man sparar filen man är på innan man öppnar en ny
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Contains(".txt"))
                {
                    filePath = openFileDialog1.FileName;
                    textBox.Text = File.ReadAllText(filePath);
                    isTextChanged = false;
                    UpdatefileTitle();
                    UpdateStatusBar();
                }
                else
                {
                    MessageBox.Show("Error!! Du måste öppna en .txt fil!");
                }
            }
        }

        //Hanterar "Save As" knappen och låter användaren välja vart filen ska sparas
        private void SaveAsButton()
        {
            saveFileDialog1.Filter = "Text files (*.txt) | *.txt| All files (*.*)| *.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string nameFile = saveFileDialog1.FileName; //spara namnet på filen som .txt fil
                SaveButton(nameFile);
            }

        }
        //Hanterar "Save" knappen, sparar filen på samma plats som innan. 
        private void SaveButton(string changefilePath)
        {
            File.WriteAllText(changefilePath, textBox.Text); //Skriver all text från txtbox till filen som den ska sparas på. 
            filePath = changefilePath; //ge filen samma namn som den ursprungliga namnet.
            isTextChanged = false;
            UpdatefileTitle();
            MessageBox.Show($"Filen {Path.GetFileName(filePath)} är sparad", "Sparad", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Hanterar både "Save As" och "Save" knappen,
        //Save as - låter användaren välja vart filen ska sparas
        //Save - sparar filen på samma plats som innan, har ingen plats valts så är det SaveAs knappen som gäller
        private void SavingFileButton(object sender, EventArgs e)
        {
            if (filePath == "namnlös.txt")
            {
                SaveAsButton();
            }
            else
            {
                SaveButton(filePath);
            }
        }

        //Bekräfta att man vill spara ändringar. 
        private bool ConfirmSave()
        {
            if (isTextChanged)
            {
                DialogResult result = MessageBox.Show("Vill du spara ändringar?", "Bekräfta", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SavingFileButton(null, null);
                }
                return result != DialogResult.Cancel;
            }
            return true;
        }

        //Hanterar knappen "New Text" och rensar textrutan
        private void NewTextButton(object sender, EventArgs e)
        {
            textBox.Clear();
        }


        //Hanterar "Exit" knappen och avslutar programmet. 
        private void ExitButton(object sender, EventArgs e)
        {
            if (ConfirmSave()) //bekräfta spara filen.
            {
                Application.Exit();
            }
        }

        //Uppdarar titeln på fönstret med aktuella filstatus.  
        //Om texten i dokumenten ändras ska detta indikeras i titelraden med en asterisk "*fil1.txt"
        private void UpdatefileTitle()
        {
            string displayName = Path.GetFileName(filePath); //hämta endast filnamet och inte hela sökvägen
            FileName.Text = (isTextChanged ? "*" : "") + displayName;
        }

        //Hanterar status bar
        //Den uppdaterar: antal tecken med mellanslag, tecken utan mellanslag, ord och rader.
        private void UpdateStatusBar()
        {
            string text = textBox.Text;

            //Uppdaterar charWithSpace textbox
            int charWithSpace = text.Length;
            charSpaceBox.Text = $"{charWithSpace}";

            //Uppdaterar charWithNoSpace textbox
            int charWithNoSpace = text.Replace(" ", "").Length;
            charNoSpaceBox.Text = $"{charWithNoSpace}";

            //Uppdaterar rowswBox textbox
            //Faktiska radbrytningar ska visas (de du själv skapar med ENTER knappen).
            //Automatiska radbrytningar ska inte visas 
            int rowsText = textBox.Lines.Length;
            while(rowsText > 0 && string.IsNullOrWhiteSpace(textBox.Lines[rowsText - 1]))
            {
                rowsText--;

            }
            rowsBox.Text = $"{rowsText}";


            //Uppdaterar wordsBox textbox
            int wordsText = text.Split(new char[] {' ', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
            wordsBox.Text = $"{wordsText}";
        }

        //Hanterar "X" avsluta-knappen, frågar om man vill spara filen innan man avslutar applikationen.
        private void TextEditor_CloseSave(object sender, FormClosingEventArgs e)
        {
            if (ConfirmSave())
            {
                return;
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
}
