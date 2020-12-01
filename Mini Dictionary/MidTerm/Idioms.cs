using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class Idioms : Form
    {
        public Idioms()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Idioms_Load(object sender, EventArgs e)
        {

            var data = GetListData();
            listView1.Items.Clear();
            foreach (var Dictionary in data)
            {
                var row = new string[] { Dictionary.Id, Dictionary.Idioms,Dictionary.Meanings };
                var ls = new ListViewItem(row);
                ls.Tag = Dictionary;
                listView1.Items.Add(ls);
            }
        }

        private List<Dictionary> GetListData()
        {
            var list = new List<Dictionary>();
            list.Add(new Dictionary() { Id = "1", Idioms = "A Bit Much" , Meanings="Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "2", Idioms = "A Bite at The Cherry", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "3", Idioms = "Above And Beyond", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "4", Idioms = "About Time", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "5", Idioms = "A Storm in a Teacup", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "6", Idioms = "A Tall Order", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "7", Idioms = "A Stitch in Time Saves Nine", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "8", Idioms = "A Week Is A Long Time In ___", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "9", Idioms = "A Stone’s Throw", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "10", Idioms = "About To", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "11", Idioms = "A Snowball’s Chance in Hell", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "12", Idioms = "A Sitting Duck", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "13", Idioms = "A Sight for Sore Eyes", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "14", Idioms = "A Second Bite At The Cherry", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "15", Idioms = "A Penny Saved is A Penny Earned", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "16", Idioms = "A Picture Is Worth a Thousand Words", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "17", Idioms = "A Plum Job", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "18", Idioms = "A Rare Bird", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "19", Idioms = "A Scaredy - Cat", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "20", Idioms = "a Little from Column B", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "21", Idioms = "A Busy Bee", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "22", Idioms = "A Notch Above", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "23", Idioms = "A Million and Onee", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "24", Idioms = "A Little Bird Told Me", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "25", Idioms = "A Little from Column A", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "26", Idioms = "A Little Bird Told Me", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "27", Idioms = "A Life Of Its Own", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "28", Idioms = "A Lemon", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "29", Idioms = "A Lame Duck", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "31", Idioms = "A Hundred And Ten Percent", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "32", Idioms = "A Lone Wolf", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "33", Idioms = "A Lot on One’s Plate", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "34", Idioms = "A Leg Up", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "35", Idioms = "A Good Deal", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "36", Idioms = "A Great Deal", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "37", Idioms = "A Few Sandwiches Short Of A Picnic", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "38", Idioms = "A Guinea Pig", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "39", Idioms = "A Hair’s Breadt", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "40", Idioms = "A Home Bird", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "41", Idioms = "A Dog in The Manger", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "42", Idioms = "A Day Late And A Dollar Short", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "43", Idioms = "A Cut Below", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "44", Idioms = "A Cat Has Nine Lives", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "45", Idioms = "A Cat Nap", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "46", Idioms = "A Cold Day In July", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "47", Idioms = "A Cat in Gloves Catches No Mice", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "48", Idioms = "A Cold Fish", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "49", Idioms = "Above Water", Meanings = "Example Text Meanings due to Shortage of time" });
            list.Add(new Dictionary() { Id = "50", Idioms = "Across The Board", Meanings = "Example Text Meanings due to Shortage of time" });

            return list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtIdioms.Text) )
                return;
            ListViewItem item = new ListViewItem(txtId.Text);
            item.SubItems.Add(txtIdioms.Text);
            //item.SubItems.Add(txtMeanings.Text);

            listView1.Items.Add(item);
            txtId.Clear();
            txtIdioms.Clear();
            txtId.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        int visible ;
        private void btnView_Click(object sender, EventArgs e)
        {
            listView1.Hide();
            visible++;
            if (visible % 2 == 0)
            {
                listView1.Show();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
    }
}
