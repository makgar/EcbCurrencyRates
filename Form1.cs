using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // allow using Xml

namespace EcbCurrencyRates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetRate_Click(object sender, EventArgs e)
        {
            // temporary things
            String TempCur = "HKD";
            String TempDate = "20200925";
            tmpLabel.Text = TempCur;

            // Set the reader settings
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;

            // Create XmlReader object
            String UrlString = "https://www.bank.lv/vk/ecb.xml" + "?date=" + TempDate;
            XmlReader reader = XmlReader.Create(UrlString, settings);
            
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
                    if (inner.ReadElementContentAsString() == TempCur)
                    {
                        if (inner.Name != "Rate")
                        {
                            inner.ReadToDescendant("Rate");
                            tmpLabel2.Text = inner.Name + " if";
                            tmpLabel3.Text = inner.ReadElementContentAsString();
                        }
                        else
                        {
                            //tmpLabel2.Text = inner.NodeType.ToString();
                            tmpLabel2.Text = inner.Name + " else";
                            tmpLabel3.Text = inner.ReadElementContentAsString();
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
    }
}
