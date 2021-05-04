namespace DoubleWindowSolution
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LB_Params = new System.Windows.Forms.ListBox();
            this.TB_ParamContext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(9, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(9, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LB_Params
            // 
            this.LB_Params.FormattingEnabled = true;
            this.LB_Params.Location = new System.Drawing.Point(180, 12);
            this.LB_Params.Name = "LB_Params";
            this.LB_Params.Size = new System.Drawing.Size(179, 238);
            this.LB_Params.TabIndex = 2;
            this.LB_Params.SelectedIndexChanged += new System.EventHandler(this.LB_Params_SelectedIndexChanged);
            // 
            // TB_ParamContext
            // 
            this.TB_ParamContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TB_ParamContext.Location = new System.Drawing.Point(365, 12);
            this.TB_ParamContext.Multiline = true;
            this.TB_ParamContext.Name = "TB_ParamContext";
            this.TB_ParamContext.Size = new System.Drawing.Size(237, 238);
            this.TB_ParamContext.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 260);
            this.Controls.Add(this.TB_ParamContext);
            this.Controls.Add(this.LB_Params);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox LB_Params;
        private System.Windows.Forms.TextBox TB_ParamContext;
    }
}