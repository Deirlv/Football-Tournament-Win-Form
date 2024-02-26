namespace Football_Tournament
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageTeamFind = new TabPage();
            buttonFindTeam = new Button();
            labelName = new Label();
            textBoxNameFind = new TextBox();
            tabPageMatchFind = new TabPage();
            label1 = new Label();
            buttonFindMatch = new Button();
            comboBoxMatchFind = new ComboBox();
            tabControl1.SuspendLayout();
            tabPageTeamFind.SuspendLayout();
            tabPageMatchFind.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageTeamFind);
            tabControl1.Controls.Add(tabPageMatchFind);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(333, 145);
            tabControl1.TabIndex = 0;
            // 
            // tabPageTeamFind
            // 
            tabPageTeamFind.Controls.Add(buttonFindTeam);
            tabPageTeamFind.Controls.Add(labelName);
            tabPageTeamFind.Controls.Add(textBoxNameFind);
            tabPageTeamFind.Location = new Point(4, 24);
            tabPageTeamFind.Name = "tabPageTeamFind";
            tabPageTeamFind.Padding = new Padding(3);
            tabPageTeamFind.Size = new Size(325, 117);
            tabPageTeamFind.TabIndex = 0;
            tabPageTeamFind.Text = "Team";
            tabPageTeamFind.UseVisualStyleBackColor = true;
            // 
            // buttonFindTeam
            // 
            buttonFindTeam.Location = new Point(120, 76);
            buttonFindTeam.Name = "buttonFindTeam";
            buttonFindTeam.Size = new Size(75, 23);
            buttonFindTeam.TabIndex = 2;
            buttonFindTeam.Text = "Find team";
            buttonFindTeam.UseVisualStyleBackColor = true;
            buttonFindTeam.Click += buttonFindTeam_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(137, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // textBoxNameFind
            // 
            textBoxNameFind.Location = new Point(71, 36);
            textBoxNameFind.Name = "textBoxNameFind";
            textBoxNameFind.Size = new Size(177, 23);
            textBoxNameFind.TabIndex = 0;
            // 
            // tabPageMatchFind
            // 
            tabPageMatchFind.Controls.Add(label1);
            tabPageMatchFind.Controls.Add(buttonFindMatch);
            tabPageMatchFind.Controls.Add(comboBoxMatchFind);
            tabPageMatchFind.Location = new Point(4, 24);
            tabPageMatchFind.Name = "tabPageMatchFind";
            tabPageMatchFind.Padding = new Padding(3);
            tabPageMatchFind.Size = new Size(325, 117);
            tabPageMatchFind.TabIndex = 1;
            tabPageMatchFind.Text = "Match";
            tabPageMatchFind.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 16);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Team";
            // 
            // buttonFindMatch
            // 
            buttonFindMatch.Location = new Point(115, 76);
            buttonFindMatch.Name = "buttonFindMatch";
            buttonFindMatch.Size = new Size(89, 23);
            buttonFindMatch.TabIndex = 3;
            buttonFindMatch.Text = "Find matches";
            buttonFindMatch.UseVisualStyleBackColor = true;
            buttonFindMatch.Click += buttonFindMatch_Click;
            // 
            // comboBoxMatchFind
            // 
            comboBoxMatchFind.FormattingEnabled = true;
            comboBoxMatchFind.Location = new Point(71, 36);
            comboBoxMatchFind.Name = "comboBoxMatchFind";
            comboBoxMatchFind.Size = new Size(177, 23);
            comboBoxMatchFind.TabIndex = 0;
            // 
            // FindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 169);
            Controls.Add(tabControl1);
            Name = "FindForm";
            Text = "FindForm";
            Load += FindForm_Load;
            tabControl1.ResumeLayout(false);
            tabPageTeamFind.ResumeLayout(false);
            tabPageTeamFind.PerformLayout();
            tabPageMatchFind.ResumeLayout(false);
            tabPageMatchFind.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageTeamFind;
        private Label labelName;
        private TextBox textBoxNameFind;
        private TabPage tabPageMatchFind;
        private Button buttonFindTeam;
        private Label label1;
        private Button buttonFindMatch;
        private ComboBox comboBoxMatchFind;
    }
}