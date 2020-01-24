namespace Dashboard
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
            this.label3 = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mpg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.miles = new System.Windows.Forms.Label();
            this.driveB = new System.Windows.Forms.Button();
            this.minTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fillB = new System.Windows.Forms.Button();
            this.galTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.newCar = new System.Windows.Forms.Button();
            this.setSpeed = new System.Windows.Forms.Button();
            this.speedTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carName
            // 
            this.carName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carName.Location = new System.Drawing.Point(126, 9);
            this.carName.Margin = new System.Windows.Forms.Padding(0);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(283, 30);
            this.carName.TabIndex = 4;
            this.carName.Text = "car";
            this.carName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed
            // 
            this.speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed.Location = new System.Drawing.Point(126, 39);
            this.speed.Margin = new System.Windows.Forms.Padding(0);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(283, 30);
            this.speed.TabIndex = 6;
            this.speed.Text = "60";
            this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 60);
            this.label5.TabIndex = 7;
            this.label5.Text = "Miles Per Gallon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mpg
            // 
            this.mpg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mpg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpg.Location = new System.Drawing.Point(126, 69);
            this.mpg.Margin = new System.Windows.Forms.Padding(0);
            this.mpg.Name = "mpg";
            this.mpg.Size = new System.Drawing.Size(283, 60);
            this.mpg.TabIndex = 8;
            this.mpg.Text = "60";
            this.mpg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gas Left:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gas
            // 
            this.gas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gas.Location = new System.Drawing.Point(126, 129);
            this.gas.Margin = new System.Windows.Forms.Padding(0);
            this.gas.Name = "gas";
            this.gas.Size = new System.Drawing.Size(283, 30);
            this.gas.TabIndex = 10;
            this.gas.Text = "60";
            this.gas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 60);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tank Capacity:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // capacity
            // 
            this.capacity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.capacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(126, 159);
            this.capacity.Margin = new System.Windows.Forms.Padding(0);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(283, 60);
            this.capacity.TabIndex = 12;
            this.capacity.Text = "60";
            this.capacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 30);
            this.label11.TabIndex = 13;
            this.label11.Text = "Miles Driven:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miles
            // 
            this.miles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.miles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miles.Location = new System.Drawing.Point(126, 219);
            this.miles.Margin = new System.Windows.Forms.Padding(0);
            this.miles.Name = "miles";
            this.miles.Size = new System.Drawing.Size(283, 30);
            this.miles.TabIndex = 14;
            this.miles.Text = "60";
            this.miles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driveB
            // 
            this.driveB.Location = new System.Drawing.Point(9, 249);
            this.driveB.Margin = new System.Windows.Forms.Padding(0);
            this.driveB.Name = "driveB";
            this.driveB.Size = new System.Drawing.Size(117, 30);
            this.driveB.TabIndex = 15;
            this.driveB.Text = "Drive";
            this.driveB.UseVisualStyleBackColor = true;
            this.driveB.Click += new System.EventHandler(this.driveB_Click);
            // 
            // minTB
            // 
            this.minTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTB.Location = new System.Drawing.Point(126, 249);
            this.minTB.Margin = new System.Windows.Forms.Padding(0);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(141, 29);
            this.minTB.TabIndex = 16;
            this.minTB.Text = "60";
            this.minTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(267, 249);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 30);
            this.label13.TabIndex = 17;
            this.label13.Text = "Minutes";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fillB
            // 
            this.fillB.Location = new System.Drawing.Point(9, 278);
            this.fillB.Margin = new System.Windows.Forms.Padding(0);
            this.fillB.Name = "fillB";
            this.fillB.Size = new System.Drawing.Size(117, 30);
            this.fillB.TabIndex = 18;
            this.fillB.Text = "Fill Gas";
            this.fillB.UseVisualStyleBackColor = true;
            this.fillB.Click += new System.EventHandler(this.fillB_Click);
            // 
            // galTB
            // 
            this.galTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galTB.Location = new System.Drawing.Point(126, 278);
            this.galTB.Margin = new System.Windows.Forms.Padding(0);
            this.galTB.Name = "galTB";
            this.galTB.Size = new System.Drawing.Size(141, 29);
            this.galTB.TabIndex = 19;
            this.galTB.Text = "60";
            this.galTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(267, 278);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "Gallons";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newCar
            // 
            this.newCar.Location = new System.Drawing.Point(9, 354);
            this.newCar.Margin = new System.Windows.Forms.Padding(0);
            this.newCar.Name = "newCar";
            this.newCar.Size = new System.Drawing.Size(400, 30);
            this.newCar.TabIndex = 21;
            this.newCar.Text = "New Car";
            this.newCar.UseVisualStyleBackColor = true;
            this.newCar.Click += new System.EventHandler(this.newCar_Click);
            // 
            // setSpeed
            // 
            this.setSpeed.Location = new System.Drawing.Point(9, 307);
            this.setSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.setSpeed.Name = "setSpeed";
            this.setSpeed.Size = new System.Drawing.Size(117, 30);
            this.setSpeed.TabIndex = 22;
            this.setSpeed.Text = "Set Speed";
            this.setSpeed.UseVisualStyleBackColor = true;
            this.setSpeed.Click += new System.EventHandler(this.setSpeed_Click);
            // 
            // speedTB
            // 
            this.speedTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedTB.Location = new System.Drawing.Point(126, 307);
            this.speedTB.Margin = new System.Windows.Forms.Padding(0);
            this.speedTB.Name = "speedTB";
            this.speedTB.Size = new System.Drawing.Size(141, 29);
            this.speedTB.TabIndex = 23;
            this.speedTB.Text = "60";
            this.speedTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "MPH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedTB);
            this.Controls.Add(this.setSpeed);
            this.Controls.Add(this.newCar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.galTB);
            this.Controls.Add(this.fillB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.minTB);
            this.Controls.Add(this.driveB);
            this.Controls.Add(this.miles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mpg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label carName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mpg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label miles;
        private System.Windows.Forms.Button driveB;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button fillB;
        private System.Windows.Forms.TextBox galTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button newCar;
        private System.Windows.Forms.Button setSpeed;
        private System.Windows.Forms.TextBox speedTB;
        private System.Windows.Forms.Label label2;
    }
}

