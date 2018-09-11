namespace appSkillsDemoTwoCars
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.LblConnect = new System.Windows.Forms.Label();
            this.BtnRead = new System.Windows.Forms.Button();
            this.LblOrderNumber = new System.Windows.Forms.Label();
            this.LblCarManufacturer = new System.Windows.Forms.Label();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblColour = new System.Windows.Forms.Label();
            this.LblPetrol = new System.Windows.Forms.Label();
            this.LblEngineSize = new System.Windows.Forms.Label();
            this.BtnAddCar = new System.Windows.Forms.Button();
            this.TxtOrderNumber = new System.Windows.Forms.TextBox();
            this.TxtCarManufacturer = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtColour = new System.Windows.Forms.TextBox();
            this.TxtEngineSize = new System.Windows.Forms.TextBox();
            this.ChkPetrol = new System.Windows.Forms.CheckBox();
            this.LstCars = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAmend = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.Color.Lime;
            this.BtnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(1, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(111, 40);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Show Connection";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // LblConnect
            // 
            this.LblConnect.BackColor = System.Drawing.Color.White;
            this.LblConnect.Location = new System.Drawing.Point(118, 12);
            this.LblConnect.Name = "LblConnect";
            this.LblConnect.Size = new System.Drawing.Size(100, 40);
            this.LblConnect.TabIndex = 1;
            // 
            // BtnRead
            // 
            this.BtnRead.BackColor = System.Drawing.Color.Blue;
            this.BtnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRead.ForeColor = System.Drawing.Color.White;
            this.BtnRead.Location = new System.Drawing.Point(375, 12);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(121, 30);
            this.BtnRead.TabIndex = 2;
            this.BtnRead.Text = "Show Database";
            this.BtnRead.UseVisualStyleBackColor = false;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // LblOrderNumber
            // 
            this.LblOrderNumber.AutoSize = true;
            this.LblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrderNumber.ForeColor = System.Drawing.Color.White;
            this.LblOrderNumber.Location = new System.Drawing.Point(-2, 84);
            this.LblOrderNumber.Name = "LblOrderNumber";
            this.LblOrderNumber.Size = new System.Drawing.Size(98, 15);
            this.LblOrderNumber.TabIndex = 3;
            this.LblOrderNumber.Text = "Order Number";
            // 
            // LblCarManufacturer
            // 
            this.LblCarManufacturer.AutoSize = true;
            this.LblCarManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarManufacturer.ForeColor = System.Drawing.Color.White;
            this.LblCarManufacturer.Location = new System.Drawing.Point(-2, 110);
            this.LblCarManufacturer.Name = "LblCarManufacturer";
            this.LblCarManufacturer.Size = new System.Drawing.Size(118, 15);
            this.LblCarManufacturer.TabIndex = 4;
            this.LblCarManufacturer.Text = "Car Manufacturer";
            // 
            // LblModel
            // 
            this.LblModel.AutoSize = true;
            this.LblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModel.ForeColor = System.Drawing.Color.White;
            this.LblModel.Location = new System.Drawing.Point(-2, 136);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(47, 15);
            this.LblModel.TabIndex = 5;
            this.LblModel.Text = "Model";
            // 
            // LblColour
            // 
            this.LblColour.AutoSize = true;
            this.LblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColour.ForeColor = System.Drawing.Color.White;
            this.LblColour.Location = new System.Drawing.Point(-2, 162);
            this.LblColour.Name = "LblColour";
            this.LblColour.Size = new System.Drawing.Size(49, 15);
            this.LblColour.TabIndex = 6;
            this.LblColour.Text = "Colour";
            // 
            // LblPetrol
            // 
            this.LblPetrol.AutoSize = true;
            this.LblPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPetrol.ForeColor = System.Drawing.Color.White;
            this.LblPetrol.Location = new System.Drawing.Point(-2, 190);
            this.LblPetrol.Name = "LblPetrol";
            this.LblPetrol.Size = new System.Drawing.Size(45, 15);
            this.LblPetrol.TabIndex = 7;
            this.LblPetrol.Text = "Petrol";
            // 
            // LblEngineSize
            // 
            this.LblEngineSize.AutoSize = true;
            this.LblEngineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEngineSize.ForeColor = System.Drawing.Color.White;
            this.LblEngineSize.Location = new System.Drawing.Point(-2, 217);
            this.LblEngineSize.Name = "LblEngineSize";
            this.LblEngineSize.Size = new System.Drawing.Size(84, 15);
            this.LblEngineSize.TabIndex = 8;
            this.LblEngineSize.Text = "Engine Size";
            // 
            // BtnAddCar
            // 
            this.BtnAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCar.ForeColor = System.Drawing.Color.White;
            this.BtnAddCar.Location = new System.Drawing.Point(375, 48);
            this.BtnAddCar.Name = "BtnAddCar";
            this.BtnAddCar.Size = new System.Drawing.Size(121, 29);
            this.BtnAddCar.TabIndex = 9;
            this.BtnAddCar.Text = "Add Car";
            this.BtnAddCar.UseVisualStyleBackColor = false;
            this.BtnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // TxtOrderNumber
            // 
            this.TxtOrderNumber.Location = new System.Drawing.Point(116, 79);
            this.TxtOrderNumber.Name = "TxtOrderNumber";
            this.TxtOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtOrderNumber.TabIndex = 10;
            // 
            // TxtCarManufacturer
            // 
            this.TxtCarManufacturer.Location = new System.Drawing.Point(116, 105);
            this.TxtCarManufacturer.Name = "TxtCarManufacturer";
            this.TxtCarManufacturer.Size = new System.Drawing.Size(100, 20);
            this.TxtCarManufacturer.TabIndex = 11;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(116, 131);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(100, 20);
            this.TxtModel.TabIndex = 12;
            // 
            // TxtColour
            // 
            this.TxtColour.Location = new System.Drawing.Point(116, 157);
            this.TxtColour.Name = "TxtColour";
            this.TxtColour.Size = new System.Drawing.Size(100, 20);
            this.TxtColour.TabIndex = 13;
            // 
            // TxtEngineSize
            // 
            this.TxtEngineSize.Location = new System.Drawing.Point(116, 217);
            this.TxtEngineSize.Name = "TxtEngineSize";
            this.TxtEngineSize.Size = new System.Drawing.Size(100, 20);
            this.TxtEngineSize.TabIndex = 15;
            // 
            // ChkPetrol
            // 
            this.ChkPetrol.AutoSize = true;
            this.ChkPetrol.Location = new System.Drawing.Point(116, 190);
            this.ChkPetrol.Name = "ChkPetrol";
            this.ChkPetrol.Size = new System.Drawing.Size(15, 14);
            this.ChkPetrol.TabIndex = 16;
            this.ChkPetrol.UseVisualStyleBackColor = true;
            // 
            // LstCars
            // 
            this.LstCars.FormattingEnabled = true;
            this.LstCars.Location = new System.Drawing.Point(225, 12);
            this.LstCars.Name = "LstCars";
            this.LstCars.Size = new System.Drawing.Size(144, 225);
            this.LstCars.TabIndex = 17;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(375, 125);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(121, 29);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete Record";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAmend
            // 
            this.BtnAmend.BackColor = System.Drawing.Color.Yellow;
            this.BtnAmend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAmend.ForeColor = System.Drawing.Color.Black;
            this.BtnAmend.Location = new System.Drawing.Point(375, 84);
            this.BtnAmend.Name = "BtnAmend";
            this.BtnAmend.Size = new System.Drawing.Size(121, 31);
            this.BtnAmend.TabIndex = 19;
            this.BtnAmend.Text = "Update Record";
            this.BtnAmend.UseVisualStyleBackColor = false;
            this.BtnAmend.Click += new System.EventHandler(this.BtnAmend_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.White;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(375, 197);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(121, 40);
            this.BtnExit.TabIndex = 20;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.Lime;
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.ForeColor = System.Drawing.Color.Black;
            this.BtnHelp.Location = new System.Drawing.Point(375, 162);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(121, 29);
            this.BtnHelp.TabIndex = 21;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(498, 244);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAmend);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LstCars);
            this.Controls.Add(this.ChkPetrol);
            this.Controls.Add(this.TxtEngineSize);
            this.Controls.Add(this.TxtColour);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.TxtCarManufacturer);
            this.Controls.Add(this.TxtOrderNumber);
            this.Controls.Add(this.BtnAddCar);
            this.Controls.Add(this.LblEngineSize);
            this.Controls.Add(this.LblPetrol);
            this.Controls.Add(this.LblColour);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.LblCarManufacturer);
            this.Controls.Add(this.LblOrderNumber);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.LblConnect);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label LblConnect;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label LblOrderNumber;
        private System.Windows.Forms.Label LblCarManufacturer;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblColour;
        private System.Windows.Forms.Label LblPetrol;
        private System.Windows.Forms.Label LblEngineSize;
        private System.Windows.Forms.Button BtnAddCar;
        private System.Windows.Forms.TextBox TxtOrderNumber;
        private System.Windows.Forms.TextBox TxtCarManufacturer;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtColour;
        private System.Windows.Forms.TextBox TxtEngineSize;
        private System.Windows.Forms.CheckBox ChkPetrol;
        private System.Windows.Forms.ListBox LstCars;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAmend;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnHelp;
    }
}

