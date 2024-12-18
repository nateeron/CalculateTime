using System;
using System.Globalization;

namespace CalculateTime
{
    public partial class Form1 : Form
    {
        int UTC_Bangkok = 7 * 60 * 60;
        public Form1()
        {
            InitializeComponent();
            
        }

        // 1. Convert timestamp to DateTime
        public static DateTime TimestampToDateTime(long timestamp)
        {
            // Assuming timestamp is in seconds
            try
            {
                return DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;
            }
            catch (Exception)
            {

                string ss = "";
                return new DateTime();

            }

        }

        // 2. Convert DateTime to timestamp
        public static long DateTimeToTimestamp(DateTime dateTime)
        {
            // Convert DateTime to Unix timestamp
            return new DateTimeOffset(dateTime).ToUnixTimeSeconds();
        }
      
        // 3. Count days from microseconds
        public static double CountDaysFromMicroseconds(long microseconds)
        {
            // 1 microsecond = 1e-6 seconds
            // 1 day = 86400 seconds
            return microseconds / (1e6 * 86400);
        }

        // 4. Count days from seconds
        public static double CountDaysFromSeconds(long seconds)
        {
            // 1 day = 86400 seconds
            return seconds / 86400.0;
        }
        private void in_timestamp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long timestamp = long.Parse(in_timestamp.Text) ;  // 1625247600; // Example timestamp (Unix time in seconds)
                DateTime dateTime = TimestampToDateTime(timestamp);
                out_timestamp.Text = dateTime.ToString();
            }
        }

        private void in_timestamp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like Backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric characters
            }
        }
        public static DateTime ParseDateTime(string dateTimeString)
        {
            // Define the format of the date string
            string format = "d/M/yyyy H:mm:ss";

            // Try parsing the string to DateTime
            if (DateTime.TryParseExact(dateTimeString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                return dateTime;
            }
            else
            {
                throw new FormatException("Invalid date format.");
            }
        }
        private void in_datetime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try { 

                    string dateString = in_datetime.Text;
                    DateTime dateTime = ParseDateTime(dateString);
                    long timestamp = DateTimeToTimestamp(dateTime);
                    out_datetime.Text = timestamp.ToString();
                    // Use newTimestamp as needed
                   
                }
                catch (Exception ex)
                {
                    // Handle other possible exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        private void in_Microsecond_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long microseconds = long.Parse(in_Microsecond.Text);// 86400000000; // Example microseconds (1 day)
                double daysFromMicroseconds = CountDaysFromMicroseconds(microseconds);
                out_microsecond.Text = daysFromMicroseconds.ToString();
            }
        }

        private void in_Microsecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like Backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric characters
            }
        }

        private void in_Second_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long seconds = long.Parse(in_Second.Text);// 86400; // Example seconds (1 day)
                double daysFromSeconds = CountDaysFromSeconds(seconds);
                out_Second.Text = daysFromSeconds.ToString();
            }
        }

        private void in_Second_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like Backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric characters
            }
        }
        public static double ConvertMinutesToDays(long minutes)
        {
            const double minutesPerDay = 24 * 60; // 1440 minutes in a day
            return minutes / minutesPerDay;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long minutes = long.Parse(in_minutes.Text);// 7001000; // Example seconds (1 day)
                double days = ConvertMinutesToDays(minutes);
                out_minutes.Text = days.ToString();
              
            }
        }

        private void in_timestamp_Full_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                long timestamp = long.Parse(in_timestamp_Full.Text);  // 1625247600; // Example timestamp (Unix time in seconds)
                DateTime dateTime = TimestampToDateTime(timestamp / 1000);
                out_timestamp_Full.Text = dateTime.ToString();
                DateTime dateTime_7 = TimestampToDateTime((timestamp / 1000) + UTC_Bangkok);
                out_timestamp_Full7.Text = dateTime_7.ToString();
            }
        }

        private void in_timestamp_Full_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore non-numeric characters
            }
        }

        private void in_timestamp_Full_TextChanged(object sender, EventArgs e)
        {
            if (CB_in_timestamp_Full.Checked)
            {
                long timestamp = long.Parse(in_timestamp_Full.Text);  // 1625247600; // Example timestamp (Unix time in seconds)
                DateTime dateTime = TimestampToDateTime(timestamp/1000);
                out_timestamp_Full.Text = dateTime.ToString();
                DateTime dateTime_7 = TimestampToDateTime((timestamp / 1000) + UTC_Bangkok);
                out_timestamp_Full7.Text = dateTime_7.ToString();
            }
        }

        private void in_timestamp_TextChanged(object sender, EventArgs e)
        {
            if (CB_in_timestamp.Checked)
            {
                long timestamp = long.Parse(in_timestamp.Text);  // 1625247600; // Example timestamp (Unix time in seconds)
                DateTime dateTime = TimestampToDateTime(timestamp);

                DateTime dateTime_7 = TimestampToDateTime(timestamp+ UTC_Bangkok);
                out_timestamp.Text = dateTime.ToString();
                out_timestamp7.Text = dateTime_7.ToString();

            }
        }
    }
}