
namespace course_work
{
    partial class Payments
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_payment_id = new System.Windows.Forms.TextBox();
            this.txt_payment_subject_id = new System.Windows.Forms.TextBox();
            this.txt_payment_studentID = new System.Windows.Forms.TextBox();
            this.txt_payment_fees = new System.Windows.Forms.TextBox();
            this.btn_save_pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fees ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject ID";
            // 
            // txt_payment_id
            // 
            this.txt_payment_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment_id.Location = new System.Drawing.Point(276, 44);
            this.txt_payment_id.Multiline = true;
            this.txt_payment_id.Name = "txt_payment_id";
            this.txt_payment_id.Size = new System.Drawing.Size(239, 30);
            this.txt_payment_id.TabIndex = 5;
            // 
            // txt_payment_subject_id
            // 
            this.txt_payment_subject_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment_subject_id.Location = new System.Drawing.Point(276, 207);
            this.txt_payment_subject_id.Multiline = true;
            this.txt_payment_subject_id.Name = "txt_payment_subject_id";
            this.txt_payment_subject_id.Size = new System.Drawing.Size(239, 30);
            this.txt_payment_subject_id.TabIndex = 6;
            // 
            // txt_payment_studentID
            // 
            this.txt_payment_studentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment_studentID.Location = new System.Drawing.Point(276, 149);
            this.txt_payment_studentID.Multiline = true;
            this.txt_payment_studentID.Name = "txt_payment_studentID";
            this.txt_payment_studentID.Size = new System.Drawing.Size(239, 30);
            this.txt_payment_studentID.TabIndex = 7;
            // 
            // txt_payment_fees
            // 
            this.txt_payment_fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment_fees.Location = new System.Drawing.Point(276, 91);
            this.txt_payment_fees.Multiline = true;
            this.txt_payment_fees.Name = "txt_payment_fees";
            this.txt_payment_fees.Size = new System.Drawing.Size(239, 30);
            this.txt_payment_fees.TabIndex = 8;
            // 
            // btn_save_pay
            // 
            this.btn_save_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_pay.Location = new System.Drawing.Point(440, 292);
            this.btn_save_pay.Name = "btn_save_pay";
            this.btn_save_pay.Size = new System.Drawing.Size(75, 23);
            this.btn_save_pay.TabIndex = 11;
            this.btn_save_pay.Text = "Save";
            this.btn_save_pay.UseVisualStyleBackColor = true;
            this.btn_save_pay.Click += new System.EventHandler(this.btn_save_pay_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save_pay);
            this.Controls.Add(this.txt_payment_fees);
            this.Controls.Add(this.txt_payment_studentID);
            this.Controls.Add(this.txt_payment_subject_id);
            this.Controls.Add(this.txt_payment_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payments";
            this.Text = "Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_payment_id;
        private System.Windows.Forms.TextBox txt_payment_subject_id;
        private System.Windows.Forms.TextBox txt_payment_studentID;
        private System.Windows.Forms.TextBox txt_payment_fees;
        private System.Windows.Forms.Button btn_save_pay;
    }
}