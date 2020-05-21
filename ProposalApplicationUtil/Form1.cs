using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using DualLab.Pdf2data;
using DualLab.Pdf2data.Template;
using DualLab.Pdf2data.Result;
using iText.License;

namespace ProposalApplicationUtil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog()) {
                openFile.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                var dialogResult = openFile.ShowDialog();

                if (dialogResult==DialogResult.OK) {
                  // var reader = new PdfReader(openFile.FileName);
                    PdfDocument pdfDocument = new PdfDocument(new PdfReader(openFile.FileName),new PdfWriter( "\\myPDF.pdf"));
                    int pages = pdfDocument.GetNumberOfPages();
                  pdfDocument.RemovePage(pdfDocument.GetNumberOfPages());
                    
                    pdfDocument.Close();
                    MessageBox.Show("PDF Modified!!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTempPath.Text.Equals("") || txtPDFPath.Text.Equals("") || txtTrial.Text.Equals("")) {
                string msg = "";
                 msg= msg + (txtTempPath.Text.Equals("")?"Data Template":"") +"\n";
                 msg = msg +(txtPDFPath.Text.Equals("") ? "PDF File" : "") + "\n";
                msg = msg + (txtTrial.Text.Equals("") ? "Itext Key License" : "") + "\n";

                MessageBox.Show("No Selected \n"+msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            // LicenseKey.LoadLicenseFile(@"C:\Users\Arn-Windows\Documents\Visual Studio 2015\Projects\itextkey1590057483769_0.xml");
            LicenseKey.LoadLicenseFile(txtTrial.Text);
            Template template = Pdf2DataExtractor.ParseTemplateFromPDF(txtTempPath.Text);
            
                    Pdf2DataExtractor extractor = new Pdf2DataExtractor(template);
                    ParsingResult result = extractor.Recognize(txtPDFPath.Text);
                    lblLastName.Text = result.GetResults("LastName").FirstOrDefault().ToString();
                    lblApplicationNo.Text= result.GetResults("AppliccationNo").FirstOrDefault().ToString();
                    lblFirstName.Text= result.GetResults("FirstName").FirstOrDefault().ToString();

                   // lblAddress.Text= result.GetResults("Address").FirstOrDefault().ToString();
                    foreach (ResultElement item in result.GetResults("Address")) {
                          lblAddress.Text = lblAddress.Text + item.ToString()+"\n";
                    }
           
                    //MessageBox.Show("Application NO.= "+ result.GetResults("AppliccationNo").FirstOrDefault());

                    MessageBox.Show("Data has been Loaded!","Sucess");
           
        }

        private void btnSelectTemp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                var dialogResult = openFile.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    txtTempPath.Text = openFile.FileName;
                }
            }
        }

        private void btnSelectPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                var dialogResult = openFile.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    txtPDFPath.Text = openFile.FileName;
                }
            }
        }

        private void txtPDFPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                var dialogResult = openFile.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    // var reader = new PdfReader(openFile.FileName);
                    PdfDocument pdfDocument = new PdfDocument(new PdfReader(openFile.FileName));
                    int pages = pdfDocument.GetNumberOfPages();
                    numUpDown.Maximum = pages;
                    lblTotalPages.Text = pages.ToString();
                    txtFilePath.Text = openFile.FileName;
                  //  pdfDocument.RemovePage(pdfDocument.GetNumberOfPages());

                    pdfDocument.Close();
                    MessageBox.Show("PDF Loaded!!!");
                }
            }
        }

        private void btnUpdatePDF_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Equals("") || txtOutPut.Text.Equals("")) {
                MessageBox.Show("No Selected PDF File!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }


            PdfDocument pdfDocument = new PdfDocument(new PdfReader(txtFilePath.Text), new PdfWriter(txtOutPut.Text));
            int pages = pdfDocument.GetNumberOfPages();
            numUpDown.Maximum = pages;
            lblTotalPages.Text = pages.ToString();
           
            pdfDocument.RemovePage((Int32)numUpDown.Value);

            pdfDocument.Close();
            MessageBox.Show("PDF Was Updated!!!");
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFile= new SaveFileDialog()){
                saveFile.Filter= "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                var dialogResult = saveFile.ShowDialog();


                if (dialogResult == DialogResult.OK) {
                    txtOutPut.Text = saveFile.FileName;
                }


            }
        }

        private void btnSelectLicense_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Please select the License provided by Itext";
                openFile.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                var dialogResult = openFile.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    txtTrial.Text = openFile.FileName;
                }
            }
        }
    }
}
