# İstanbul-Ankara-İzmir illeri arasında çalışan Mobil Firması yolcu bilgilerinin kaydedilmesi için bir program hazırlanması isteniyor. Programda
yolcuların ad, soy ad, TC, telefon gibi kişisel bilgileri ve nereden nereye gittikleri, hangi tarih ve saatte gidecekleri gibi bilgilerin yazdırılıp ListBox'a kaydedilmesi
istenmektedir. Buna göre ilgili programı:

namespace WinFormsApp15
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}
private void button1_Click(object sender, EventArgs e)
{
listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " +
maskedTextBox1.Text + " " + maskedTextBox2.Text + " Yolculuk Bilgileri: " +
comboBox1.Text + "-" + comboBox2.Text + " " + maskedTextBox3.Text + " " +
maskedTextBox4.Text);
}
}
}
