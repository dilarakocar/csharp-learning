# Kullanıcı tarafından ad, soyad, sınav1, sınav2 ve sınav3 bilgileri girilen kişinin adını soy adını ve ortalamasını ListBox'a ekleyen program:

namespace WinFormsApp12
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}
private void button1_Click(object sender, EventArgs e)
{
double sinav1, sinav2, sinav3, ortalama;
string ad, soyad;
ad = textBox1.Text;
soyad = textBox2.Text;
sinav1 = Convert.ToDouble(textBox3.Text);
sinav2 = Convert.ToDouble(textBox4.Text);
sinav3 = Convert.ToDouble(textBox5.Text);
ortalama = (sinav1 + sinav2 + sinav3) / 3;
listBox1.Items.Add(ad + " " + soyad + " Ortalama: " + ortalama);
}
}
}
