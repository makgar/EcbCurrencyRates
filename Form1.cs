using System;
using System.Windows.Forms;
using System.Xml; // allow using Xml

namespace EcbCurrencyRates
{
    public partial class RateForm : Form
    {
        private string inputCurCode;
        private string inputDate;

        public RateForm()
        {
            InitializeComponent();
        }

        private void btnGetRate_Click(object sender, EventArgs e)
        {
            // temporary things
            //string tempCur = "HKD";
            //string tempDate = "20200925";
            //tmpLabel.Text = tempCur;
            tmpLabel.Text = inputCurCode;

            tbResult.Text = ""; //removing any old value

            // Set the reader settings
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;

            // Create XmlReader object
            string urlString = "https://www.bank.lv/vk/ecb.xml" + "?date=" + inputDate;
            XmlReader reader = XmlReader.Create(urlString, settings);

            using (reader)
            {
                reader.MoveToContent();
                reader.ReadToFollowing("Currency");
                do
                {
                    XmlReader inner = reader.ReadSubtree();
                    inner.ReadToDescendant("ID");
                    //tmpLabel2.Text = inner.ReadElementContentAsString();
                    //tmpLabel3.Text = inner.ReadElementContentAsString();
                    string curCode = inner.ReadElementContentAsString();
                    //if (curCode == tempCur)
                    if (curCode == inputCurCode)
                    {
                        if (inner.Name != "Rate")
                        {
                            inner.ReadToDescendant("Rate");
                            tmpLabel2.Text = inner.Name + " if";
                            string outputRate = inner.ReadElementContentAsString();
                            tmpLabel3.Text = outputRate;
                        }
                        else
                        {
                            //tmpLabel2.Text = inner.NodeType.ToString();
                            tmpLabel2.Text = inner.Name + " else";
                            string outputRate = inner.ReadElementContentAsString();
                            tmpLabel3.Text = outputRate;
                            tbResult.Text = outputRate;
                        }
                        inner.Close();
                        break;
                    }
                    else
                    {
                        inner.Close();
                        continue;
                    }
                } while (reader.ReadToNextSibling("Currency"));
            }
            reader.Close();
        }

        private void lblCurCode_Click(object sender, EventArgs e)
        {

        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            inputDate = dtpDate.Value.Date.ToString("yyyyMMdd");
            //MessageBox.Show(inputDate);
        }

        private void RateForm_Load(object sender, EventArgs e)
        {
            inputDate = dtpDate.Value.Date.ToString("yyyyMMdd");
            //MessageBox.Show(inputDate);
        }

        private void tbCurCode_TextChanged(object sender, EventArgs e)
        {
            //string inputCurCode = tbCurCode.Text.ToUpper();
            inputCurCode = tbCurCode.Text.ToUpper();
        }
    }
}
