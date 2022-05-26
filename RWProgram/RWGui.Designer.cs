namespace RWProgram
{
    partial class RWGui
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.actionsTextBox = new System.Windows.Forms.TextBox();
            this.fluentsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actorsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StatementsComboBox = new System.Windows.Forms.ComboBox();
            this.StatementsLabel = new System.Windows.Forms.Label();
            this.QueriesLabel = new System.Windows.Forms.Label();
            this.ProgramLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.ActorComboBox = new System.Windows.Forms.ComboBox();
            this.PiComboBox = new System.Windows.Forms.ComboBox();
            this.FluentComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StatementsTextBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ProgramActionComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ProgramActorComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ResponseTextBox = new System.Windows.Forms.TextBox();
            this.QueriesComboBox = new System.Windows.Forms.ComboBox();
            this.QueriesOutcomeLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Pi2ComboBox = new System.Windows.Forms.ComboBox();
            this.GammaComboBox = new System.Windows.Forms.ComboBox();
            this.Actor2ComboBox = new System.Windows.Forms.ComboBox();
            this.AskQueryButton = new System.Windows.Forms.Button();
            this.AddToProgramButton = new System.Windows.Forms.Button();
            this.ResetProgramButton = new System.Windows.Forms.Button();
            this.ResetStatementButton = new System.Windows.Forms.Button();
            this.AddConditionButton = new System.Windows.Forms.Button();
            this.ConfirmStatementButton = new System.Windows.Forms.Button();
            this.AddCondition2Button = new System.Windows.Forms.Button();
            this.AddInitialStateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ResetQueryButton = new System.Windows.Forms.Button();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.AddQueryButton = new System.Windows.Forms.Button();
            this.DeleteLastStatementButton = new System.Windows.Forms.Button();
            this.DeleteLastProgramButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.19797F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.80203F));
            this.tableLayoutPanel1.Controls.Add(this.actionsTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fluentsTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.actorsTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // actionsTextBox
            // 
            this.actionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionsTextBox.Location = new System.Drawing.Point(106, 99);
            this.actionsTextBox.Multiline = true;
            this.actionsTextBox.Name = "actionsTextBox";
            this.actionsTextBox.Size = new System.Drawing.Size(676, 45);
            this.actionsTextBox.TabIndex = 5;
            this.actionsTextBox.Leave += new System.EventHandler(this.ActionsTextBox_Changed);
            // 
            // fluentsTextBox
            // 
            this.fluentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fluentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fluentsTextBox.Location = new System.Drawing.Point(106, 51);
            this.fluentsTextBox.Multiline = true;
            this.fluentsTextBox.Name = "fluentsTextBox";
            this.fluentsTextBox.Size = new System.Drawing.Size(676, 42);
            this.fluentsTextBox.TabIndex = 4;
            this.fluentsTextBox.Leave += new System.EventHandler(this.FluentsTextBox_Changed);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktorzy:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fluenty:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Akcje:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // actorsTextBox
            // 
            this.actorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.actorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorsTextBox.Location = new System.Drawing.Point(106, 3);
            this.actorsTextBox.Multiline = true;
            this.actorsTextBox.Name = "actorsTextBox";
            this.actorsTextBox.Size = new System.Drawing.Size(676, 42);
            this.actorsTextBox.TabIndex = 3;
            this.actorsTextBox.Leave += new System.EventHandler(this.ActorsTextBox_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wyrażenia:";
            // 
            // StatementsComboBox
            // 
            this.StatementsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatementsComboBox.FormattingEnabled = true;
            this.StatementsComboBox.Location = new System.Drawing.Point(144, 182);
            this.StatementsComboBox.Name = "StatementsComboBox";
            this.StatementsComboBox.Size = new System.Drawing.Size(653, 28);
            this.StatementsComboBox.TabIndex = 2;
            this.StatementsComboBox.SelectedIndexChanged += new System.EventHandler(this.StatementsComboBox_SelectedIndexChanged);
            // 
            // StatementsLabel
            // 
            this.StatementsLabel.AutoSize = true;
            this.StatementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatementsLabel.Location = new System.Drawing.Point(18, 311);
            this.StatementsLabel.Name = "StatementsLabel";
            this.StatementsLabel.Size = new System.Drawing.Size(197, 25);
            this.StatementsLabel.TabIndex = 3;
            this.StatementsLabel.Text = "Dodane wyrażenia:";
            // 
            // QueriesLabel
            // 
            this.QueriesLabel.AutoSize = true;
            this.QueriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QueriesLabel.Location = new System.Drawing.Point(18, 605);
            this.QueriesLabel.Name = "QueriesLabel";
            this.QueriesLabel.Size = new System.Drawing.Size(115, 25);
            this.QueriesLabel.TabIndex = 4;
            this.QueriesLabel.Text = "Kwerendy:";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProgramLabel.Location = new System.Drawing.Point(20, 453);
            this.ProgramLabel.Name = "ProgramLabel";
            this.ProgramLabel.Size = new System.Drawing.Size(100, 25);
            this.ProgramLabel.TabIndex = 5;
            this.ProgramLabel.Text = "Program:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "A:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "w:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "pi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "alpha/f:";
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Location = new System.Drawing.Point(50, 235);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(85, 24);
            this.ActionComboBox.TabIndex = 10;
            // 
            // ActorComboBox
            // 
            this.ActorComboBox.FormattingEnabled = true;
            this.ActorComboBox.Location = new System.Drawing.Point(166, 235);
            this.ActorComboBox.Name = "ActorComboBox";
            this.ActorComboBox.Size = new System.Drawing.Size(85, 24);
            this.ActorComboBox.TabIndex = 11;
            // 
            // PiComboBox
            // 
            this.PiComboBox.FormattingEnabled = true;
            this.PiComboBox.Location = new System.Drawing.Point(284, 235);
            this.PiComboBox.Name = "PiComboBox";
            this.PiComboBox.Size = new System.Drawing.Size(85, 24);
            this.PiComboBox.TabIndex = 12;
            // 
            // fluentComboBox
            // 
            this.FluentComboBox.FormattingEnabled = true;
            this.FluentComboBox.Location = new System.Drawing.Point(432, 235);
            this.FluentComboBox.Name = "fluentComboBox";
            this.FluentComboBox.Size = new System.Drawing.Size(85, 24);
            this.FluentComboBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickAddStatementButton);
            // 
            // StatementsTextBox
            // 
            this.StatementsTextBox.Location = new System.Drawing.Point(256, 311);
            this.StatementsTextBox.Name = "StatementsTextBox";
            this.StatementsTextBox.Size = new System.Drawing.Size(554, 96);
            this.StatementsTextBox.TabIndex = 15;
            this.StatementsTextBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 495);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Action:";
            // 
            // ProgramActionComboBox
            // 
            this.ProgramActionComboBox.FormattingEnabled = true;
            this.ProgramActionComboBox.Location = new System.Drawing.Point(65, 492);
            this.ProgramActionComboBox.Name = "ProgramActionComboBox";
            this.ProgramActionComboBox.Size = new System.Drawing.Size(110, 24);
            this.ProgramActionComboBox.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "by:";
            // 
            // ProgramActorComboBox
            // 
            this.ProgramActorComboBox.FormattingEnabled = true;
            this.ProgramActorComboBox.Location = new System.Drawing.Point(212, 492);
            this.ProgramActorComboBox.Name = "ProgramActorComboBox";
            this.ProgramActorComboBox.Size = new System.Drawing.Size(108, 24);
            this.ProgramActorComboBox.TabIndex = 19;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(349, 453);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(461, 122);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // ResponseTextBox
            // 
            this.ResponseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResponseTextBox.Location = new System.Drawing.Point(199, 834);
            this.ResponseTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.ResponseTextBox.Multiline = true;
            this.ResponseTextBox.Name = "ResponseTextBox";
            this.ResponseTextBox.Size = new System.Drawing.Size(174, 25);
            this.ResponseTextBox.TabIndex = 22;
            // 
            // QueriesComboBox
            // 
            this.QueriesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QueriesComboBox.FormattingEnabled = true;
            this.QueriesComboBox.Location = new System.Drawing.Point(157, 602);
            this.QueriesComboBox.Name = "QueriesComboBox";
            this.QueriesComboBox.Size = new System.Drawing.Size(653, 28);
            this.QueriesComboBox.TabIndex = 23;
            this.QueriesComboBox.SelectedIndexChanged += new System.EventHandler(this.QueriesComboBox_SelectedIndexChanged);
            // 
            // QueriesOutcomeLabel
            // 
            this.QueriesOutcomeLabel.AutoSize = true;
            this.QueriesOutcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QueriesOutcomeLabel.Location = new System.Drawing.Point(17, 833);
            this.QueriesOutcomeLabel.Margin = new System.Windows.Forms.Padding(10);
            this.QueriesOutcomeLabel.Name = "QueriesOutcomeLabel";
            this.QueriesOutcomeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.QueriesOutcomeLabel.Size = new System.Drawing.Size(177, 35);
            this.QueriesOutcomeLabel.TabIndex = 24;
            this.QueriesOutcomeLabel.Text = "Wynik kwerendy:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 654);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "pi (stan początkowy):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(309, 654);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "gamma (warunek):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(572, 654);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "w (wykonawca):";
            // 
            // Pi2ComboBox
            // 
            this.Pi2ComboBox.FormattingEnabled = true;
            this.Pi2ComboBox.Location = new System.Drawing.Point(166, 651);
            this.Pi2ComboBox.Name = "Pi2ComboBox";
            this.Pi2ComboBox.Size = new System.Drawing.Size(125, 24);
            this.Pi2ComboBox.TabIndex = 28;
            // 
            // GammaComboBox
            // 
            this.GammaComboBox.FormattingEnabled = true;
            this.GammaComboBox.Location = new System.Drawing.Point(432, 651);
            this.GammaComboBox.Name = "GammaComboBox";
            this.GammaComboBox.Size = new System.Drawing.Size(125, 24);
            this.GammaComboBox.TabIndex = 29;
            // 
            // Actor2ComboBox
            // 
            this.Actor2ComboBox.FormattingEnabled = true;
            this.Actor2ComboBox.Location = new System.Drawing.Point(678, 651);
            this.Actor2ComboBox.Name = "Actor2ComboBox";
            this.Actor2ComboBox.Size = new System.Drawing.Size(125, 24);
            this.Actor2ComboBox.TabIndex = 30;
            // 
            // AskQueryButton
            // 
            this.AskQueryButton.Location = new System.Drawing.Point(632, 779);
            this.AskQueryButton.Name = "AskQueryButton";
            this.AskQueryButton.Size = new System.Drawing.Size(178, 35);
            this.AskQueryButton.TabIndex = 31;
            this.AskQueryButton.Text = "Odpytaj";
            this.AskQueryButton.UseVisualStyleBackColor = true;
            this.AskQueryButton.Click += new System.EventHandler(this.AskQueryButton_Click);
            // 
            // AddToProgramButton
            // 
            this.AddToProgramButton.Location = new System.Drawing.Point(245, 540);
            this.AddToProgramButton.Name = "AddToProgramButton";
            this.AddToProgramButton.Size = new System.Drawing.Size(98, 35);
            this.AddToProgramButton.TabIndex = 32;
            this.AddToProgramButton.Text = "Dodaj";
            this.AddToProgramButton.UseVisualStyleBackColor = true;
            this.AddToProgramButton.Click += new System.EventHandler(this.AddToProgramButton_Click);
            // 
            // ResetProgramButton
            // 
            this.ResetProgramButton.Location = new System.Drawing.Point(16, 540);
            this.ResetProgramButton.Name = "ResetProgramButton";
            this.ResetProgramButton.Size = new System.Drawing.Size(104, 35);
            this.ResetProgramButton.TabIndex = 33;
            this.ResetProgramButton.Text = "Reset";
            this.ResetProgramButton.UseVisualStyleBackColor = true;
            this.ResetProgramButton.Click += new System.EventHandler(this.ResetProgramButton_Click);
            // 
            // ResetStatementButton
            // 
            this.ResetStatementButton.Location = new System.Drawing.Point(28, 359);
            this.ResetStatementButton.Name = "ResetStatementButton";
            this.ResetStatementButton.Size = new System.Drawing.Size(99, 35);
            this.ResetStatementButton.TabIndex = 34;
            this.ResetStatementButton.Text = "Reset";
            this.ResetStatementButton.UseVisualStyleBackColor = true;
            this.ResetStatementButton.Click += new System.EventHandler(this.ResetStatementsButton_Click);
            // 
            // AddConditionButton
            // 
            this.AddConditionButton.Enabled = false;
            this.AddConditionButton.Location = new System.Drawing.Point(678, 270);
            this.AddConditionButton.Name = "AddConditionButton";
            this.AddConditionButton.Size = new System.Drawing.Size(121, 35);
            this.AddConditionButton.TabIndex = 36;
            this.AddConditionButton.Text = "Dodaj warunek";
            this.AddConditionButton.UseVisualStyleBackColor = true;
            this.AddConditionButton.Visible = false;
            this.AddConditionButton.Click += new System.EventHandler(this.AddConditionButton_Click);
            // 
            // ConfirmStatementButton
            // 
            this.ConfirmStatementButton.Enabled = false;
            this.ConfirmStatementButton.Location = new System.Drawing.Point(551, 270);
            this.ConfirmStatementButton.Name = "ConfirmStatementButton";
            this.ConfirmStatementButton.Size = new System.Drawing.Size(121, 35);
            this.ConfirmStatementButton.TabIndex = 35;
            this.ConfirmStatementButton.Text = "Zatwierdź";
            this.ConfirmStatementButton.UseVisualStyleBackColor = true;
            this.ConfirmStatementButton.Visible = false;
            this.ConfirmStatementButton.Click += new System.EventHandler(this.ConfirmStatementButton_Click);
            // 
            // AddCondition2Button
            // 
            this.AddCondition2Button.Enabled = false;
            this.AddCondition2Button.Location = new System.Drawing.Point(415, 684);
            this.AddCondition2Button.Name = "AddCondition2Button";
            this.AddCondition2Button.Size = new System.Drawing.Size(171, 35);
            this.AddCondition2Button.TabIndex = 37;
            this.AddCondition2Button.Text = "Dodaj warunek";
            this.AddCondition2Button.UseVisualStyleBackColor = true;
            this.AddCondition2Button.Visible = false;
            this.AddCondition2Button.Click += new System.EventHandler(this.AddCondition2Button_Click);
            // 
            // AddInitialStateButton
            // 
            this.AddInitialStateButton.Enabled = false;
            this.AddInitialStateButton.Location = new System.Drawing.Point(149, 684);
            this.AddInitialStateButton.Name = "AddInitialStateButton";
            this.AddInitialStateButton.Size = new System.Drawing.Size(171, 35);
            this.AddInitialStateButton.TabIndex = 38;
            this.AddInitialStateButton.Text = "Dodaj stan początkowy";
            this.AddInitialStateButton.UseVisualStyleBackColor = true;
            this.AddInitialStateButton.Visible = false;
            this.AddInitialStateButton.Click += new System.EventHandler(this.AddInitialStateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 764);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Kwerenda:";
            // 
            // ResetQueryButton
            // 
            this.ResetQueryButton.Location = new System.Drawing.Point(632, 738);
            this.ResetQueryButton.Name = "ResetQueryButton";
            this.ResetQueryButton.Size = new System.Drawing.Size(178, 35);
            this.ResetQueryButton.TabIndex = 40;
            this.ResetQueryButton.Text = "Reset";
            this.ResetQueryButton.UseVisualStyleBackColor = true;
            this.ResetQueryButton.Click += new System.EventHandler(this.ResetQueryButton_Click);
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QueryTextBox.Location = new System.Drawing.Point(138, 764);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(463, 50);
            this.QueryTextBox.TabIndex = 41;
            // 
            // AddQueryButton
            // 
            this.AddQueryButton.Location = new System.Drawing.Point(632, 684);
            this.AddQueryButton.Name = "AddQueryButton";
            this.AddQueryButton.Size = new System.Drawing.Size(178, 35);
            this.AddQueryButton.TabIndex = 42;
            this.AddQueryButton.Text = "Dodaj kwerende";
            this.AddQueryButton.UseVisualStyleBackColor = true;
            this.AddQueryButton.Click += new System.EventHandler(this.AddQueryButton_Click);
            // 
            // DeleteLastStatementButton
            // 
            this.DeleteLastStatementButton.Location = new System.Drawing.Point(133, 359);
            this.DeleteLastStatementButton.Name = "DeleteLastStatementButton";
            this.DeleteLastStatementButton.Size = new System.Drawing.Size(117, 35);
            this.DeleteLastStatementButton.TabIndex = 43;
            this.DeleteLastStatementButton.Text = "Remove last";
            this.DeleteLastStatementButton.UseVisualStyleBackColor = true;
            this.DeleteLastStatementButton.Click += new System.EventHandler(this.DeleteLastStatementButton_Click);
            // 
            // DeleteLastProgramButton
            // 
            this.DeleteLastProgramButton.Location = new System.Drawing.Point(126, 540);
            this.DeleteLastProgramButton.Name = "DeleteLastProgramButton";
            this.DeleteLastProgramButton.Size = new System.Drawing.Size(113, 35);
            this.DeleteLastProgramButton.TabIndex = 44;
            this.DeleteLastProgramButton.Text = "Remove last";
            this.DeleteLastProgramButton.UseVisualStyleBackColor = true;
            this.DeleteLastProgramButton.Click += new System.EventHandler(this.DeleteLastProgramButton_Click);
            // 
            // RWGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 971);
            this.Controls.Add(this.DeleteLastProgramButton);
            this.Controls.Add(this.DeleteLastStatementButton);
            this.Controls.Add(this.AddQueryButton);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.ResetQueryButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddInitialStateButton);
            this.Controls.Add(this.AddCondition2Button);
            this.Controls.Add(this.AddConditionButton);
            this.Controls.Add(this.ConfirmStatementButton);
            this.Controls.Add(this.ResetStatementButton);
            this.Controls.Add(this.ResetProgramButton);
            this.Controls.Add(this.AddToProgramButton);
            this.Controls.Add(this.AskQueryButton);
            this.Controls.Add(this.Actor2ComboBox);
            this.Controls.Add(this.GammaComboBox);
            this.Controls.Add(this.Pi2ComboBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.QueriesOutcomeLabel);
            this.Controls.Add(this.QueriesComboBox);
            this.Controls.Add(this.ResponseTextBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.ProgramActorComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ProgramActionComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.StatementsTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FluentComboBox);
            this.Controls.Add(this.PiComboBox);
            this.Controls.Add(this.ActorComboBox);
            this.Controls.Add(this.ActionComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProgramLabel);
            this.Controls.Add(this.QueriesLabel);
            this.Controls.Add(this.StatementsLabel);
            this.Controls.Add(this.StatementsComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(850, 1200);
            this.MinimumSize = new System.Drawing.Size(850, 900);
            this.Name = "RWGui";
            this.Text = "Programy działań z efektami domyślnymi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox actorsTextBox;
        private System.Windows.Forms.TextBox actionsTextBox;
        private System.Windows.Forms.TextBox fluentsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StatementsComboBox;
        private System.Windows.Forms.Label StatementsLabel;
        private System.Windows.Forms.Label QueriesLabel;
        private System.Windows.Forms.Label ProgramLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.ComboBox ActorComboBox;
        private System.Windows.Forms.ComboBox PiComboBox;
        private System.Windows.Forms.ComboBox FluentComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox StatementsTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ProgramActionComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ProgramActorComboBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox ResponseTextBox;
        private System.Windows.Forms.ComboBox QueriesComboBox;
        private System.Windows.Forms.Label QueriesOutcomeLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox Pi2ComboBox;
        private System.Windows.Forms.ComboBox GammaComboBox;
        private System.Windows.Forms.ComboBox Actor2ComboBox;
        private System.Windows.Forms.Button AskQueryButton;
        private System.Windows.Forms.Button AddToProgramButton;
        private System.Windows.Forms.Button ResetProgramButton;
        private System.Windows.Forms.Button ResetStatementButton;
        private System.Windows.Forms.Button AddConditionButton;
        private System.Windows.Forms.Button ConfirmStatementButton;
        private System.Windows.Forms.Button AddCondition2Button;
        private System.Windows.Forms.Button AddInitialStateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ResetQueryButton;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button AddQueryButton;
        private System.Windows.Forms.Button DeleteLastStatementButton;
        private System.Windows.Forms.Button DeleteLastProgramButton;
    }
}

