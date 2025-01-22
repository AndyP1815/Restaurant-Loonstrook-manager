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
using buisness_logic_layer;
using buisness_logic_layer.Services;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loonstrook
{
	public partial class Pdf : Form
	{
		public Pdf()
		{
			InitializeComponent();
			string dateString = DateTime.Now.AddMonths(-1).ToString("MMMM yyyy");

			MapNameTextBox.Text = $"Loonstrook {dateString}";
			FileNameTextBox.Text = $"Loonstrook {dateString}";
		}

		private void Pdf_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				// Configure the OpenFileDialog
				openFileDialog.Title = "Select File";
				openFileDialog.InitialDirectory = @"C:\";
				openFileDialog.Filter = "All files (*.*)|*.*|PDF Files (*.pdf)|*.pdf";
				openFileDialog.FilterIndex = 2;

				// Show the dialog and check if the user selected a file
				if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
				{
					PdfDirectory.Text = openFileDialog.FileName; // Display selected file path
				}
				else
				{
					PdfDirectory.Text = "You didn't select a file!"; // Display a message if no file was selected
				}
			}
		}



		private void convertButton_Click(object sender, EventArgs e)
		{
			if (PdfDirectory.Text == string.Empty ^ MapNameTextBox.Text == string.Empty ^ FileNameTextBox.Text == null)
			{
				MessageBox.Show("Je mist iets vul het nog in");
			}
			else
			{
				try
				{

					PdfReader reader = new PdfReader(PdfDirectory.Text);
					PdfService pdfService = new PdfService();


					string MapPath = pdfService.CreateMap(MapNameTextBox.Text, mapLocationTextBox.Text);

					if (MapPath != null)
					{
						string sourceFilePath = PdfDirectory.Text;
						string targetFolderPath = MapPath;

						if (targetFolderPath != null)
						{
							// Ensure the target folder exists
							Directory.CreateDirectory(targetFolderPath);

							int numberOfPages = reader.NumberOfPages;
							for (int i = 1; i <= numberOfPages; i++)
							{
								// Extract text for the current page
								string PdfText = pdfService.ReturnText(PdfDirectory.Text, i);  // Assuming you modify ReturnText to take page number
								string number = pdfService.ReturnNumber(PdfText);
								string name = pdfService.ReturnName(PdfText);

								// Create a unique filename for each page
								string targetFileName = $"{number} {FileNameTextBox.Text} {name} .pdf";
								string targetFilePath = Path.Combine(targetFolderPath, targetFileName);

								using (PdfReader pageReader = new PdfReader(PdfDirectory.Text))
								{
									using (FileStream fs = new FileStream(targetFilePath, FileMode.Create))
									{
										using (PdfStamper stamper = new PdfStamper(pageReader, fs))
										{
											stamper.Reader.SelectPages(i.ToString());
										}
									}
								}


							}
						}
						MessageBox.Show("PDF successfully split into pages.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred: " + ex.Message);
				}
			}
		}




		private void MapNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void FileNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void BestandNaam_Click(object sender, EventArgs e)
		{

		}

		private void MapLocationButton_Click(object sender, EventArgs e)
		{
			using (var folderDialog = new FolderBrowserDialog())
			{
				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					string selectedFolderPath = folderDialog.SelectedPath;
					mapLocationTextBox.Text = selectedFolderPath;
				}
			}
		
		}

	}
}
