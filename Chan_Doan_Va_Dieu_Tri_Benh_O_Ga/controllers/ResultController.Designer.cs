﻿namespace Chan_Doan_Va_Dieu_Tri_Benh_O_Ga.controllers
{
    partial class ResultController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultController));
            this.label1 = new System.Windows.Forms.Label();
            this.labelDiseaseName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextDT = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gà của bạn đã mắc bệnh:";
            // 
            // labelDiseaseName
            // 
            this.labelDiseaseName.AutoSize = true;
            this.labelDiseaseName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiseaseName.Location = new System.Drawing.Point(342, 17);
            this.labelDiseaseName.Name = "labelDiseaseName";
            this.labelDiseaseName.Size = new System.Drawing.Size(0, 38);
            this.labelDiseaseName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cách điều trị:";
            // 
            // richTextDT
            // 
            this.richTextDT.BackColor = System.Drawing.Color.White;
            this.richTextDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextDT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextDT.Location = new System.Drawing.Point(24, 143);
            this.richTextDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextDT.Name = "richTextDT";
            this.richTextDT.ReadOnly = true;
            this.richTextDT.Size = new System.Drawing.Size(768, 204);
            this.richTextDT.TabIndex = 3;
            this.richTextDT.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Blue;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(587, 375);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(205, 70);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Chẩn đoán lại";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ResultController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.richTextDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDiseaseName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ResultController";
            this.Size = new System.Drawing.Size(818, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDiseaseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextDT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonBack;
    }
}
