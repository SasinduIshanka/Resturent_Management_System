
namespace course_work
{
    partial class View_Student
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
            this.data_grid_1 = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_1)).BeginInit();
            this.SuspendLayout();
            // 
            // data_grid_1
            // 
            this.data_grid_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_1.Location = new System.Drawing.Point(44, 39);
            this.data_grid_1.Name = "data_grid_1";
            this.data_grid_1.Size = new System.Drawing.Size(679, 238);
            this.data_grid_1.TabIndex = 0;
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(572, 325);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(151, 42);
            this.btn_view.TabIndex = 11;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // View_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.data_grid_1);
            this.Name = "View_Student";
            this.Text = "View_Student";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_grid_1;
        private System.Windows.Forms.Button btn_view;
    }
}