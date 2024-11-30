namespace Tuan7_2
{
    partial class Form1
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
            this.txtNhapMang = new System.Windows.Forms.TextBox();
            this.btnSaveArray = new System.Windows.Forms.Button();
            this.btnReadArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDungDaLuu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mảng";
            // 
            // txtNhapMang
            // 
            this.txtNhapMang.Location = new System.Drawing.Point(189, 44);
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new System.Drawing.Size(382, 22);
            this.txtNhapMang.TabIndex = 1;
            // 
            // btnSaveArray
            // 
            this.btnSaveArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveArray.Location = new System.Drawing.Point(189, 132);
            this.btnSaveArray.Name = "btnSaveArray";
            this.btnSaveArray.Size = new System.Drawing.Size(151, 46);
            this.btnSaveArray.TabIndex = 2;
            this.btnSaveArray.Text = "Lưu mảng";
            this.btnSaveArray.UseVisualStyleBackColor = true;
            this.btnSaveArray.Click += new System.EventHandler(this.btnSaveArray_Click);
            // 
            // btnReadArray
            // 
            this.btnReadArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadArray.Location = new System.Drawing.Point(414, 132);
            this.btnReadArray.Name = "btnReadArray";
            this.btnReadArray.Size = new System.Drawing.Size(128, 46);
            this.btnReadArray.TabIndex = 3;
            this.btnReadArray.Text = "Đọc mảng";
            this.btnReadArray.UseVisualStyleBackColor = true;
            this.btnReadArray.Click += new System.EventHandler(this.btnReadArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nội dung đã lưu";
            // 
            // txtNoiDungDaLuu
            // 
            this.txtNoiDungDaLuu.Location = new System.Drawing.Point(189, 252);
            this.txtNoiDungDaLuu.Name = "txtNoiDungDaLuu";
            this.txtNoiDungDaLuu.Size = new System.Drawing.Size(382, 22);
            this.txtNoiDungDaLuu.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.txtNoiDungDaLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReadArray);
            this.Controls.Add(this.btnSaveArray);
            this.Controls.Add(this.txtNhapMang);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapMang;
        private System.Windows.Forms.Button btnSaveArray;
        private System.Windows.Forms.Button btnReadArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiDungDaLuu;
    }
}

