using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form1.cs;

global int counter = 0;

private void OlusturBilet()
{

    // Bilet olu�turma i�lemleri
    string nereden = nereden_combobox.Text;
    string nereye = nereye_combobox.Text;
    string sefer = sefer_combobox.Text;
    // int koltukNo = (int)koltuk_numarasi_numupdown.Value;
    int Id = counter;
    counter++;
    // Bilet olu�turuldu�unu g�stermek i�in bir ileti�im kutusu g�ster
    MessageBox.Show($"Bilet Olu�turuldu!\nNereden: {nereden}\nNereye: {nereye}\nSefer: {sefer}\n Bilet ID: {Id}");

    // Olu�turulan bilet bilgilerini s�f�rla veya gerekli i�lemleri yap
    nereden_combobox.SelectedIndex = 0;
    nereye_combobox.SelectedIndex = 0;
    sefer_combobox.SelectedIndex = 0;
    koltuk_numarasi_numupdown.Value = 0;

}
