using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilbasiCekilis
{
    public partial class Homapage : MetroFramework.Forms.MetroForm
    {
        public string[] List_Tam = Properties.Resources.YilbasiCekilisitext.Replace("\r", "").Split('\n');
        public string[] List_Kalan;
        public Homapage()
        {
            InitializeComponent();
        }
        
        private void Homapage_Load(object sender, EventArgs e)
        {
            List_Kalan = List_Tam;
            UpdateComboList();
        }

        public void UpdateComboList() {
            isimlercomboBox.Items.Clear();
            for (int i = 0; i < List_Kalan.Count(); i++)
            {
                isimlercomboBox.Items.Add(List_Kalan[i]);
            }
        }

        private void isimcekbutton_Click(object sender, EventArgs e)
        {
            CekilisYap();
        }

        public void CekilisYap() {

            //MessageBox.Show(isimlercomboBox.SelectedItem.ToString());
            if (isimlercomboBox.SelectedIndex == -1) { MessageBox.Show("seçim yapmadınız !"); }
            else
            {
                if (isimlercomboBox.SelectedItem.ToString() != "")
                {
                    if (List_Kalan.Count() == 0)
                    {
                        MessageBox.Show("Çekiliş Bitti");
                        isimcekbutton.Enabled = false;
                    }
                    else
                    {
                        #region "Seçim Yap"
                            string[] List_Kalan2 = new string[0];
                            for (int i = 0; i < List_Kalan.Count(); i++)
                            {
                                if (List_Kalan[i] != isimlercomboBox.SelectedItem.ToString() ) {
                                    List_Kalan2 = new string[List_Kalan2.Count()+1];
                                    List_Kalan2[List_Kalan2.Count()] = List_Kalan[i];  
                                }
                            }
                            Random rastgeleNumara = new Random();
                            int secilenRastgeleNumara = rastgeleNumara.Next(0, List_Kalan2.Count());
                        #endregion

                        MessageBox.Show(List_Kalan2[secilenRastgeleNumara]);

                        #region "ComboBox'tan Düşme"
                            isimlercomboBox.Items.Remove(isimlercomboBox.SelectedIndex);
                        #endregion


                    }
                    
                }
                else
                {
                    MessageBox.Show("isminizi giriniz");
                }
            }


        }
    }
}
