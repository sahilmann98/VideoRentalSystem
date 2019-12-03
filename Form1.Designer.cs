namespace VideoRentalSystem
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.movieGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rentalGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cID = new System.Windows.Forms.TextBox();
            this.cfname = new System.Windows.Forms.TextBox();
            this.clname = new System.Windows.Forms.TextBox();
            this.caddress = new System.Windows.Forms.TextBox();
            this.cphone = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mID = new System.Windows.Forms.TextBox();
            this.mrating = new System.Windows.Forms.TextBox();
            this.mtitle = new System.Windows.Forms.TextBox();
            this.myear = new System.Windows.Forms.TextBox();
            this.mcopies = new System.Windows.Forms.TextBox();
            this.mgenre = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rentcID = new System.Windows.Forms.TextBox();
            this.rentmID = new System.Windows.Forms.TextBox();
            this.rentDate = new System.Windows.Forms.DateTimePicker();
            this.btnRent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.returnID = new System.Windows.Forms.TextBox();
            this.mcost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.rentID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMostMovie = new System.Windows.Forms.Button();
            this.btnMostCustomer = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(889, 243);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customerDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(872, 293);
            this.customerDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.movieGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // movieGridView
            // 
            this.movieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieGridView.Location = new System.Drawing.Point(0, 0);
            this.movieGridView.Name = "movieGridView";
            this.movieGridView.RowHeadersWidth = 51;
            this.movieGridView.RowTemplate.Height = 24;
            this.movieGridView.Size = new System.Drawing.Size(878, 211);
            this.movieGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rentalGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(881, 214);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rentalGridView
            // 
            this.rentalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalGridView.Location = new System.Drawing.Point(3, 0);
            this.rentalGridView.Name = "rentalGridView";
            this.rentalGridView.RowHeadersWidth = 51;
            this.rentalGridView.RowTemplate.Height = 24;
            this.rentalGridView.Size = new System.Drawing.Size(872, 211);
            this.rentalGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMER";
            // 
            // cID
            // 
            this.cID.Location = new System.Drawing.Point(16, 318);
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(54, 22);
            this.cID.TabIndex = 2;
            // 
            // cfname
            // 
            this.cfname.Location = new System.Drawing.Point(76, 318);
            this.cfname.Name = "cfname";
            this.cfname.Size = new System.Drawing.Size(110, 22);
            this.cfname.TabIndex = 3;
            // 
            // clname
            // 
            this.clname.Location = new System.Drawing.Point(192, 318);
            this.clname.Name = "clname";
            this.clname.Size = new System.Drawing.Size(123, 22);
            this.clname.TabIndex = 4;
            // 
            // caddress
            // 
            this.caddress.Location = new System.Drawing.Point(321, 318);
            this.caddress.Name = "caddress";
            this.caddress.Size = new System.Drawing.Size(189, 22);
            this.caddress.TabIndex = 5;
            // 
            // cphone
            // 
            this.cphone.Location = new System.Drawing.Point(517, 318);
            this.cphone.Name = "cphone";
            this.cphone.Size = new System.Drawing.Size(125, 22);
            this.cphone.TabIndex = 6;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(648, 318);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(723, 318);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateCustomer.TabIndex = 8;
            this.btnUpdateCustomer.Text = "UPDATE";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(810, 318);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "DELETE";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "MOVIE";
            // 
            // mID
            // 
            this.mID.Location = new System.Drawing.Point(16, 403);
            this.mID.Name = "mID";
            this.mID.Size = new System.Drawing.Size(54, 22);
            this.mID.TabIndex = 11;
            // 
            // mrating
            // 
            this.mrating.Location = new System.Drawing.Point(76, 403);
            this.mrating.Name = "mrating";
            this.mrating.Size = new System.Drawing.Size(41, 22);
            this.mrating.TabIndex = 12;
            // 
            // mtitle
            // 
            this.mtitle.Location = new System.Drawing.Point(123, 401);
            this.mtitle.Name = "mtitle";
            this.mtitle.Size = new System.Drawing.Size(146, 22);
            this.mtitle.TabIndex = 13;
            // 
            // myear
            // 
            this.myear.Location = new System.Drawing.Point(275, 401);
            this.myear.Name = "myear";
            this.myear.Size = new System.Drawing.Size(94, 22);
            this.myear.TabIndex = 14;
            // 
            // mcopies
            // 
            this.mcopies.Location = new System.Drawing.Point(464, 401);
            this.mcopies.Name = "mcopies";
            this.mcopies.Size = new System.Drawing.Size(75, 22);
            this.mcopies.TabIndex = 15;
            // 
            // mgenre
            // 
            this.mgenre.Location = new System.Drawing.Point(545, 401);
            this.mgenre.Name = "mgenre";
            this.mgenre.Size = new System.Drawing.Size(97, 22);
            this.mgenre.TabIndex = 16;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(648, 401);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 18;
            this.btnAddMovie.Text = "ADD";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(723, 401);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateMovie.TabIndex = 19;
            this.btnUpdateMovie.Text = "UPDATE";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteMovie.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteMovie.Location = new System.Drawing.Point(810, 401);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteMovie.TabIndex = 20;
            this.btnDeleteMovie.Text = "DELETE";
            this.btnDeleteMovie.UseVisualStyleBackColor = false;
            this.btnDeleteMovie.Click += new System.EventHandler(this.BtnDeleteMovie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "RENT A NEW MOVIE";
            // 
            // rentcID
            // 
            this.rentcID.Location = new System.Drawing.Point(112, 493);
            this.rentcID.Name = "rentcID";
            this.rentcID.Size = new System.Drawing.Size(48, 22);
            this.rentcID.TabIndex = 22;
            // 
            // rentmID
            // 
            this.rentmID.Location = new System.Drawing.Point(58, 493);
            this.rentmID.Name = "rentmID";
            this.rentmID.Size = new System.Drawing.Size(47, 22);
            this.rentmID.TabIndex = 23;
            // 
            // rentDate
            // 
            this.rentDate.Location = new System.Drawing.Point(165, 493);
            this.rentDate.Name = "rentDate";
            this.rentDate.Size = new System.Drawing.Size(99, 22);
            this.rentDate.TabIndex = 26;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(270, 493);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(99, 23);
            this.btnRent.TabIndex = 27;
            this.btnRent.Text = "RENT";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(735, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "RETURN A MOVIE";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(802, 495);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 23);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(661, 495);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(134, 22);
            this.returnDate.TabIndex = 31;
            // 
            // returnID
            // 
            this.returnID.Location = new System.Drawing.Point(607, 495);
            this.returnID.Name = "returnID";
            this.returnID.Size = new System.Drawing.Size(48, 22);
            this.returnID.TabIndex = 29;
            // 
            // mcost
            // 
            this.mcost.Location = new System.Drawing.Point(375, 401);
            this.mcost.Name = "mcost";
            this.mcost.Size = new System.Drawing.Size(83, 22);
            this.mcost.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Rating";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Title";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 381);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Year";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(475, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 44;
            this.label15.Text = "Copies";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(572, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "Genre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(120, 473);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 17);
            this.label18.TabIndex = 47;
            this.label18.Text = "C. ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(65, 474);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 17);
            this.label19.TabIndex = 48;
            this.label19.Text = "M. ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(174, 475);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 17);
            this.label20.TabIndex = 49;
            this.label20.Text = "Rent Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(402, 381);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 17);
            this.label21.TabIndex = 50;
            this.label21.Text = "Cost";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(685, 474);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 17);
            this.label23.TabIndex = 53;
            this.label23.Text = "Return Date";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(617, 473);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 17);
            this.label25.TabIndex = 51;
            this.label25.Text = "ID";
            // 
            // rentID
            // 
            this.rentID.Location = new System.Drawing.Point(2, 493);
            this.rentID.Name = "rentID";
            this.rentID.Size = new System.Drawing.Size(50, 22);
            this.rentID.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "ID";
            // 
            // btnMostMovie
            // 
            this.btnMostMovie.Location = new System.Drawing.Point(739, 257);
            this.btnMostMovie.Name = "btnMostMovie";
            this.btnMostMovie.Size = new System.Drawing.Size(158, 23);
            this.btnMostMovie.TabIndex = 56;
            this.btnMostMovie.Text = "Most Rented Movie";
            this.btnMostMovie.UseVisualStyleBackColor = true;
            this.btnMostMovie.Click += new System.EventHandler(this.BtnMostMovie_Click);
            // 
            // btnMostCustomer
            // 
            this.btnMostCustomer.Location = new System.Drawing.Point(553, 257);
            this.btnMostCustomer.Name = "btnMostCustomer";
            this.btnMostCustomer.Size = new System.Drawing.Size(180, 23);
            this.btnMostCustomer.TabIndex = 57;
            this.btnMostCustomer.Text = "Most Renting Customer";
            this.btnMostCustomer.UseVisualStyleBackColor = true;
            this.btnMostCustomer.Click += new System.EventHandler(this.BtnMostCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 530);
            this.Controls.Add(this.btnMostCustomer);
            this.Controls.Add(this.btnMostMovie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rentID);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mcost);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.returnID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.rentDate);
            this.Controls.Add(this.rentmID);
            this.Controls.Add(this.rentcID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.mgenre);
            this.Controls.Add(this.mcopies);
            this.Controls.Add(this.myear);
            this.Controls.Add(this.mtitle);
            this.Controls.Add(this.mrating);
            this.Controls.Add(this.mID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cphone);
            this.Controls.Add(this.caddress);
            this.Controls.Add(this.clname);
            this.Controls.Add(this.cfname);
            this.Controls.Add(this.cID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Video Rental System";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movieGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cID;
        private System.Windows.Forms.TextBox cfname;
        private System.Windows.Forms.TextBox clname;
        private System.Windows.Forms.TextBox caddress;
        private System.Windows.Forms.TextBox cphone;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mID;
        private System.Windows.Forms.TextBox mrating;
        private System.Windows.Forms.TextBox mtitle;
        private System.Windows.Forms.TextBox myear;
        private System.Windows.Forms.TextBox mcopies;
        private System.Windows.Forms.TextBox mgenre;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rentcID;
        private System.Windows.Forms.TextBox rentmID;
        private System.Windows.Forms.DateTimePicker rentDate;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.TextBox returnID;
        private System.Windows.Forms.TextBox mcost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView movieGridView;
        private System.Windows.Forms.DataGridView rentalGridView;
        private System.Windows.Forms.TextBox rentID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMostMovie;
        private System.Windows.Forms.Button btnMostCustomer;
    }
}

