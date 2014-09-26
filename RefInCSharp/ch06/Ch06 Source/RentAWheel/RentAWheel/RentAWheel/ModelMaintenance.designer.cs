﻿namespace RentAWheel
{
    partial class ModelMaintenance
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
            this.label3 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.reload = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.newModel = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Category:";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(11, 118);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(140, 21);
            this.category.TabIndex = 38;
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(195, 131);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(62, 31);
            this.reload.TabIndex = 37;
            this.reload.Text = "Reload";
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(195, 94);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(62, 31);
            this.delete.TabIndex = 36;
            this.delete.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(195, 57);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(62, 31);
            this.save.TabIndex = 35;
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // newModel
            // 
            this.newModel.Location = new System.Drawing.Point(195, 22);
            this.newModel.Name = "newModel";
            this.newModel.Size = new System.Drawing.Size(62, 31);
            this.newModel.TabIndex = 34;
            this.newModel.Text = "New";
            this.newModel.Click += new System.EventHandler(this.new_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(121, 159);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 24);
            this.btnLast.TabIndex = 33;
            this.btnLast.Text = ">>";
            this.btnLast.Click += new System.EventHandler(this.last_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(83, 159);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 24);
            this.btnRight.TabIndex = 32;
            this.btnRight.Text = ">";
            this.btnRight.Click += new System.EventHandler(this.right_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(47, 159);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(30, 24);
            this.btnLeft.TabIndex = 31;
            this.btnLeft.Text = "<";
            this.btnLeft.Click += new System.EventHandler(this.left_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(11, 159);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 24);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.Text = "<<";
            this.btnFirst.Click += new System.EventHandler(this.first_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(11, 70);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 20);
            this.name.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Model Name:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(12, 22);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(139, 20);
            this.id.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Model Id:";
            // 
            // ModelMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.newModel);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "ModelMaintenance";
            this.Text = "Models";
            this.Load += new System.EventHandler(this.ModelMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox category;
        internal System.Windows.Forms.Button reload;
        internal System.Windows.Forms.Button delete;
        internal System.Windows.Forms.Button save;
        internal System.Windows.Forms.Button newModel;
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Button btnRight;
        internal System.Windows.Forms.Button btnLeft;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox id;
        internal System.Windows.Forms.Label label1;
    }
}