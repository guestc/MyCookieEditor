using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCookieEditor
{
    public partial class Main : Form
    {

        TextBox _editor;

        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name.Replace(".dll", "");
            dllName = dllName.Replace(".", "_");
            if (dllName.EndsWith("_resources")) return null;
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(GetType().Namespace + ".Properties.Resources", System.Reflection.Assembly.GetExecutingAssembly());
            byte[] bytes = (byte[])rm.GetObject(dllName);
            return System.Reflection.Assembly.Load(bytes);
        }
        public Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            InitializeComponent();
        }

        void log(object data) {
            Console.WriteLine(String.Format("[debug]:{0}",data));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_generate.SelectedIndex = 0;
            comboBox_input.SelectedIndex = 0;
            _editor = new TextBox();
            _editor.Visible = false;
            listView1.Controls.Add(_editor);
            _editor.BringToFront();
            _editor.KeyUp += _editor_KeyUp;
        }

        private void _editor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                var info = listView1.HitTest(_editor.Location).SubItem;
                if (info != null) {
                    info.Text = _editor.Text;
                    _editor.Visible = false;
                }
            }
        }

        private void AddCookieToView(MyCookie ck) {
            ListViewItem item = new ListViewItem(ck.name);
            item.SubItems.Add(ck.value);
            item.SubItems.Add(ck.path);
            item.SubItems.Add(ck.domain);
            item.SubItems.Add(ck.expirationDate);
            item.SubItems.Add(ck.sameSite);
            item.SubItems.Add(ck.hostOnly.ToString());
            item.SubItems.Add(ck.httpOnly.ToString());
            item.SubItems.Add(ck.secure.ToString());
            item.SubItems.Add(ck.session.ToString());
            item.SubItems.Add(ck.storeId);
            listView1.Items.Add(item);
        }
        private MyCookie ItemToMyCookie(ListViewItem item) {
            string name = item.Text;
            MyCookie ck = new MyCookie(name, item.SubItems[1].Text);
            ck.path = item.SubItems[2].Text;
            ck.domain = item.SubItems[3].Text;
            ck.expirationDate = item.SubItems[4].Text;
            ck.sameSite = item.SubItems[5].Text;
            ck.hostOnly = bool.Parse(item.SubItems[6].Text);
            ck.httpOnly = bool.Parse(item.SubItems[7].Text);
            ck.secure = bool.Parse(item.SubItems[8].Text);
            ck.session = bool.Parse(item.SubItems[9].Text);
            ck.storeId = item.SubItems[10].Text;
            return ck;
        }

        private void LoadView(List<MyCookie> cks)
        {
            listView1.Items.Clear();
            foreach (var ck in cks.ToArray()) {
                AddCookieToView(ck);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load
            if (richTextBox_input.Text != "") {
                List<MyCookie> cks = null;
                switch (comboBox_input.SelectedItem.ToString()) {
                    case "Raw":
                        cks = utils.getCookiesFromRaw(richTextBox_input.Text);
                        break;
                    case "Json":
                        cks = utils.getCookiesFromJson(richTextBox_input.Text);
                        break;
                }
                LoadView(cks);
                richTextBox_input.Text = "";
            }
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.Location).SubItem;
            if (info != null) {
                Point ps = info.Bounds.Location;
                ps.X = 2;
                _editor.Location = ps;
                _editor.Size = new Size(listView1.Width,info.Bounds.Height);
                _editor.Text = info.Text;
                _editor.Visible = true;
                _editor.Select();
                _editor.SelectAll();
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_editor.Visible) { 
                var target = listView1.HitTest(e.Location).SubItem;
                var info = listView1.HitTest(_editor.Location).SubItem;
                if (target != info) {
                    _editor.Visible = false;
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string value = textBox_value.Text;
            if (name != "" && value != "") {
                AddCookieToView(new MyCookie(name,value));
                textBox_name.Text = "";
                textBox_value.Text = "";
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) {
                foreach (ListViewItem item in listView1.SelectedItems) {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            List<MyCookie> cks = new List<MyCookie>();
            foreach (ListViewItem item in listView1.Items) {
                cks.Add(ItemToMyCookie(item));
            }
            switch (comboBox_generate.SelectedItem.ToString())
            {
                case "Raw":
                    richTextBox_generate.Text = utils.getRawFromCookies(cks);
                    break;
                case "Json":
                    richTextBox_generate.Text = utils.getJsonFromCookies(cks);
                    break;
            }
        }
    }
}
