namespace ModelMainForm
{
    partial class AddMasterForm
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
            this.components = new System.ComponentModel.Container();
            this.addServiceToMaster = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claimWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimWorkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addServiceToMaster
            // 
            this.addServiceToMaster.Location = new System.Drawing.Point(76, 161);
            this.addServiceToMaster.Name = "addServiceToMaster";
            this.addServiceToMaster.Size = new System.Drawing.Size(148, 23);
            this.addServiceToMaster.TabIndex = 2;
            this.addServiceToMaster.Text = "Добавить услугу";
            this.addServiceToMaster.UseVisualStyleBackColor = true;
            this.addServiceToMaster.Click += new System.EventHandler(this.addServiceToMaster_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Задайте время, за которое работник \r\nоказывает выбранную услугу (в минутах)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataSource = typeof(ModelMainForm.Service);
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(ModelMainForm.Service);
            // 
            // claimWorkerBindingSource
            // 
            this.claimWorkerBindingSource.DataSource = typeof(ModelMainForm.MVP.Model.ClaimWorker);
            // 
            // AddMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addServiceToMaster);
            this.Name = "AddMasterForm";
            this.Text = "AddMasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimWorkerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addServiceToMaster;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.BindingSource claimWorkerBindingSource;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
    }
}