using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace Final
{
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
            LoadData();
            LoadReader();
        }

        #region Method
        void LoadData()
        {
            CardBLL cardBLL = new CardBLL();

            dataGridCard.DataSource = cardBLL.LoadDataBLL();
        }

        void LoadReader()
        {
            CardBLL cardBLL=new CardBLL();
            ReaderBox.DataSource = cardBLL.DocGiaBLL();
            ReaderBox.SelectedIndex = -1;
        }

        void Register(string ReaderID, string Note)
        {
            CardBLL cardBLL = new CardBLL();
            if (cardBLL.checkCard(ReaderID))
            {
                MessageBox.Show("Da ton tai");
            }
            else if (!cardBLL.DocGiaBLL().Contains(ReaderID))
            {
                MessageBox.Show("Doc gia khong ton tai");
            }
            else
            {
                cardBLL.AddCard(ReaderID, Note);
            }
            
        }
        #endregion

        private void Regis_card_Click(object sender, EventArgs e)
        {
            Register(ReaderBox.Text,textNote.Text);
            LoadData();
        }
    }
}
