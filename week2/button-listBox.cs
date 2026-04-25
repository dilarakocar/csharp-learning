namespace WinFormsApp8
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}
private void button1_Click(object sender, EventArgs e)
{
string kisiBilgisi = textBox1.Text;
listBox1.Items.Add(kisiBilgisi);
}
}
}
