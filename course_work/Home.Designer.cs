
namespace course_work
{
    partial class Home
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
            this.btn_registration = new System.Windows.Forms.Button();
            this.btn_payments = new System.Windows.Forms.Button();
            this.btn_view_student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registration
            // 
            this.btn_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registration.Location = new System.Drawing.Point(264, 39);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(175, 68);
            this.btn_registration.TabIndex = 0;
            this.btn_registration.Text = "Registration";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // btn_payments
            // 
            this.btn_payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payments.Location = new System.Drawing.Point(264, 181);
            this.btn_payments.Name = "btn_payments";
            this.btn_payments.Size = new System.Drawing.Size(175, 68);
            this.btn_payments.TabIndex = 1;
            this.btn_payments.Text = "Payments";
            this.btn_payments.UseVisualStyleBackColor = true;
            this.btn_payments.Click += new System.EventHandler(this.btn_payments_Click);
            // 
            // btn_view_student
            // 
            this.btn_view_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_student.Location = new System.Drawing.Point(264, 342);
            this.btn_view_student.Name = "btn_view_student";
            this.btn_view_student.Size = new System.Drawing.Size(175, 68);
            this.btn_view_student.TabIndex = 2;
            this.btn_view_student.Text = "View Student";
            this.btn_view_student.UseVisualStyleBackColor = true;
            this.btn_view_student.Click += new System.EventHandler(this.btn_view_student_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_view_student);
            this.Controls.Add(this.btn_payments);
            this.Controls.Add(this.btn_registration);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_payments;
        private System.Windows.Forms.Button btn_view_student;
    }
}

