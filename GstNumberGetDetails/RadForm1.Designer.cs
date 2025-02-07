
namespace GstNumberGetDetails
{
    partial class frmGstDetails
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.dgvGstDetails = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGstDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGstDetails.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(477, 23);
            this.radTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(244, 20);
            this.radTextBox1.TabIndex = 4;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI Black", 9.25F);
            this.radButton1.Location = new System.Drawing.Point(748, 20);
            this.radButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(103, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Find Now";
            // 
            // dgvGstDetails
            // 
            this.dgvGstDetails.Location = new System.Drawing.Point(1, 63);
            // 
            // 
            // 
            this.dgvGstDetails.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.dgvGstDetails.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.dgvGstDetails.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvGstDetails.Name = "dgvGstDetails";
            this.dgvGstDetails.Size = new System.Drawing.Size(1028, 292);
            this.dgvGstDetails.TabIndex = 5;
            // 
            // frmGstDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 356);
            this.Controls.Add(this.dgvGstDetails);
            this.Controls.Add(this.radTextBox1);
            this.Controls.Add(this.radButton1);
            this.Name = "frmGstDetails";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGstDetails.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGstDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView dgvGstDetails;
    }
}