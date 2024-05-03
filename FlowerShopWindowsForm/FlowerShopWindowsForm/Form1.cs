using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopWindowsForm
{
    public partial class Form1 : Form
    {
        Service.WebService1 service = new Service.WebService1();

        public Form1()
        {
            InitializeComponent();
            PopulateFlowersComboBox();
            PopulateMaterialsComboBox();
            PopulateDataGridView();
            
        }

        private void PopulateFlowersComboBox()
        {
            string[] flowerNames = service.GetFlowerNames();
            string[] flowerColors = service.GetFlowerColors();

            // Verifică dacă array-urile nu sunt goale
            if (flowerNames != null && flowerNames.Length > 0 && flowerColors != null && flowerColors.Length > 0)
            {
                // Iterează peste array-urile de nume și culori simultan
                for (int i = 0; i < flowerNames.Length; i++)
                {
                        comboBox_Flori.Items.Add(flowerNames[i] + ' ' + flowerColors[i]);
                }
            }
            else
            {
                // Dacă array-urile sunt goale, afișează un mesaj sau iei alte măsuri adecvate
                MessageBox.Show("Nu există flori disponibile.");
            }
        }

        private void PopulateMaterialsComboBox()
        {
            string[] supplyNames = service.GetSupplyNames();
            string[] supplyMaterials = service.GetSupplyMaterials();

            // Verifică dacă array-urile nu sunt goale
            if (supplyNames != null && supplyNames.Length > 0 && supplyMaterials != null && supplyMaterials.Length > 0)
            {
                // Iterează peste array-urile de nume și culori simultan
                for (int i = 0; i < supplyNames.Length; i++)
                {
                    comboBox_Materiale.Items.Add(supplyNames[i] + ' ' + supplyMaterials[i]);
                }
            }
            else
            {
                // Dacă array-urile sunt goale, afișează un mesaj sau iei alte măsuri adecvate
                MessageBox.Show("Nu există materiale disponibile.");
            }
        }

        private void textBox_Cantitate_Flori_TextChanged(object sender, EventArgs e)
        {
            int userQuantity;
            // Verificăm dacă câmpul text este gol sau nu poate fi convertit într-un număr întreg
            if (string.IsNullOrWhiteSpace(textBox_Cantitate_Flori.Text))
            {
                MessageBox.Show("Introduceți o valoare validă pentru cantitate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificăm dacă textul poate fi convertit într-un număr întreg
            if (!int.TryParse(textBox_Cantitate_Flori.Text, out userQuantity))
            {
                MessageBox.Show("Introduceți o valoare numerică validă pentru cantitate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            string selectedFlowerName = comboBox_Flori.SelectedItem?.ToString().Split(' ')[0]; // Obținem primul nume de floare din elementul selectat din combobox
            string selectedFlowerColor = comboBox_Flori.SelectedItem?.ToString().Split(' ')[1]; // Obținem culoarea corespunzătoare din elementul selectat din combobox
            int flowerQuantity = service.FlowerQuantity(selectedFlowerName, selectedFlowerColor);
            double unitPrice = service.FlowerUnitPrice(selectedFlowerName, selectedFlowerColor);
            if (userQuantity < flowerQuantity)
            {
                double totalPrice = userQuantity * unitPrice;
                label_Pret_F.Text = totalPrice.ToString();
            }

            if (userQuantity > flowerQuantity)
            {
                MessageBox.Show($"Cantitatea introdusă nu este pe stoc.Stoc maxim:{flowerQuantity}");
            }
        }

        private void textBox_Cantitate_Materiale_TextChanged(object sender, EventArgs e)
        {
            int userQuantity;
            // Verificăm dacă câmpul text este gol sau nu poate fi convertit într-un număr întreg
            if (string.IsNullOrWhiteSpace(textBox_Cantitate_Materiale.Text))
            {
                MessageBox.Show("Introduceți o valoare validă pentru cantitate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verificăm dacă textul poate fi convertit într-un număr întreg
            if (!int.TryParse(textBox_Cantitate_Materiale.Text, out userQuantity))
            {
                MessageBox.Show("Introduceți o valoare numerică validă pentru cantitate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedSupplyName = comboBox_Materiale.SelectedItem?.ToString().Split(' ')[0]; // Obținem primul nume de material din elementul selectat din combobox
            string selectedSupplyMaterial = comboBox_Materiale.SelectedItem?.ToString().Split(' ')[1]; // Obținem materialul corespunzător din elementul selectat din combobox
            int supplyQuantity = service.SupplyQuantity(selectedSupplyName, selectedSupplyMaterial);
            double unitPrice = service.SupplyUnitPrice(selectedSupplyName, selectedSupplyMaterial);
            if (userQuantity < supplyQuantity)
            {
                double totalPrice = userQuantity * unitPrice;
                label_Pret_M.Text = totalPrice.ToString();
            }

            if (userQuantity > supplyQuantity)
            {
                MessageBox.Show($"Cantitatea introdusă nu este pe stoc. Stoc maxim: {supplyQuantity}");
            }
        }


        private void comboBox_Flori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Flori.SelectedItem != null)
            {
                string selectedFlowerName = comboBox_Flori.SelectedItem.ToString().Split(' ')[0];
                string selectedFlowerColor = comboBox_Flori.SelectedItem.ToString().Split(' ')[1];

                double unitPrice = service.FlowerUnitPrice(selectedFlowerName, selectedFlowerColor);

                label_Pret_F.Text = unitPrice.ToString();
            }
        }

        private void comboBox_Materiale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Materiale.SelectedItem != null)
            {
                string selectedSupplyName = comboBox_Materiale.SelectedItem.ToString().Split(' ')[0];
                string selectedSupplyMaterial = comboBox_Materiale.SelectedItem.ToString().Split(' ')[1];

                //Console.WriteLine(selectedSupplyName);
                //Console.WriteLine(selectedSupplyMaterial);
                
                double unitPrice = service.SupplyUnitPrice(selectedSupplyName, selectedSupplyMaterial);

                label_Pret_M.Text = unitPrice.ToString();
            }
        }

        private void button_Add_Flower_Click(object sender, EventArgs e)
        {
            // Obțineți string-ul complet selectat din combobox
            string selectedFlowerString = comboBox_Flori.SelectedItem?.ToString();

            string selectedFlowerName = comboBox_Flori.SelectedItem?.ToString().Split(' ')[0];
            string selectedFlowerColor = comboBox_Flori.SelectedItem?.ToString().Split(' ')[1];

            // Verificați dacă s-a selectat o floare în combobox
            if (!string.IsNullOrEmpty(selectedFlowerString))
            {
                // Obțineți cantitatea introdusă de utilizator
                int quantity = Convert.ToInt32(textBox_Cantitate_Flori.Text);

                // Calculați prețul total pentru floarea respectivă
                double unitPrice = service.FlowerUnitPrice(selectedFlowerName, selectedFlowerColor);
                double totalPrice = unitPrice * quantity;

                // Adăugați informațiile într-un rând nou în ListView
                ListViewItem newItem = new ListViewItem(selectedFlowerString);
                newItem.SubItems.Add(quantity.ToString());
                newItem.SubItems.Add(totalPrice.ToString());
                listView_Optiuni.Items.Add(newItem);
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați o floare din combobox.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Add_Supply_Click(object sender, EventArgs e)
        {
            string selectedSupplyString = comboBox_Materiale.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSupplyString))
            {
                MessageBox.Show("Vă rugăm să selectați un material din combobox.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedSupplyName = selectedSupplyString.Split(' ')[0];
            string selectedSupplyMaterial = selectedSupplyString.Split(' ')[1];

            // Verificați dacă s-a introdus o cantitate validă
            if (!int.TryParse(textBox_Cantitate_Materiale.Text, out int quantity))
            {
                MessageBox.Show("Introduceți o valoare numerică validă pentru cantitate.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculați prețul total și adăugați informațiile într-un nou rând în ListView
            double unitPrice = service.SupplyUnitPrice(selectedSupplyName, selectedSupplyMaterial);
            double totalPrice = unitPrice * quantity;

            ListViewItem newItem = new ListViewItem(selectedSupplyString);
            newItem.SubItems.Add(quantity.ToString());
            newItem.SubItems.Add(totalPrice.ToString());
            listView_Optiuni.Items.Add(newItem);

           // MessageBox.Show($"Nume material: {selectedSupplyName}, Material: {selectedSupplyMaterial}, Cantitate: {quantity}");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            // Verificăm dacă există un element selectat în ListView
            if (listView_Optiuni.SelectedItems.Count > 0)
            {
                // Obținem elementul selectat și îl eliminăm
                ListViewItem selectedItem = listView_Optiuni.SelectedItems[0];
                listView_Optiuni.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un element pentru a-l șterge.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button_Create_Click(object sender, EventArgs e)
        {
            string numeBuchet = textBox1.Text;

            // Verificați dacă numele buchetului este gol
            if (string.IsNullOrWhiteSpace(numeBuchet))
            {
                MessageBox.Show("Vă rugăm să introduceți un nume pentru buchet.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculați prețul total al buchetului
            double totalPrice = 0;
            foreach (ListViewItem item in listView_Optiuni.Items)
            {
                totalPrice += Convert.ToDouble(item.SubItems[2].Text); // Indexul 2 este pentru prețul din ListViewItem

                // Actualizați stocul în baza de date pentru floare
                string flowerName = item.Text.Split(' ')[0]; // Obțineți numele florii din primul cuvânt
                string flowerColor = item.Text.Split(' ')[1]; // Obțineți culoarea florii din al doilea cuvânt
                int flowerQuantity = Convert.ToInt32(item.SubItems[1].Text); // Indexul 1 este pentru cantitate din ListViewItem
                service.UpdateFlowerStock(flowerName, flowerColor, flowerQuantity);

                // Actualizați stocul în baza de date pentru material
                string supplyName = item.SubItems[0].Text.Split(' ')[0]; // Obțineți numele materialului din primul cuvânt
                string supplyMaterial = item.SubItems[0].Text.Split(' ')[1]; // Obțineți materialul din al doilea cuvânt
                int supplyQuantity = Convert.ToInt32(item.SubItems[1].Text); // Indexul 1 este pentru cantitate din ListViewItem
                service.UpdateSupplyStock(supplyName, supplyMaterial, supplyQuantity);
            }

            // Adăugați buchetul în baza de date utilizând serviciul web și obțineți ID-ul
            int bouquetId = service.InsertBouquet(numeBuchet, totalPrice);

            // Adăugați un nou rând în DataTable pentru DataGridView
            DataTable dataTable = (DataTable)dataGridView_Buchete.DataSource;
            DataRow newRow = dataTable.NewRow();
            newRow["Id"] = bouquetId; // Adăugați ID-ul buchetului
            newRow["Name"] = numeBuchet;
            newRow["Price"] = totalPrice;
            dataTable.Rows.Add(newRow);

            // Actualizați sursa de date a DataGridView
            dataGridView_Buchete.DataSource = dataTable;

            // Ștergeți textul din TextBox pentru a pregăti introducerea următorului nume
            textBox1.Clear();
        }

        
            private void PopulateDataGridView()
            {
                DataSet bouquetDataSet = service.GetBouquetsDataSet();

                if (bouquetDataSet != null && bouquetDataSet.Tables.Count > 0)
                {
                    // Asigneaza tabelul cu buchete ca sursa de date pentru DataGridView
                    dataGridView_Buchete.DataSource = bouquetDataSet.Tables[0];
                }
                else
                {
                    MessageBox.Show("Nu există buchete disponibile.");
                }
            }

        private void button_Update_Click(object sender, EventArgs e)
        {
            // Verificați dacă a fost selectat un rând în DataGridView
            if (dataGridView_Buchete.SelectedRows.Count > 0)
            {
                // Obțineți numele buchetului selectat
                string numeVechi = dataGridView_Buchete.SelectedRows[0].Cells["Name"].Value.ToString();

                // Obțineți noul nume introdus de utilizator din TextBox
                string numeNou = textBox2.Text.Trim();

                // Verificați dacă utilizatorul a introdus un nou nume
                if (string.IsNullOrWhiteSpace(numeNou))
                {
                    MessageBox.Show("Vă rugăm să introduceți un nume pentru buchet.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizați numele buchetului în DataGridView
                dataGridView_Buchete.SelectedRows[0].Cells["Name"].Value = numeNou;

                // Actualizați numele buchetului în baza de date
                service.UpdateBouquetName(numeVechi, numeNou);

                // Afișați un mesaj de confirmare pentru utilizator
                MessageBox.Show("Numele buchetului a fost actualizat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un buchet din lista pentru a actualiza numele.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
