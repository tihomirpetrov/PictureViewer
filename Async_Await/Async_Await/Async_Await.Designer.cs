namespace Async_Await
{
    partial class Async_Await
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
            this.btn_normal_execution = new System.Windows.Forms.Button();
            this.pb_loading_bar = new System.Windows.Forms.ProgressBar();
            this.lb_content_view = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_normal_execution
            // 
            this.btn_normal_execution.Location = new System.Drawing.Point(23, 94);
            this.btn_normal_execution.Name = "btn_normal_execution";
            this.btn_normal_execution.Size = new System.Drawing.Size(478, 47);
            this.btn_normal_execution.TabIndex = 0;
            this.btn_normal_execution.Text = "Normal Execution";
            this.btn_normal_execution.UseVisualStyleBackColor = true;
            this.btn_normal_execution.Click += new System.EventHandler(this.Btn_normal_execution_Click);
            // 
            // pb_loading_bar
            // 
            this.pb_loading_bar.Location = new System.Drawing.Point(23, 305);
            this.pb_loading_bar.Name = "pb_loading_bar";
            this.pb_loading_bar.Size = new System.Drawing.Size(478, 23);
            this.pb_loading_bar.TabIndex = 1;
            // 
            // lb_content_view
            // 
            this.lb_content_view.FormattingEnabled = true;
            this.lb_content_view.Location = new System.Drawing.Point(23, 178);
            this.lb_content_view.Name = "lb_content_view";
            this.lb_content_view.Size = new System.Drawing.Size(478, 121);
            this.lb_content_view.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 358);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_content_view);
            this.Controls.Add(this.pb_loading_bar);
            this.Controls.Add(this.btn_normal_execution);
            this.Name = "Form1";
            this.Text = "Async_Await";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_normal_execution;
        private System.Windows.Forms.ProgressBar pb_loading_bar;
        private System.Windows.Forms.ListBox lb_content_view;
        private System.Windows.Forms.TextBox textBox1;
    }
}

