using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab_02_OOP
{
    public partial class Founding : Form
    {
        private List<Score> _ownerFounded = new List<Score>();

        public Founding()
        {
            this.SuspendLayout();
                // 
                // Founding
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(363, 513);
                this.Name = "Founding";
                this.ResumeLayout(false);
            InitializeComponent();
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void FoundForName_CheckedChanged(object sender, EventArgs e)
        {
            fieldFound.Mask = "";
            seriesPassport.Visible = false;
        }

        private void FoondForPassport_CheckedChanged(object sender, EventArgs e)
        {
            fieldFound.Mask = @"0000000";
            seriesPassport.Visible = true;
        }

        private void FoundForOrder_CheckedChanged(object sender, EventArgs e)
        {
            fieldFound.Mask = @"00.00.0000";
            seriesPassport.Visible = false;
        }

        private void fieldFound_MaskInputKeyPress(object sender, KeyPressEventArgs e)
        {
            if (FoondForPassport.Checked || FoundForHB.Checked)
                e.Handled = !char.IsDigit(e.KeyChar);
            else
                e.Handled = char.IsDigit(e.KeyChar);
        }

        private void buttonFound_Click(object sender, EventArgs e)
        {
            var txtForField = fieldFound.Text;
            if (FoundForHB.Checked)
            {
                var dateTime = DateTime.Parse(txtForField);
            
                foreach (var score in Form1.Scores)
                    if (score.DateOpened.Date == dateTime.Date)
                    {
                        _ownerFounded?.Add(score);
                        var node = treeOutSearch.Nodes.Add(score.Owner.LastName);
                        node.Nodes.Add(score.Owner.FirstName);
                        node.Nodes.Add(score.Owner.Patronymic);
                        node.Nodes.Add(score.Owner.SeriesPassport + score.Owner.NumberPassport);
                        node.Nodes.Add("Номер счета: " + score.Number);
                        node.Nodes.Add("Баланс: "+score.Balance.ToString());
                        //treeOutSearch.ExpandAll();
                    }
            }
        }

        private void radioFirstLatter_CheckedChanged(object sender, EventArgs e)
        {
            fieldTwoForFound.Mask = @"A";
        }

        private void endingLastName_CheckedChanged(object sender, EventArgs e)
        {
            fieldTwoForFound.Mask = @"AA";
        }

        private void ButtonFoundSecond_Click(object sender, EventArgs e)
        {
            var textField = fieldTwoForFound.Text;
            if (textField.Length == 0) return;

            if (radioFirstLatter.Checked)
            {
                var pattern = @"\b[" + textField + @"]\w+";
                var rg = new Regex(pattern, RegexOptions.IgnoreCase);
                foreach (var score in Form1.Scores)
                {
                    _ownerFounded?.Add(score);
                    var result = rg.Match(score.Owner.LastName.ToUpper());
                    if (!result.Success) continue;
                    var node = treeOutSearch.Nodes.Add(score.Owner.LastName);
                    node.Nodes.Add(score.Owner.FirstName);
                    node.Nodes.Add(score.Owner.Patronymic);
                    node.Nodes.Add(score.Owner.SeriesPassport + score.Owner.NumberPassport);
                    node.Nodes.Add("Баланс: "+score.Balance.ToString());
                    //treeOutSearch.ExpandAll();
                }
            }
            else if (radioEndingLastName.Checked)
            {
                var pattern = textField + @"$";
                var rg = new Regex(pattern, RegexOptions.IgnoreCase);
                foreach (var score in Form1.Scores)
                {
                    var result = rg.Match(score.Owner.LastName);
                    if (!result.Success) continue;
                    _ownerFounded?.Add(score);
                    var node = treeOutSearch.Nodes.Add(score.Owner.LastName);
                    node.Nodes.Add(score.Owner.FirstName);
                    node.Nodes.Add(score.Owner.Patronymic);
                    node.Nodes.Add(score.Owner.SeriesPassport + score.Owner.NumberPassport);
                    node.Nodes.Add("Баланс: "+score.Balance.ToString());
                    //treeOutSearch.ExpandAll();
                }
            }
            else if (foundBetterPosition.Checked)
            {
                if(textField.Length!=4) return;
                var pattern = @"^\w{" + (int.Parse(textField.Substring(2, 2))-1) + @"}[" + textField.Substring(0, 1) + @"]\w+";
                var rg = new Regex(pattern, RegexOptions.IgnoreCase);
                foreach (var score in Form1.Scores)
                {
                    var result = rg.Match(score.Owner.LastName);
                    if (!result.Success) continue;
                    _ownerFounded?.Add(score);
                    var node = treeOutSearch.Nodes.Add(score.Owner.LastName);
                    node.Nodes.Add(score.Owner.FirstName);
                    node.Nodes.Add(score.Owner.Patronymic);
                    node.Nodes.Add(score.Owner.SeriesPassport + score.Owner.NumberPassport);
                    node.Nodes.Add("Баланс: "+score.Balance.ToString());
                    //treeOutSearch.ExpandAll();
                }
            }
            else
            {
                var pattern = @"^\w{" + int.Parse(textField) + @"}$";
                var rg = new Regex(pattern, RegexOptions.IgnoreCase);

                foreach (var score in Form1.Scores)
                {
                    var result = rg.Match(score.Owner.LastName);
                    if (!result.Success) continue;
                    _ownerFounded?.Add(score);
                    var node = treeOutSearch.Nodes.Add(score.Owner.LastName);
                    node.Nodes.Add(score.Owner.FirstName);
                    node.Nodes.Add(score.Owner.Patronymic);
                    node.Nodes.Add(score.Owner.SeriesPassport + score.Owner.NumberPassport);
                    node.Nodes.Add("Баланс: "+score.Balance.ToString());
                    //treeOutSearch.ExpandAll();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fieldTwoForFound.Mask = "00";
        }

        private void fieldTwoForFound_MaskInputPressKey(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void buttonClearTree_Click(object sender, EventArgs e)
        {
            treeOutSearch.Nodes.Clear();
        }

        public void DateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeOutSearch.Nodes.Clear();
            _ownerFounded = (from score in _ownerFounded orderby score.Owner.FirstName select score).ToList();
            foreach (var owner in _ownerFounded)
            {
                var node = treeOutSearch.Nodes.Add(owner.Owner.LastName);
                node.Nodes.Add(owner.Owner.FirstName);
                node.Nodes.Add(owner.Owner.Patronymic);
                node.Nodes.Add(owner.Owner.SeriesPassport + owner.Owner.NumberPassport);
                node.Nodes.Add("Баланс: "+owner.Balance.ToString());
            }
        }

        private void TypeDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeOutSearch.Nodes.Clear();
            _ownerFounded = (from score in _ownerFounded orderby score.Owner.NumberPassport select score).ToList();
            foreach (var owner in _ownerFounded)
            {
                var node = treeOutSearch.Nodes.Add(owner.Owner.LastName);
                node.Nodes.Add(owner.Owner.FirstName);
                node.Nodes.Add(owner.Owner.Patronymic);
                node.Nodes.Add(owner.Owner.SeriesPassport + owner.Owner.NumberPassport);
                node.Nodes.Add("Баланс: "+owner.Balance.ToString());
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            fieldTwoForFound.Mask = @"L-00";
        }

        private void SaveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog {Filter = @"xml files (*.xml)|*.xml", FilterIndex = 1};

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            if (_ownerFounded.Count != 0)
                XmlSerializeWrapper.Serialize(Form1.Scores, saveFileDialog.FileName);
        }
    }
}