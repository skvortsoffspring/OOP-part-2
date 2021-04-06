using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    interface ICommand
    {
        void Open();
        void Save();
    }
    public class Commands : ICommand
    {
        public void Open()
        {
            var openFileDialog = new OpenFileDialog {Filter = @"xml files (*.xml)|*.xml"};

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = openFileDialog.FileName;

            if (filename.Substring(filename.Length - 4).Equals(".xml"))
                Form1.Scores = XmlSerializeWrapper.Deserialize<List<Score>>(filename);
        }

        public void Save()
        {
            var saveFileDialog = new SaveFileDialog {Filter = @"xml files (*.xml)|*.xml", FilterIndex = 1};

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            if (Form1.Scores.Count != 0)
                XmlSerializeWrapper.Serialize(Form1.Scores, saveFileDialog.FileName);
        }
    }
}