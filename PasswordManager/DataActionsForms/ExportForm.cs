using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Office.Interop.Excel;
using PasswordManager.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using PasswordManager.Classes;

namespace PasswordManager.DataActionsForms
{
    public partial class ExportForm : Form
    {
        private int userid;
        public ExportForm(int userid)
        {
            InitializeComponent();
            FormControls formControls = new FormControls(CloseLbl, controlPanel, LogoIcon, TitleLbl);
            this.userid = userid;
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            string[] itemsArray = { "Excel files (*.xlsx)", "PDF (*.pdf)", "TEXT (*.txt)", "WEB PAGE (*.html)" };
            FileTypesComboBox.Items.AddRange(itemsArray);

            using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
            {
                connection.Open();

                // SQL command to retrieve defaults for the current user
                string defaultsQuery = "SELECT default_path, default_filename, default_format FROM defaults WHERE userid = @userid;";

                using (SQLiteCommand defaultsCommand = new SQLiteCommand(defaultsQuery, connection))
                {
                    defaultsCommand.Parameters.AddWithValue("@userid", userid);

                    using (SQLiteDataReader reader = defaultsCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User has defaults, populate controls
                            PathTextBox.Text = Convert.ToString(reader["default_path"]);
                            FileNameTextBox.Text = Convert.ToString(reader["default_filename"]);
                            FileTypesComboBox.SelectedIndex = Convert.ToInt32(reader["default_format"]);
                        }
                        else
                        {
                            // User doesn't have defaults, set default values
                            string defaultFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                            PathTextBox.Text = defaultFolderPath;
                            FileNameTextBox.Text = "records";
                            FileTypesComboBox.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void BrowseIcon_Click(object sender, EventArgs e)
        {
            // Open a folder browser dialog
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Get the default path from the database
                string defaultPath = "";

                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                    {
                        connection.Open();

                        string query = "SELECT default_path FROM defaults WHERE userid = @userid;";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@userid", userid);
                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                defaultPath = result.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine("Error retrieving default path: " + ex.Message);
                }

                // Set the selected path to the default path if it's not empty
                if (!string.IsNullOrEmpty(defaultPath))
                {
                    folderBrowserDialog.SelectedPath = defaultPath;
                }
                else
                {
                    folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                }

                // Show the folder browser dialog
                DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                // If the user selects a folder, update the path in the text box
                if (dialogResult == DialogResult.OK)
                {
                    PathTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            switch (FileTypesComboBox.SelectedItem.ToString())
            {
                case "Excel files (*.xlsx)":
                    ExportToExcel(PathTextBox.Text, FileNameTextBox.Text);
                    break;
                case "PDF (*.pdf)":
                    ExportToPdf(PathTextBox.Text, FileNameTextBox.Text);
                    break;
                case "TEXT (*.txt)":
                    ExportToTxt(PathTextBox.Text, FileNameTextBox.Text);
                    break;
                case "WEB PAGE (*.html)":
                    ExportToHtml(PathTextBox.Text, FileNameTextBox.Text);
                    break;
                // Add cases for other file types if needed
                default:
                    CustomMessageBoxForm.Show("Unsupported file type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportToExcel(string filePath, string fileName)
        {
            try
            {
                // Create a new Excel Application
                var excelApp = new Microsoft.Office.Interop.Excel.Application();

                // Create a new Workbook
                var workbook = excelApp.Workbooks.Add(Type.Missing);

                // Add a new Worksheet to the Workbook
                var worksheet = (Worksheet)workbook.ActiveSheet;

                // Retrieve records for the current user from the database and store them in a list of Record objects
                List<Record> records = new List<Record>();
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT url, username, password, note FROM records WHERE userid = @userid";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userid);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Record record = new Record
                                {
                                    url = Convert.ToString(reader["url"]),
                                    username = Convert.ToString(reader["username"]),
                                    password = Convert.ToString(reader["password"]),
                                    note = Convert.ToString(reader["note"])
                                };
                                records.Add(record);
                            }
                        }
                    }
                }

                // Check if records were retrieved
                if (records.Count > 0)
                {
                    // Set column headers
                    worksheet.Cells[1, 1] = "URL";
                    worksheet.Cells[1, 2] = "Username";
                    worksheet.Cells[1, 3] = "Password";
                    worksheet.Cells[1, 4] = "Note";

                    // Set cell values
                    for (int i = 0; i < records.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1] = records[i].url;
                        worksheet.Cells[i + 2, 2] = records[i].username;
                        worksheet.Cells[i + 2, 3] = records[i].password;
                        worksheet.Cells[i + 2, 4] = records[i].note;
                    }

                    // Save the Workbook with the specified file path and file name
                    workbook.SaveAs(Path.Combine(filePath, fileName + ".xlsx"));
                    CustomMessageBoxForm.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CustomMessageBoxForm.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close the Workbook and Excel Application
                workbook.Close();
                excelApp.Quit();
            }
            catch (Exception ex)
            {
                CustomMessageBoxForm.Show("Error exporting data to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPdf(string filePath, string fileName)
        {
            try
            {
                // Retrieve records for the current user from the database
                List<Record> records = new List<Record>();
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT url, username, password, note FROM records WHERE userid = @userid";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userid);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Record record = new Record
                                {
                                    url = Convert.ToString(reader["url"]),
                                    username = Convert.ToString(reader["username"]),
                                    password = Convert.ToString(reader["password"]),
                                    note = Convert.ToString(reader["note"])
                                };
                                records.Add(record);
                            }
                        }
                    }
                }

                // Check if records were retrieved
                if (records.Count > 0)
                {
                    // Create a new PDF document
                    Document pdfDocument = new Document();
                    PdfWriter.GetInstance(pdfDocument, new FileStream(Path.Combine(filePath, fileName + ".pdf"), FileMode.Create));

                    pdfDocument.Open();

                    // Add a table to the document
                    PdfPTable pdfTable = new PdfPTable(typeof(Record).GetProperties().Length - 2); // Exclude id and userid

                    // Add column headers to the table
                    foreach (var propertyInfo in typeof(Record).GetProperties())
                    {
                        if (propertyInfo.Name != "id" && propertyInfo.Name != "userid") // Exclude id and userid
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(propertyInfo.Name));
                            pdfTable.AddCell(cell);
                        }
                    }

                    // Add data rows to the table
                    foreach (var record in records)
                    {
                        foreach (var propertyInfo in typeof(Record).GetProperties())
                        {
                            if (propertyInfo.Name != "id" && propertyInfo.Name != "userid") // Exclude id and userid
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(propertyInfo.GetValue(record)?.ToString() ?? ""));
                                pdfTable.AddCell(cell);
                            }
                        }
                    }

                    // Add the table to the document
                    pdfDocument.Add(pdfTable);

                    // Close the document
                    pdfDocument.Close();

                    CustomMessageBoxForm.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CustomMessageBoxForm.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBoxForm.Show("Error exporting data to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToTxt(string filePath, string fileName)
        {
            try
            {
                // Retrieve records for the current user from the database
                List<Record> records = new List<Record>();
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT url, username, password, note FROM records WHERE userid = @userid";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userid);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Record record = new Record
                                {
                                    url = Convert.ToString(reader["url"]),
                                    username = Convert.ToString(reader["username"]),
                                    password = Convert.ToString(reader["password"]),
                                    note = Convert.ToString(reader["note"])
                                };
                                records.Add(record);
                            }
                        }
                    }
                }

                // Check if records were retrieved
                if (records.Count > 0)
                {
                    // Combine the file path and file name
                    string fullFilePath = Path.Combine(filePath, fileName + ".txt");

                    // Create a StringBuilder to store the text content
                    StringBuilder sb = new StringBuilder();

                    // Append column headers to the StringBuilder
                    foreach (var propertyInfo in typeof(Record).GetProperties())
                    {
                        if (propertyInfo.Name != "id" && propertyInfo.Name != "userid") // Exclude id and userid
                        {
                            sb.Append(propertyInfo.Name);
                            sb.Append("\t"); // Add tab delimiter between columns
                        }
                    }
                    sb.AppendLine(); // Add new line after headers

                    // Append cell values to the StringBuilder
                    foreach (var record in records)
                    {
                        foreach (var propertyInfo in typeof(Record).GetProperties())
                        {
                            if (propertyInfo.Name != "id" && propertyInfo.Name != "userid") // Exclude id and userid
                            {
                                sb.Append(propertyInfo.GetValue(record)?.ToString() ?? "");
                                sb.Append("\t"); // Add tab delimiter between columns
                            }
                        }
                        sb.AppendLine(); // Add new line after each row
                    }

                    // Write the content to the text file
                    File.WriteAllText(fullFilePath, sb.ToString());

                    CustomMessageBoxForm.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CustomMessageBoxForm.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBoxForm.Show("Error exporting data to text file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToHtml(string filePath, string fileName)
        {
            try
            {
                // Retrieve records for the current user from the database
                List<Record> records = new List<Record>();
                using (SQLiteConnection connection = new SQLiteConnection(Program.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT url, username, password, note FROM records WHERE userid = @userid";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userid);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Record record = new Record
                                {
                                    url = Convert.ToString(reader["url"]),
                                    username = Convert.ToString(reader["username"]),
                                    password = Convert.ToString(reader["password"]),
                                    note = Convert.ToString(reader["note"])
                                };
                                records.Add(record);
                            }
                        }
                    }
                }

                // Check if records were retrieved
                if (records.Count > 0)
                {
                    // Combine the file path and file name
                    string fullFilePath = Path.Combine(filePath, fileName + ".html");

                    // Create a StringBuilder to store the HTML content
                    StringBuilder sb = new StringBuilder();

                    // Append HTML headers to the StringBuilder
                    sb.AppendLine("<!DOCTYPE html>");
                    sb.AppendLine("<html>");
                    sb.AppendLine("<head>");
                    sb.AppendLine("<title>" + fileName + "</title>");
                    sb.AppendLine("</head>");
                    sb.AppendLine("<body>");
                    sb.AppendLine("<table border='1'>");

                    // Append column headers as HTML table headers
                    sb.AppendLine("<tr>");
                    foreach (var propertyInfo in typeof(Record).GetProperties())
                    {
                        if (propertyInfo.Name != "id" && propertyInfo.Name != "userid") // Exclude id and userid from being exported
                        {
                            sb.AppendLine("<th>" + propertyInfo.Name + "</th>");
                        }
                    }
                    sb.AppendLine("</tr>");

                    // Append cell values as HTML table rows
                    foreach (var record in records)
                    {
                        sb.AppendLine("<tr>");
                        foreach (var propertyInfo in typeof(Record).GetProperties())
                        {
                            if (propertyInfo.Name != "id" && propertyInfo.Name != "userid") // Exclude id and userid from being exported
                            {
                                sb.AppendLine("<td>" + propertyInfo.GetValue(record)?.ToString() ?? "" + "</td>");
                            }
                        }
                        sb.AppendLine("</tr>");
                    }

                    // Close the HTML table and body tags
                    sb.AppendLine("</table>");
                    sb.AppendLine("</body>");
                    sb.AppendLine("</html>");

                    // Write the content to the HTML file
                    File.WriteAllText(fullFilePath, sb.ToString());

                    CustomMessageBoxForm.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CustomMessageBoxForm.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBoxForm.Show("Error exporting data to HTML file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
