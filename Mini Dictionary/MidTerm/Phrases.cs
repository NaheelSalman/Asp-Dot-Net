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
    public partial class Phrases : Form
    {
        public Phrases()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Phrases_Load(object sender, EventArgs e)
        {
            var data = GetListData();
            listView1.Items.Clear();
            foreach(var Dictionary in data)
            {
                var row = new string[] { Dictionary.Id, Dictionary.Phrases, Dictionary.Proverbs,Dictionary.Slang };
                var ls = new ListViewItem(row);
                ls.Tag = Dictionary;
                listView1.Items.Add(ls);
            }
        }

        private List<Dictionary> GetListData()
        {
            var list = new List<Dictionary>();
            list.Add(new Dictionary() { Id = "1" ,Phrases= "Im all ears" , Proverbs= "A bad workman always blames his tools", Slang= "All-ears" });
            list.Add(new Dictionary() { Id = "2", Phrases = "What’s up?", Proverbs = "A bird in hand is worth two in the bush", Slang = "ASAP" });
            list.Add(new Dictionary() { Id = "3", Phrases = "Thanks a million!", Proverbs = "Absence makes the heart grow fonder", Slang = "B-Ball" });
            list.Add(new Dictionary() { Id = "4", Phrases = ". I owe you one", Proverbs = "A cat has nine lives", Slang = "Blow or Bomb" });
            list.Add(new Dictionary() { Id = "5", Phrases = "That’s interesting", Proverbs = "A chain is only as strong as its weakest link", Slang = "By the skin of your teeth:" });
            list.Add(new Dictionary() { Id = "6", Phrases = "Gotcha", Proverbs = "Actions speak louder than words", Slang = "A cheesy pick - up line" });
            list.Add(new Dictionary() { Id = "7", Phrases = "Would you happen to know", Proverbs = "A drowning man will clutch at a straw", Slang = "Couch Potato" });
            list.Add(new Dictionary() { Id = "8", Phrases = "I’ve been wondering that, too.", Proverbs = "Adversity and loss make a man wise", Slang = "Cram" });
            list.Add(new Dictionary() { Id = "9", Phrases = "In my opinion", Proverbs = "A fool and his money are soon parted.", Slang = "DC" });
            list.Add(new Dictionary() { Id = "10", Phrases = "Beats me", Proverbs = "A journey of thousand miles begins with a single step.", Slang = "Dutch or go Dutch" });
            list.Add(new Dictionary() { Id = "11", Phrases = "I beg to differ", Proverbs = "A leopard can’t/ doesn’t change its spots.", Slang = "All-ears" });
            list.Add(new Dictionary() { Id = "12", Phrases = "I suppose so", Proverbs = "All good things come to an end.", Slang = "Piece of cake" });
            list.Add(new Dictionary() { Id = "13", Phrases = "On the contrary", Proverbs = "An idle brain is the devil’s workshop.", Slang = "R.S.V.P" });
            list.Add(new Dictionary() { Id = "14", Phrases = "Sounds great!", Proverbs = "An ounce of protection is worth a pound of cure.", Slang = "On the hour" });
            list.Add(new Dictionary() { Id = "15", Phrases = "I’m planning to", Proverbs = "A picture is worth a thousand words.", Slang = "Once in a blue moon" });
            list.Add(new Dictionary() { Id = "16", Phrases = "I live for", Proverbs = ". Appearances can be deceptive.", Slang = "My Bad" });
            list.Add(new Dictionary() { Id = "17", Phrases = "I don’t really care for", Proverbs = "A rolling stone gathers no moss.", Slang = "Jacked" });
            list.Add(new Dictionary() { Id = "18", Phrases = "I’d recommend", Proverbs = "A ship in the harbor is safe, but that is not what a ship is", Slang = "Pass the buc" });
            list.Add(new Dictionary() { Id = "19", Phrases = "Sorry to interrupt,", Proverbs = "As you sow, so you shall reap.", Slang = "Lighten up" });
            list.Add(new Dictionary() { Id = "20", Phrases = "You’re on the right track.", Proverbs = "A thing begun is half done.", Slang = "Shoot the breeze" });

            return list;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPhrases.Text) || string.IsNullOrEmpty(txtProverb.Text) || string.IsNullOrEmpty(txtSlang.Text))
                return;
            ListViewItem item = new ListViewItem(txtId.Text);
            item.SubItems.Add(txtPhrases.Text);
            item.SubItems.Add(txtProverb.Text);
            item.SubItems.Add(txtSlang.Text);
            listView1.Items.Add(item);
            txtId.Clear();
            txtPhrases.Clear();
            txtProverb.Clear();
            txtSlang.Clear();
            txtId.Focus();
        }

       

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        int visible;
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
