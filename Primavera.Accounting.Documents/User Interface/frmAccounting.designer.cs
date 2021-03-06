﻿namespace Primavera.Accounting.Documents
{
    partial class FrmInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJournal = new System.Windows.Forms.TextBox();
            this.Linhas = new System.Windows.Forms.GroupBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtDocumentDescription = new System.Windows.Forms.TextBox();
            this.txtJournalDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.NumericUpDown();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxNature = new System.Windows.Forms.ComboBox();
            this.numericValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Linhas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doc. Type";
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(105, 38);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.Size = new System.Drawing.Size(69, 20);
            this.txtTipoDoc.TabIndex = 1;
            this.txtTipoDoc.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTipoDoc_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Journal";
            // 
            // txtJournal
            // 
            this.txtJournal.Location = new System.Drawing.Point(105, 64);
            this.txtJournal.Name = "txtJournal";
            this.txtJournal.Size = new System.Drawing.Size(69, 20);
            this.txtJournal.TabIndex = 3;
            this.txtJournal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtJournal_Validating);
            // 
            // Linhas
            // 
            this.Linhas.Controls.Add(this.label3);
            this.Linhas.Controls.Add(this.numericValue);
            this.Linhas.Controls.Add(this.comboBoxNature);
            this.Linhas.Controls.Add(this.cmdAdd);
            this.Linhas.Controls.Add(this.listView1);
            this.Linhas.Controls.Add(this.label7);
            this.Linhas.Controls.Add(this.label6);
            this.Linhas.Controls.Add(this.textAccount);
            this.Linhas.Location = new System.Drawing.Point(12, 90);
            this.Linhas.Name = "Linhas";
            this.Linhas.Size = new System.Drawing.Size(397, 180);
            this.Linhas.TabIndex = 8;
            this.Linhas.TabStop = false;
            this.Linhas.Text = "Document Lines";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(337, 37);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(54, 19);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(6, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 112);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Account";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Account";
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(6, 36);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(92, 20);
            this.textAccount.TabIndex = 5;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(422, 247);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(94, 23);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(422, 218);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(94, 23);
            this.cmdSave.TabIndex = 10;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // txtDocumentDescription
            // 
            this.txtDocumentDescription.Location = new System.Drawing.Point(180, 38);
            this.txtDocumentDescription.Name = "txtDocumentDescription";
            this.txtDocumentDescription.Size = new System.Drawing.Size(229, 20);
            this.txtDocumentDescription.TabIndex = 11;
            // 
            // txtJournalDescription
            // 
            this.txtJournalDescription.Location = new System.Drawing.Point(180, 64);
            this.txtJournalDescription.Name = "txtJournalDescription";
            this.txtJournalDescription.Size = new System.Drawing.Size(229, 20);
            this.txtJournalDescription.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(105, 12);
            this.txtYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(69, 20);
            this.txtYear.TabIndex = 14;
            this.txtYear.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valor";
            this.columnHeader3.Width = 100;
            // 
            // comboBoxNature
            // 
            this.comboBoxNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNature.FormattingEnabled = true;
            this.comboBoxNature.Items.AddRange(new object[] {
            "D",
            "C"});
            this.comboBoxNature.Location = new System.Drawing.Point(113, 35);
            this.comboBoxNature.Name = "comboBoxNature";
            this.comboBoxNature.Size = new System.Drawing.Size(58, 21);
            this.comboBoxNature.TabIndex = 6;
            // 
            // numericValue
            // 
            this.numericValue.Location = new System.Drawing.Point(187, 37);
            this.numericValue.Name = "numericValue";
            this.numericValue.Size = new System.Drawing.Size(67, 20);
            this.numericValue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nature";
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 282);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJournalDescription);
            this.Controls.Add(this.txtDocumentDescription);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.Linhas);
            this.Controls.Add(this.txtJournal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoDoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvoice";
            this.Text = "Accounting Document Sample";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.Linhas.ResumeLayout(false);
            this.Linhas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJournal;
        private System.Windows.Forms.GroupBox Linhas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtDocumentDescription;
        private System.Windows.Forms.TextBox txtJournalDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtYear;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericValue;
        private System.Windows.Forms.ComboBox comboBoxNature;
    }
}