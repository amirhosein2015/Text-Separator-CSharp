using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;


namespace TextSpliter
{
    public partial class Form1 : Form
    {

        private string inputFilePath = "";
        private string outputFolderPath = "";
        private string modifiedText = ""; // متغیری برای نگهداری متن اصلاح‌شده در حافظه


     



        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false; // در شروع برنامه غیرفعال باشد
        }










        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Supported Files (*.docx;*.txt)|*.docx;*.txt";
            openFileDialog.Title = "Select input file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = openFileDialog.FileName;
                txtFilePath.Text = inputFilePath;

                try
                {

                    Cursor.Current = Cursors.WaitCursor;
                    lblWordCount.Text = "Processing...";

                    string fileExtension = Path.GetExtension(inputFilePath).ToLower();
                    string fullText = "";

                    if (fileExtension == ".docx")
                    {
                        // خواندن متن از Word
                        Word.Application wordApp = new Word.Application();
                        Word.Document doc = wordApp.Documents.Open(inputFilePath, ReadOnly: true);
                        fullText = doc.Content.Text;
                        doc.Close(false);
                        wordApp.Quit();
                    }
                    else if (fileExtension == ".txt")
                    {
                        // خواندن متن از فایل متنی
                        fullText = File.ReadAllText(inputFilePath);
                    }

                    // شمارش کلمات
                    int wordCount = fullText.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

                    // نمایش تعداد واژه‌ها در Label
                    lblWordCount.Text = $"{wordCount}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }














        private void Save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderPath = folderDialog.SelectedPath;
                txtOutputPath.Text = outputFolderPath;
            }
        }






        private void Run_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFolderPath))
            {
                MessageBox.Show("Please select the input file and save path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int splitSize = (int)numSplitSize.Value;
            if (splitSize <= 0)
            {
                MessageBox.Show("The division value must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // غیرفعال کردن دکمه‌ها هنگام پردازش
            Open.Enabled = false;
            Save.Enabled = false;
            Run.Enabled = false;
            Relpace.Enabled = false;

            try
            {
                string fullText = "";

                // بررسی فرمت فایل ورودی
                string fileExtension = Path.GetExtension(inputFilePath).ToLower();

                if (fileExtension == ".docx")
                {
                    // خواندن متن از فایل Word
                    Word.Application wordApp = new Word.Application();
                    Word.Document doc = wordApp.Documents.Open(inputFilePath);
                    fullText = doc.Content.Text;
                    doc.Close();
                    wordApp.Quit();
                }
                else if (fileExtension == ".txt")
                {
                    // خواندن متن از فایل TXT
                    fullText = File.ReadAllText(inputFilePath);
                }
                else
                {
                    MessageBox.Show("The input file must be .docx or .txt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // تقسیم متن به کلمات
                string[] words = fullText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int totalWords = words.Length;
                int partCount = (int)Math.Ceiling((double)totalWords / splitSize);

                // مقداردهی اولیه ProgressBar
                progressBar1.Minimum = 0;
                progressBar1.Maximum = partCount;
                progressBar1.Value = 0;
                progressBar1.Step = 1;
                progressBar1.Visible = true;

                for (int i = 0; i < partCount; i++)
                {
                    int start = i * splitSize;
                    int length = Math.Min(splitSize, totalWords - start);
                    string partText = string.Join(" ", words, start, length);

                    // ایجاد فایل جدید Word برای هر پارت
                    Word.Application newWordApp = new Word.Application();
                    Word.Document newDoc = newWordApp.Documents.Add();

                    // قرار دادن متن در سند
                    newDoc.Content.Text = partText;

                    // انتخاب کل متن
                    Word.Range docRange = newDoc.Content;
                    docRange.Select();

                    // تنظیم جهت متن (چپ به راست یا راست به چپ)
                    if (cmbDirection.SelectedItem != null)
                    {
                        if (cmbDirection.SelectedItem.ToString() == "Right to Left")
                            docRange.ParagraphFormat.ReadingOrder = Word.WdReadingOrder.wdReadingOrderRtl;
                        else
                            docRange.ParagraphFormat.ReadingOrder = Word.WdReadingOrder.wdReadingOrderLtr;
                    }

                    // تنظیم چیدمان متن (راست‌چین، چپ‌چین، وسط‌چین، جاستیفای)
                    if (cmbAlignment.SelectedItem != null)
                    {
                        switch (cmbAlignment.SelectedItem.ToString())
                        {
                            case "Left":
                                docRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                                break;
                            case "Right":
                                docRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                                break;
                            case "Center":
                                docRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                                break;
                            case "Justify":
                                docRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                break;
                        }
                    }

                    // ذخیره فایل Word
                    string outputFilePath = Path.Combine(outputFolderPath, $"Part_{i + 1}.docx");
                    newDoc.SaveAs2(outputFilePath);
                    newDoc.Close();
                    newWordApp.Quit();

                    // آپدیت ProgressBar
                    progressBar1.PerformStep();
                }

                MessageBox.Show("The division was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // فعال‌سازی دوباره دکمه‌ها
                Open.Enabled = true;
                Save.Enabled = true;
                Run.Enabled = true;
                Relpace.Enabled = true;

                // مخفی کردن ProgressBar بعد از اتمام کار
                progressBar1.Value = 0;
                progressBar1.Visible = false;
            }
        }






        private void Relpace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFilePath))
            {
                MessageBox.Show("Please select a Word Or Txt file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtFind.Text) || string.IsNullOrEmpty(txtReplace.Text))
            {
                MessageBox.Show("Please enter search and replace text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string fileExtension = Path.GetExtension(inputFilePath).ToLower();
                if (fileExtension != ".docx" && fileExtension != ".txt")
                {
                    MessageBox.Show("Find and Replace is only supported for Word (.docx) and Text (.txt) files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // خواندن متن اصلی
                string fullText = "";
                if (fileExtension == ".docx")
                {
                    Word.Application wordApp = new Word.Application();
                    Word.Document doc = wordApp.Documents.Open(inputFilePath);
                    fullText = doc.Content.Text;
                    doc.Close();
                    wordApp.Quit();
                }
                else if (fileExtension == ".txt")
                {
                    fullText = File.ReadAllText(inputFilePath);
                }

                // انجام جایگزینی متن
                modifiedText = fullText.Replace(txtFind.Text, txtReplace.Text);

                MessageBox.Show("Replacement completed successfully in memory! You can now split the modified text.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error replacing text: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
