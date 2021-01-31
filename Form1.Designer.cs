
namespace Weather_API_Application
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
            this.Label_City = new System.Windows.Forms.Label();
            this.Label_Country = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.Label_Conditions = new System.Windows.Forms.Label();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Label_Wind_Speed = new System.Windows.Forms.Label();
            this.Label_Temp_Min = new System.Windows.Forms.Label();
            this.Label_Forecast = new System.Windows.Forms.Label();
            this.Label_City_Coordinates = new System.Windows.Forms.Label();
            this.Label_Temp_Max = new System.Windows.Forms.Label();
            this.Label_Feels_Like = new System.Windows.Forms.Label();
            this.Label_Temperatures = new System.Windows.Forms.Label();
            this.Label_Weather_Details = new System.Windows.Forms.Label();
            this.Label_Details = new System.Windows.Forms.Label();
            this.Label_Day = new System.Windows.Forms.Label();
            this.Label_Pressure = new System.Windows.Forms.Label();
            this.Form_Button = new System.Windows.Forms.Button();
            this.Form_Search = new System.Windows.Forms.TextBox();
            this.Label_Sunset = new System.Windows.Forms.Label();
            this.Label_Sunrise = new System.Windows.Forms.Label();
            this.Label_Humidity = new System.Windows.Forms.Label();
            this.Label_Degrees = new System.Windows.Forms.Label();
            this.Picture_City = new System.Windows.Forms.PictureBox();
            this.City_Name = new System.Windows.Forms.Label();
            this.Label_Sunrise_Time = new System.Windows.Forms.Label();
            this.Label_Sunset_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Picture_Map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_City)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_City
            // 
            this.Label_City.AutoSize = true;
            this.Label_City.BackColor = System.Drawing.Color.Transparent;
            this.Label_City.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_City.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_City.ForeColor = System.Drawing.Color.Snow;
            this.Label_City.Location = new System.Drawing.Point(9, 13);
            this.Label_City.Name = "Label_City";
            this.Label_City.Size = new System.Drawing.Size(155, 46);
            this.Label_City.TabIndex = 0;
            this.Label_City.Text = "Auburn";
            // 
            // Label_Country
            // 
            this.Label_Country.AutoSize = true;
            this.Label_Country.BackColor = System.Drawing.Color.Transparent;
            this.Label_Country.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Country.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Country.Location = new System.Drawing.Point(11, 60);
            this.Label_Country.Name = "Label_Country";
            this.Label_Country.Size = new System.Drawing.Size(56, 39);
            this.Label_Country.TabIndex = 1;
            this.Label_Country.Text = "US";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.BackColor = System.Drawing.Color.Transparent;
            this.Temperature.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature.ForeColor = System.Drawing.SystemColors.Info;
            this.Temperature.Location = new System.Drawing.Point(196, 173);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(47, 51);
            this.Temperature.TabIndex = 3;
            this.Temperature.Text = "C";
            // 
            // Label_Conditions
            // 
            this.Label_Conditions.AutoSize = true;
            this.Label_Conditions.BackColor = System.Drawing.Color.Transparent;
            this.Label_Conditions.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Conditions.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Conditions.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Conditions.Location = new System.Drawing.Point(365, 168);
            this.Label_Conditions.Name = "Label_Conditions";
            this.Label_Conditions.Size = new System.Drawing.Size(187, 39);
            this.Label_Conditions.TabIndex = 7;
            this.Label_Conditions.Text = "Conditions";
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.BackColor = System.Drawing.Color.Transparent;
            this.Label_Description.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Description.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Description.Location = new System.Drawing.Point(365, 207);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(200, 39);
            this.Label_Description.TabIndex = 8;
            this.Label_Description.Text = "Description";
            this.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Wind_Speed
            // 
            this.Label_Wind_Speed.AutoSize = true;
            this.Label_Wind_Speed.BackColor = System.Drawing.Color.Transparent;
            this.Label_Wind_Speed.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Wind_Speed.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Wind_Speed.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Wind_Speed.Location = new System.Drawing.Point(641, 273);
            this.Label_Wind_Speed.Name = "Label_Wind_Speed";
            this.Label_Wind_Speed.Size = new System.Drawing.Size(131, 27);
            this.Label_Wind_Speed.TabIndex = 9;
            this.Label_Wind_Speed.Text = "Wind Speed";
            // 
            // Label_Temp_Min
            // 
            this.Label_Temp_Min.AutoSize = true;
            this.Label_Temp_Min.BackColor = System.Drawing.Color.Transparent;
            this.Label_Temp_Min.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Temp_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Temp_Min.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Temp_Min.Location = new System.Drawing.Point(641, 132);
            this.Label_Temp_Min.Name = "Label_Temp_Min";
            this.Label_Temp_Min.Size = new System.Drawing.Size(55, 26);
            this.Label_Temp_Min.TabIndex = 10;
            this.Label_Temp_Min.Text = "Low";
            // 
            // Label_Forecast
            // 
            this.Label_Forecast.AutoSize = true;
            this.Label_Forecast.BackColor = System.Drawing.Color.Transparent;
            this.Label_Forecast.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Forecast.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Forecast.ForeColor = System.Drawing.Color.Snow;
            this.Label_Forecast.Location = new System.Drawing.Point(422, 42);
            this.Label_Forecast.Name = "Label_Forecast";
            this.Label_Forecast.Size = new System.Drawing.Size(426, 59);
            this.Label_Forecast.TabIndex = 11;
            this.Label_Forecast.Text = "Today\'s Forecast";
            // 
            // Label_City_Coordinates
            // 
            this.Label_City_Coordinates.AutoSize = true;
            this.Label_City_Coordinates.BackColor = System.Drawing.Color.Transparent;
            this.Label_City_Coordinates.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_City_Coordinates.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_City_Coordinates.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_City_Coordinates.Location = new System.Drawing.Point(185, 242);
            this.Label_City_Coordinates.Name = "Label_City_Coordinates";
            this.Label_City_Coordinates.Size = new System.Drawing.Size(146, 41);
            this.Label_City_Coordinates.TabIndex = 12;
            this.Label_City_Coordinates.Text = "(lat, lon)";
            // 
            // Label_Temp_Max
            // 
            this.Label_Temp_Max.AutoSize = true;
            this.Label_Temp_Max.BackColor = System.Drawing.Color.Transparent;
            this.Label_Temp_Max.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Temp_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Temp_Max.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Temp_Max.Location = new System.Drawing.Point(738, 132);
            this.Label_Temp_Max.Name = "Label_Temp_Max";
            this.Label_Temp_Max.Size = new System.Drawing.Size(61, 26);
            this.Label_Temp_Max.TabIndex = 13;
            this.Label_Temp_Max.Text = "High";
            // 
            // Label_Feels_Like
            // 
            this.Label_Feels_Like.AutoSize = true;
            this.Label_Feels_Like.BackColor = System.Drawing.Color.Transparent;
            this.Label_Feels_Like.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Feels_Like.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold);
            this.Label_Feels_Like.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Feels_Like.Location = new System.Drawing.Point(641, 190);
            this.Label_Feels_Like.Name = "Label_Feels_Like";
            this.Label_Feels_Like.Size = new System.Drawing.Size(111, 29);
            this.Label_Feels_Like.TabIndex = 15;
            this.Label_Feels_Like.Text = "Feels Like";
            // 
            // Label_Temperatures
            // 
            this.Label_Temperatures.AutoSize = true;
            this.Label_Temperatures.BackColor = System.Drawing.Color.Transparent;
            this.Label_Temperatures.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Temperatures.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Temperatures.ForeColor = System.Drawing.Color.Snow;
            this.Label_Temperatures.Location = new System.Drawing.Point(639, 95);
            this.Label_Temperatures.Name = "Label_Temperatures";
            this.Label_Temperatures.Size = new System.Drawing.Size(209, 37);
            this.Label_Temperatures.TabIndex = 16;
            this.Label_Temperatures.Text = "Temperatures";
            // 
            // Label_Weather_Details
            // 
            this.Label_Weather_Details.AutoSize = true;
            this.Label_Weather_Details.BackColor = System.Drawing.Color.Transparent;
            this.Label_Weather_Details.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Weather_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Weather_Details.ForeColor = System.Drawing.Color.Snow;
            this.Label_Weather_Details.Location = new System.Drawing.Point(27, 283);
            this.Label_Weather_Details.Name = "Label_Weather_Details";
            this.Label_Weather_Details.Size = new System.Drawing.Size(280, 51);
            this.Label_Weather_Details.TabIndex = 17;
            this.Label_Weather_Details.Text = "Weather Map";
            // 
            // Label_Details
            // 
            this.Label_Details.AutoSize = true;
            this.Label_Details.BackColor = System.Drawing.Color.Transparent;
            this.Label_Details.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Details.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Details.ForeColor = System.Drawing.Color.Snow;
            this.Label_Details.Location = new System.Drawing.Point(640, 159);
            this.Label_Details.Name = "Label_Details";
            this.Label_Details.Size = new System.Drawing.Size(221, 34);
            this.Label_Details.TabIndex = 20;
            this.Label_Details.Text = "Weather Details";
            // 
            // Label_Day
            // 
            this.Label_Day.AutoSize = true;
            this.Label_Day.BackColor = System.Drawing.Color.Transparent;
            this.Label_Day.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Day.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Day.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Day.Location = new System.Drawing.Point(199, 111);
            this.Label_Day.Name = "Label_Day";
            this.Label_Day.Size = new System.Drawing.Size(65, 34);
            this.Label_Day.TabIndex = 21;
            this.Label_Day.Text = "Day";
            // 
            // Label_Pressure
            // 
            this.Label_Pressure.AutoSize = true;
            this.Label_Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Label_Pressure.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Pressure.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pressure.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Pressure.Location = new System.Drawing.Point(641, 219);
            this.Label_Pressure.Name = "Label_Pressure";
            this.Label_Pressure.Size = new System.Drawing.Size(94, 27);
            this.Label_Pressure.TabIndex = 22;
            this.Label_Pressure.Text = "Pressure";
            // 
            // Form_Button
            // 
            this.Form_Button.BackColor = System.Drawing.Color.Snow;
            this.Form_Button.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Form_Button.Location = new System.Drawing.Point(768, 13);
            this.Form_Button.MinimumSize = new System.Drawing.Size(0, 30);
            this.Form_Button.Name = "Form_Button";
            this.Form_Button.Size = new System.Drawing.Size(100, 30);
            this.Form_Button.TabIndex = 24;
            this.Form_Button.Text = "Search";
            this.Form_Button.UseVisualStyleBackColor = false;
            this.Form_Button.Click += new System.EventHandler(this.Form_Button_Click);
            // 
            // Form_Search
            // 
            this.Form_Search.BackColor = System.Drawing.SystemColors.Window;
            this.Form_Search.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Search.ForeColor = System.Drawing.Color.Maroon;
            this.Form_Search.Location = new System.Drawing.Point(597, 12);
            this.Form_Search.MinimumSize = new System.Drawing.Size(4, 30);
            this.Form_Search.Name = "Form_Search";
            this.Form_Search.Size = new System.Drawing.Size(165, 30);
            this.Form_Search.TabIndex = 25;
            this.Form_Search.Text = "City or State";
            this.Form_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Form_Search.Enter += new System.EventHandler(this.Form_Search_Enter);
            // 
            // Label_Sunset
            // 
            this.Label_Sunset.AutoSize = true;
            this.Label_Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Label_Sunset.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Sunset.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sunset.ForeColor = System.Drawing.Color.Snow;
            this.Label_Sunset.Location = new System.Drawing.Point(470, 254);
            this.Label_Sunset.Name = "Label_Sunset";
            this.Label_Sunset.Size = new System.Drawing.Size(78, 27);
            this.Label_Sunset.TabIndex = 26;
            this.Label_Sunset.Text = "Sunset";
            // 
            // Label_Sunrise
            // 
            this.Label_Sunrise.AutoSize = true;
            this.Label_Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Label_Sunrise.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Sunrise.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sunrise.ForeColor = System.Drawing.Color.Snow;
            this.Label_Sunrise.Location = new System.Drawing.Point(351, 254);
            this.Label_Sunrise.Name = "Label_Sunrise";
            this.Label_Sunrise.Size = new System.Drawing.Size(84, 27);
            this.Label_Sunrise.TabIndex = 27;
            this.Label_Sunrise.Text = "Sunrise";
            // 
            // Label_Humidity
            // 
            this.Label_Humidity.AutoSize = true;
            this.Label_Humidity.BackColor = System.Drawing.Color.Transparent;
            this.Label_Humidity.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Humidity.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Humidity.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Humidity.Location = new System.Drawing.Point(641, 246);
            this.Label_Humidity.Name = "Label_Humidity";
            this.Label_Humidity.Size = new System.Drawing.Size(104, 27);
            this.Label_Humidity.TabIndex = 28;
            this.Label_Humidity.Text = "Humidity";
            // 
            // Label_Degrees
            // 
            this.Label_Degrees.AutoSize = true;
            this.Label_Degrees.BackColor = System.Drawing.Color.Transparent;
            this.Label_Degrees.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Degrees.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Degrees.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Degrees.Location = new System.Drawing.Point(641, 300);
            this.Label_Degrees.Name = "Label_Degrees";
            this.Label_Degrees.Size = new System.Drawing.Size(90, 27);
            this.Label_Degrees.TabIndex = 29;
            this.Label_Degrees.Text = "Degrees";
            // 
            // Picture_City
            // 
            this.Picture_City.Location = new System.Drawing.Point(13, 113);
            this.Picture_City.Name = "Picture_City";
            this.Picture_City.Size = new System.Drawing.Size(175, 160);
            this.Picture_City.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_City.TabIndex = 30;
            this.Picture_City.TabStop = false;
            // 
            // City_Name
            // 
            this.City_Name.AutoSize = true;
            this.City_Name.BackColor = System.Drawing.Color.Transparent;
            this.City_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.City_Name.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Name.ForeColor = System.Drawing.Color.Snow;
            this.City_Name.Location = new System.Drawing.Point(452, 13);
            this.City_Name.Name = "City_Name";
            this.City_Name.Size = new System.Drawing.Size(148, 29);
            this.City_Name.TabIndex = 32;
            this.City_Name.Text = "City Name:";
            // 
            // Label_Sunrise_Time
            // 
            this.Label_Sunrise_Time.AutoSize = true;
            this.Label_Sunrise_Time.BackColor = System.Drawing.Color.Transparent;
            this.Label_Sunrise_Time.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Sunrise_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sunrise_Time.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Sunrise_Time.Location = new System.Drawing.Point(351, 283);
            this.Label_Sunrise_Time.Name = "Label_Sunrise_Time";
            this.Label_Sunrise_Time.Size = new System.Drawing.Size(64, 26);
            this.Label_Sunrise_Time.TabIndex = 33;
            this.Label_Sunrise_Time.Text = "Time";
            // 
            // Label_Sunset_Time
            // 
            this.Label_Sunset_Time.AutoSize = true;
            this.Label_Sunset_Time.BackColor = System.Drawing.Color.Transparent;
            this.Label_Sunset_Time.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_Sunset_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sunset_Time.ForeColor = System.Drawing.SystemColors.Info;
            this.Label_Sunset_Time.Location = new System.Drawing.Point(470, 283);
            this.Label_Sunset_Time.Name = "Label_Sunset_Time";
            this.Label_Sunset_Time.Size = new System.Drawing.Size(64, 26);
            this.Label_Sunset_Time.TabIndex = 34;
            this.Label_Sunset_Time.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(257, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "Longitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(202, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 36;
            this.label2.Text = "Latitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(213, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 37;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(368, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Conditional Weather";
            // 
            // Picture_Map
            // 
            this.Picture_Map.Location = new System.Drawing.Point(8, 328);
            this.Picture_Map.Name = "Picture_Map";
            this.Picture_Map.Size = new System.Drawing.Size(888, 225);
            this.Picture_Map.TabIndex = 39;
            this.Picture_Map.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.Picture_Map);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Sunset_Time);
            this.Controls.Add(this.Label_Sunrise_Time);
            this.Controls.Add(this.Form_Search);
            this.Controls.Add(this.City_Name);
            this.Controls.Add(this.Picture_City);
            this.Controls.Add(this.Label_Degrees);
            this.Controls.Add(this.Label_Humidity);
            this.Controls.Add(this.Label_Sunrise);
            this.Controls.Add(this.Label_Sunset);
            this.Controls.Add(this.Form_Button);
            this.Controls.Add(this.Label_Pressure);
            this.Controls.Add(this.Label_Day);
            this.Controls.Add(this.Label_Details);
            this.Controls.Add(this.Label_Weather_Details);
            this.Controls.Add(this.Label_Temperatures);
            this.Controls.Add(this.Label_Feels_Like);
            this.Controls.Add(this.Label_Temp_Max);
            this.Controls.Add(this.Label_City_Coordinates);
            this.Controls.Add(this.Label_Forecast);
            this.Controls.Add(this.Label_Temp_Min);
            this.Controls.Add(this.Label_Wind_Speed);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.Label_Conditions);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.Label_Country);
            this.Controls.Add(this.Label_City);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_City)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_City;
        private System.Windows.Forms.Label Label_Country;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label Label_Conditions;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Label Label_Wind_Speed;
        private System.Windows.Forms.Label Label_Temp_Min;
        private System.Windows.Forms.Label Label_Forecast;
        private System.Windows.Forms.Label Label_City_Coordinates;
        private System.Windows.Forms.Label Label_Temp_Max;
        private System.Windows.Forms.Label Label_Feels_Like;
        private System.Windows.Forms.Label Label_Temperatures;
        private System.Windows.Forms.Label Label_Weather_Details;
        private System.Windows.Forms.Label Label_Details;
        private System.Windows.Forms.Label Label_Day;
        private System.Windows.Forms.Label Label_Pressure;
        private System.Windows.Forms.Button Form_Button;
        private System.Windows.Forms.TextBox Form_Search;
        private System.Windows.Forms.Label Label_Sunset;
        private System.Windows.Forms.Label Label_Sunrise;
        private System.Windows.Forms.Label Label_Humidity;
        private System.Windows.Forms.Label Label_Degrees;
        private System.Windows.Forms.PictureBox Picture_City;
        private System.Windows.Forms.Label City_Name;
        private System.Windows.Forms.Label Label_Sunrise_Time;
        private System.Windows.Forms.Label Label_Sunset_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Picture_Map;
    }
}

