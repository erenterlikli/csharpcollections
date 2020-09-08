using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Odev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ArrayList kayitlar = new ArrayList();
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ArrayList kayitlar = new ArrayList();
            kayitlar.Add("Gaziantep");
            kayitlar.Add("Kahramanmaraş");
            kayitlar.Add("Kayseri");
            kayitlar.Add("Adana");
            object n = kayitlar[0];
            object m = kayitlar[1];
            object k = kayitlar[2];
            object l = kayitlar[3];
            listBox1.Items.Add(n.ToString());
            listBox1.Items.Add(m.ToString());
            listBox1.Items.Add(k.ToString());
            listBox1.Items.Add(l.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove("Gaziantep");
            listBox1.Items.Remove("Kahramanmaraş");
            listBox2.Items.Add("Gaziantep");
            listBox2.Items.Add("Kahramanmaraş");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            kayitlar.Add("Gaziantep");
            kayitlar.Add("Kahramanmaraş");
            kayitlar.Add("Kayseri");
            kayitlar.Add("Adana");
            object n = kayitlar[0];
            object m = kayitlar[1];
            object k = kayitlar[2];
            object l = kayitlar[3];
            Int32 sonuc = kayitlar.BinarySearch("Kars", new CaseInsensitiveComparer());
            if (sonuc >=0) MessageBox.Show("Bulundu.");
            else MessageBox.Show("Bulunamadi.");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortedList liste = new SortedList();
            liste.Add("46", "Kahramanmaraş");
            liste.Add("38", "Kayseri");
            liste.Add("27", "Gaziantep");
            liste.Add("01", "Adana");
            ICollection keyAta = liste.Keys;
            foreach(var k in keyAta)
            {

                listBox2.Items.Add(k + "" + liste[k]);

            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stack h = new Stack();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stack h = new Stack();
            h.Push("Gaziantep");
            h.Push("Kahramanmaraş");
            h.Push("Kayseri");
            h.Push("Adana");
            object n = kayitlar[0];
            object m = kayitlar[1];
            object k = kayitlar[2];
            object l = kayitlar[3];
            listBox1.Items.Add(n.ToString());
            listBox1.Items.Add(m.ToString());
            listBox1.Items.Add(k.ToString());
            listBox1.Items.Add(l.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Stack h = new Stack();
            h.Push("Gaziantep");
            h.Push("Kahramanmaraş");
            h.Push("Kayseri");
            h.Push("Adana");
            object n = h.Pop();
            object m = h.Pop();
            object k = h.Pop();
            object l = h.Pop();
            listBox2.Items.Add(n.ToString());
            listBox2.Items.Add(m.ToString());
            listBox2.Items.Add(k.ToString());
            listBox2.Items.Add(l.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Queue k = new Queue(4,3);
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Queue k = new Queue(4, 3);
            k.Enqueue("Gaziantep");
            k.Enqueue("Kahramanmaraş");
            k.Enqueue("Kayseri");
            k.Enqueue("Adana");
            object n = kayitlar[0];
            object m = kayitlar[1];
            object j = kayitlar[2];
            object l = kayitlar[3];
            listBox1.Items.Add(n.ToString());
            listBox1.Items.Add(m.ToString());
            listBox1.Items.Add(j.ToString());
            listBox1.Items.Add(l.ToString());
          
            object a = k.Dequeue();
            object b = k.Dequeue();
            object c = k.Dequeue();
            object d = k.Dequeue();
            listBox2.Items.Add(a.ToString());
            listBox2.Items.Add(b.ToString());
            listBox2.Items.Add(c.ToString());
            listBox2.Items.Add(d.ToString());


           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList arayaEkle = new ArrayList();
            arayaEkle.Add("Ali");
            arayaEkle.Add("Veli");
            arayaEkle.Add("Ankara");
            arayaEkle.Insert(1, "Yildiz");
            foreach(object x in arayaEkle)
            {

                listBox1.Items.Add(x.ToString());

            }
        }
    }
}
