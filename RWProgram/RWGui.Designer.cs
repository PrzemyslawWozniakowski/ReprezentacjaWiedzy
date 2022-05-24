﻿namespace RWProgram
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
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.actorComboBox = new System.Windows.Forms.ComboBox();
            this.piComboBox = new System.Windows.Forms.ComboBox();
            this.fluentComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StatementsTextBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ProgramActionComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ProgramActorComboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.QueriesOutcomeLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.AskQueryButton = new System.Windows.Forms.Button();
            this.AddToProgramButton = new System.Windows.Forms.Button();
            this.ResetProgramButton = new System.Windows.Forms.Button();
            this.ResetStatementButton = new System.Windows.Forms.Button();
            this.AddConditionButton = new System.Windows.Forms.Button();
            this.ConfirmStatementButton = new System.Windows.Forms.Button();
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
            this.StatementsLabel.Location = new System.Drawing.Point(15, 326);
            this.StatementsLabel.Name = "StatementsLabel";
            this.StatementsLabel.Size = new System.Drawing.Size(197, 25);
            this.StatementsLabel.TabIndex = 3;
            this.StatementsLabel.Text = "Dodane wyrażenia:";
            // 
            // QueriesLabel
            // 
            this.QueriesLabel.AutoSize = true;
            this.QueriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QueriesLabel.Location = new System.Drawing.Point(13, 561);
            this.QueriesLabel.Name = "QueriesLabel";
            this.QueriesLabel.Size = new System.Drawing.Size(115, 25);
            this.QueriesLabel.TabIndex = 4;
            this.QueriesLabel.Text = "Kwerendy:";
            // 
            // ProgramLabel
            // 
            this.ProgramLabel.AutoSize = true;
            this.ProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProgramLabel.Location = new System.Drawing.Point(18, 428);
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
            // actionComboBox
            // 
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Location = new System.Drawing.Point(50, 235);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(85, 24);
            this.actionComboBox.TabIndex = 10;
            // 
            // actorComboBox
            // 
            this.actorComboBox.FormattingEnabled = true;
            this.actorComboBox.Location = new System.Drawing.Point(166, 235);
            this.actorComboBox.Name = "actorComboBox";
            this.actorComboBox.Size = new System.Drawing.Size(85, 24);
            this.actorComboBox.TabIndex = 11;
            // 
            // piComboBox
            // 
            this.piComboBox.FormattingEnabled = true;
            this.piComboBox.Location = new System.Drawing.Point(284, 235);
            this.piComboBox.Name = "piComboBox";
            this.piComboBox.Size = new System.Drawing.Size(85, 24);
            this.piComboBox.TabIndex = 12;
            // 
            // fluentComboBox
            // 
            this.fluentComboBox.FormattingEnabled = true;
            this.fluentComboBox.Location = new System.Drawing.Point(432, 235);
            this.fluentComboBox.Name = "fluentComboBox";
            this.fluentComboBox.Size = new System.Drawing.Size(85, 24);
            this.fluentComboBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickAddStatementButton);
            // 
            // StatementsTextBox
            // 
            this.StatementsTextBox.Location = new System.Drawing.Point(260, 326);
            this.StatementsTextBox.Name = "StatementsTextBox";
            this.StatementsTextBox.Size = new System.Drawing.Size(553, 96);
            this.StatementsTextBox.TabIndex = 15;
            this.StatementsTextBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Action:";
            // 
            // ProgramActionComboBox
            // 
            this.ProgramActionComboBox.FormattingEnabled = true;
            this.ProgramActionComboBox.Location = new System.Drawing.Point(79, 467);
            this.ProgramActionComboBox.Name = "ProgramActionComboBox";
            this.ProgramActionComboBox.Size = new System.Drawing.Size(85, 24);
            this.ProgramActionComboBox.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "by:";
            // 
            // ProgramActorComboBox
            // 
            this.ProgramActorComboBox.FormattingEnabled = true;
            this.ProgramActorComboBox.Location = new System.Drawing.Point(201, 467);
            this.ProgramActorComboBox.Name = "ProgramActorComboBox";
            this.ProgramActorComboBox.Size = new System.Drawing.Size(85, 24);
            this.ProgramActorComboBox.TabIndex = 19;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(326, 445);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(472, 96);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(201, 698);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 25);
            this.textBox2.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(152, 558);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(646, 28);
            this.comboBox3.TabIndex = 23;
            // 
            // QueriesOutcomeLabel
            // 
            this.QueriesOutcomeLabel.AutoSize = true;
            this.QueriesOutcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QueriesOutcomeLabel.Location = new System.Drawing.Point(13, 698);
            this.QueriesOutcomeLabel.Name = "QueriesOutcomeLabel";
            this.QueriesOutcomeLabel.Size = new System.Drawing.Size(177, 25);
            this.QueriesOutcomeLabel.TabIndex = 24;
            this.QueriesOutcomeLabel.Text = "Wynik kwerendy:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 610);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(131, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "pi (stan początkowy):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(304, 610);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "gamma (warunek):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(567, 610);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "w (wykonawca):";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(161, 607);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(125, 24);
            this.comboBox4.TabIndex = 28;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(427, 607);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(125, 24);
            this.comboBox5.TabIndex = 29;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(673, 607);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(125, 24);
            this.comboBox6.TabIndex = 30;
            // 
            // AskQueryButton
            // 
            this.AskQueryButton.Location = new System.Drawing.Point(621, 654);
            this.AskQueryButton.Name = "AskQueryButton";
            this.AskQueryButton.Size = new System.Drawing.Size(178, 35);
            this.AskQueryButton.TabIndex = 31;
            this.AskQueryButton.Text = "Odpytaj";
            this.AskQueryButton.UseVisualStyleBackColor = true;
            // 
            // AddToProgramButton
            // 
            this.AddToProgramButton.Location = new System.Drawing.Point(145, 506);
            this.AddToProgramButton.Name = "AddToProgramButton";
            this.AddToProgramButton.Size = new System.Drawing.Size(141, 35);
            this.AddToProgramButton.TabIndex = 32;
            this.AddToProgramButton.Text = "Dodaj";
            this.AddToProgramButton.UseVisualStyleBackColor = true;
            this.AddToProgramButton.Click += new System.EventHandler(this.AddToProgramButton_Click);
            // 
            // ResetProgramButton
            // 
            this.ResetProgramButton.Location = new System.Drawing.Point(13, 506);
            this.ResetProgramButton.Name = "ResetProgramButton";
            this.ResetProgramButton.Size = new System.Drawing.Size(123, 35);
            this.ResetProgramButton.TabIndex = 33;
            this.ResetProgramButton.Text = "Reset";
            this.ResetProgramButton.UseVisualStyleBackColor = true;
            this.ResetProgramButton.Click += new System.EventHandler(this.ResetProgramButton_Click);
            // 
            // ResetStatementButton
            // 
            this.ResetStatementButton.Location = new System.Drawing.Point(89, 375);
            this.ResetStatementButton.Name = "ResetStatementButton";
            this.ResetStatementButton.Size = new System.Drawing.Size(123, 35);
            this.ResetStatementButton.TabIndex = 34;
            this.ResetStatementButton.Text = "Reset";
            this.ResetStatementButton.UseVisualStyleBackColor = true;
            this.ResetStatementButton.Click += new System.EventHandler(this.ResetStatementsButton_Click);
            // 
            // AddConditionButton
            // 
            this.AddConditionButton.Enabled = false;
            this.AddConditionButton.Location = new System.Drawing.Point(628, 270);
            this.AddConditionButton.Name = "AddConditionButton";
            this.AddConditionButton.Size = new System.Drawing.Size(171, 35);
            this.AddConditionButton.TabIndex = 36;
            this.AddConditionButton.Text = "Dodaj warunek";
            this.AddConditionButton.UseVisualStyleBackColor = true;
            this.AddConditionButton.Visible = false;
            this.AddConditionButton.Click += new System.EventHandler(this.AddConditionButton_Click);
            // 
            // ConfirmStatementButton
            // 
            this.ConfirmStatementButton.Enabled = false;
            this.ConfirmStatementButton.Location = new System.Drawing.Point(451, 270);
            this.ConfirmStatementButton.Name = "ConfirmStatementButton";
            this.ConfirmStatementButton.Size = new System.Drawing.Size(171, 35);
            this.ConfirmStatementButton.TabIndex = 35;
            this.ConfirmStatementButton.Text = "Zatwierdź";
            this.ConfirmStatementButton.UseVisualStyleBackColor = true;
            this.ConfirmStatementButton.Visible = false;
            this.ConfirmStatementButton.Click += new System.EventHandler(this.ConfirmStatementButton_Click);
            // 
            // RWGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 735);
            this.Controls.Add(this.AddConditionButton);
            this.Controls.Add(this.ConfirmStatementButton);
            this.Controls.Add(this.ResetStatementButton);
            this.Controls.Add(this.ResetProgramButton);
            this.Controls.Add(this.AddToProgramButton);
            this.Controls.Add(this.AskQueryButton);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.QueriesOutcomeLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.ProgramActorComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ProgramActionComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.StatementsTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fluentComboBox);
            this.Controls.Add(this.piComboBox);
            this.Controls.Add(this.actorComboBox);
            this.Controls.Add(this.actionComboBox);
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
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.ComboBox actorComboBox;
        private System.Windows.Forms.ComboBox piComboBox;
        private System.Windows.Forms.ComboBox fluentComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox StatementsTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ProgramActionComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ProgramActorComboBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label QueriesOutcomeLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button AskQueryButton;
        private System.Windows.Forms.Button AddToProgramButton;
        private System.Windows.Forms.Button ResetProgramButton;
        private System.Windows.Forms.Button ResetStatementButton;
        private System.Windows.Forms.Button AddConditionButton;
        private System.Windows.Forms.Button ConfirmStatementButton;
    }
}

