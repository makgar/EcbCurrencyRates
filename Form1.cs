using System;
using System.Windows.Forms;
using System.Xml; // allow using Xml

namespace EcbCurrencyRates
{
    public partial class RateForm : Form
    {
        private string baseUrlString = "https://www.bank.lv/vk/ecb.xml"; // base service URL
        private string inputCurCode; // for currency code input value
        private string inputDate; // for date input value
        private string curCode; // for comparisson of currency codes in the xml
        private string outputRate; // for currency rate output

        // Set the reader settings
        private XmlReaderSettings SetXmlReaderSettings()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;

            return settings;
        }

        public RateForm()
        {
            InitializeComponent();
        }

        private void RateForm_Load(object sender, EventArgs e)
        {
            dtpDate.MaxDate = DateTime.Now.Date; // do not allow dates greater than today
            inputDate = dtpDate.Value.Date.ToString("yyyyMMdd"); // read initial value from the date/time picker
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            inputDate = dtpDate.Value.Date.ToString("yyyyMMdd"); // read value from the date/time picker on change
        }

        // only allow letters, backspace and ctrl when typing in the "Currency code" field
        private void tbCurCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(e.KeyChar == (char)Keys.Back) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbCurCode_TextChanged(object sender, EventArgs e)
        {
            //inputCurCode = tbCurCode.Text.ToUpper();
            inputCurCode = tbCurCode.Text; // read input value from the "Currency code" form field on change
        }

        private void btnGetRate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputCurCode))
            {
                MessageBox.Show("Please enter a currency code.");
                return;
            }

            tbResult.Text = ""; // remove old value from the "Result" form field
            outputRate = null;
            XmlReaderSettings settings = SetXmlReaderSettings();

            // Create XmlReader object
            string urlString = baseUrlString + "?date=" + inputDate;
            XmlReader reader = XmlReader.Create(urlString, settings);

            using (reader)
            {
                //reader.MoveToContent(); // skipping to actual xml content
                reader.ReadToFollowing("Currency"); // go to first "Currency" xml element
                do
                {
                    XmlReader inner = reader.ReadSubtree(); // create XmlReader object to read current "Currency" xml element
                    inner.ReadToDescendant("ID"); // go to "ID" xml element
                    curCode = inner.ReadElementContentAsString(); // read "ID" value and move the reader past the element end node
                    
                    if (curCode.Equals(inputCurCode, StringComparison.OrdinalIgnoreCase)) // compare ID and currency code input value ignoring case
                    {
                        // in particular case of this task we know that "Rate" xml element comes right after "ID"
                        // otherwise additional checks could have been added
                        outputRate = inner.ReadElementContentAsString(); // read "Rate" value and move the reader past the element end node
                        tbResult.Text = outputRate; // output "Rate" to "Result" field of the form
                        inner.Close(); // close inner reader
                        break; // move out of loop
                    }
                    else
                    {
                        inner.Close(); // close inner reader
                        continue; // continue to next loop iteration
                    }
                } while (reader.ReadToNextSibling("Currency")); // loop while there are "Currency" elements left in the xml
            }
            reader.Close(); // close outer reader

            if (outputRate == null)
            {
                MessageBox.Show("Currency rate for the provided currency code could not be found. Please check, if currency code is correct.");
                return;
            }
        }
    }
}
