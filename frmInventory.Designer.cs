namespace SimpleInventory
{
   partial class frmInventory
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxCost = new System.Windows.Forms.TextBox();
            this.txtBxQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtBxOutput = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Item #:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(28, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(28, 103);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(28, 140);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(114, 32);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(89, 20);
            this.txtBxID.TabIndex = 1;
            this.txtBxID.Enter += new System.EventHandler(this.TxtBxID_Enter);
            this.txtBxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxID_KeyPress);
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(114, 66);
            this.txtBxDescription.MaxLength = 100;
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(352, 20);
            this.txtBxDescription.TabIndex = 3;
            this.txtBxDescription.Enter += new System.EventHandler(this.TxtBxDescription_Enter);
            // 
            // txtBxCost
            // 
            this.txtBxCost.Location = new System.Drawing.Point(114, 100);
            this.txtBxCost.Name = "txtBxCost";
            this.txtBxCost.Size = new System.Drawing.Size(64, 20);
            this.txtBxCost.TabIndex = 5;
            this.txtBxCost.Enter += new System.EventHandler(this.TxtBxCost_Enter);
            this.txtBxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxCost_KeyPress);
            // 
            // txtBxQuantity
            // 
            this.txtBxQuantity.Location = new System.Drawing.Point(114, 137);
            this.txtBxQuantity.Name = "txtBxQuantity";
            this.txtBxQuantity.Size = new System.Drawing.Size(64, 20);
            this.txtBxQuantity.TabIndex = 7;
            this.txtBxQuantity.Enter += new System.EventHandler(this.TxtBxQuantity_Enter);
            this.txtBxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBxQuantity_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(622, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(622, 140);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 29);
            this.btnDisplay.TabIndex = 9;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxOutput.Location = new System.Drawing.Point(31, 196);
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.ReadOnly = true;
            this.txtBxOutput.Size = new System.Drawing.Size(688, 149);
            this.txtBxOutput.TabIndex = 13;
            this.txtBxOutput.Text = "";
            this.txtBxOutput.WordWrap = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(644, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(622, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 29);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(31, 378);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // frmInventory
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 423);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtBxOutput);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxQuantity);
            this.Controls.Add(this.txtBxCost);
            this.Controls.Add(this.txtBxDescription);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblID);
            this.Name = "frmInventory";
            this.Text = "Item Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblID;
      private System.Windows.Forms.Label lblDescription;
      private System.Windows.Forms.Label lblCost;
      private System.Windows.Forms.Label lblQuantity;
      private System.Windows.Forms.TextBox txtBxID;
      private System.Windows.Forms.TextBox txtBxDescription;
      private System.Windows.Forms.TextBox txtBxCost;
      private System.Windows.Forms.TextBox txtBxQuantity;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnDisplay;
      private System.Windows.Forms.RichTextBox txtBxOutput;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnReset;
   }
}

