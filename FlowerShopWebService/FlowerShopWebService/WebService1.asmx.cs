using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace FlowerShopWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsFlowers = new DataSet();
        DataSet dsSupplies = new DataSet();
        DataSet dsBouquets = new DataSet();
        

        [WebMethod]
        public string HelloWorld()
        {
            return "Bine ai venit în Paradisul Florilor!";
        }

        [WebMethod]

        public string[] GetFlowerNames()
        {
            List<string> flowerNames = new List<string>();

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name FROM Flowers", myCon))
                {
                    myCon.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adaugă numele florii în listă
                            flowerNames.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            return flowerNames.ToArray();
        }

        [WebMethod]

        public string[] GetSupplyNames()
        {
            List<string> supplyNames = new List<string>();

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Name FROM Supplies", myCon))
                {
                    myCon.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adaugă numele florii în listă
                            supplyNames.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            return supplyNames.ToArray();
        }

        [WebMethod]

        public string[] GetFlowerColors()
        {
            List<string> flowerColors = new List<string>();

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Color FROM Flowers", myCon))
                {
                    myCon.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adaugă numele florii în listă
                            flowerColors.Add(reader["Color"].ToString());
                        }
                    }
                }
            }

            return flowerColors.ToArray();
        }

        [WebMethod]

        public string[] GetSupplyMaterials()
        {
            List<string> supplyMaterials = new List<string>();

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Material FROM Supplies", myCon))
                {
                    myCon.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Adaugă numele florii în listă
                            supplyMaterials.Add(reader["Material"].ToString());
                        }
                    }
                }
            }

            return supplyMaterials.ToArray();
        }

        [WebMethod]

        public int FlowerQuantity(string flowerName, string flowerColor)
        {

            int quantity = 0;

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();

                string query = "SELECT Stock FROM Flowers WHERE Name = @FlowerName AND Color = @FlowerColor";

                // Creează comanda SQL și asociază conexiunea
                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    cmd.Parameters.Add("@FlowerName", SqlDbType.VarChar, 50).Value = flowerName;
                    cmd.Parameters.Add("@FlowerColor", SqlDbType.VarChar, 50).Value = flowerColor;
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        quantity = Convert.ToInt32(result);
                    }
                }

                myCon.Close();
            }

            return quantity;
        }

        [WebMethod]

        public int SupplyQuantity(string supplyName, string supplyMaterial)
        {

            int quantity = 0;

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();

                string query = "SELECT Stock FROM Supplies WHERE Name = @SupplyName AND Material = @SupplyMaterial";

                // Creează comanda SQL și asociază conexiunea
                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    cmd.Parameters.Add("@SupplyName", SqlDbType.VarChar, 50).Value = supplyName;
                    cmd.Parameters.Add("@SupplyMaterial", SqlDbType.VarChar, 50).Value = supplyMaterial;
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        quantity = Convert.ToInt32(result);
                    }
                }

                myCon.Close();
            }

            return quantity;
        }

        [WebMethod]

        public double FlowerUnitPrice(string flowerName, string flowerColor)
        {
            double price = 0;

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();

                string query = "SELECT Price FROM Flowers WHERE Name = @FlowerName AND Color = @FlowerColor";

                // Creează comanda SQL și asociază conexiunea
                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    // Setează tipul de date pentru parametrii
                    cmd.Parameters.Add("@FlowerName", SqlDbType.VarChar, 50).Value = flowerName;
                    cmd.Parameters.Add("@FlowerColor", SqlDbType.VarChar, 50).Value = flowerColor;

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        price = Convert.ToDouble(result);
                    }
                }

                myCon.Close();
            }

            return price;
        }

        [WebMethod]

        public double SupplyUnitPrice(string supplyName, string supplyMaterial)
        {
            double price = 0;

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();

                string query = "SELECT Price FROM Supplies WHERE Name = @SupplyName AND Material = @SupplyMaterial";

                // Creează comanda SQL și asociază conexiunea
                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    // Setează tipul de date pentru parametrii
                    cmd.Parameters.Add("@SupplyName", SqlDbType.VarChar, 50).Value = supplyName;
                    cmd.Parameters.Add("@SupplyMaterial", SqlDbType.VarChar, 50).Value = supplyMaterial;

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        price = Convert.ToDouble(result);
                    }
                }

                myCon.Close();
            }

            return price;
        }

        [WebMethod]

        public DataSet GetBouquetsDataSet()
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();
                string query = "SELECT * FROM Bouquets";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, myCon))
                {
                    adapter.Fill(dataSet);
                }
                myCon.Close();
            }
            return dataSet;
        }

        [WebMethod]
        public int InsertBouquet(string bouquetName, double totalPrice)
        {
            int bouquetId = 0;

            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();
                string query = "INSERT INTO Bouquets (Name, Price) OUTPUT INSERTED.ID VALUES (@BouquetName, @TotalPrice)";

                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    cmd.Parameters.AddWithValue("@BouquetName", bouquetName);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                    // Executăm comanda și obținem ID-ul buchetului nou adăugat
                    bouquetId = (int)cmd.ExecuteScalar();
                }

                myCon.Close();
            }

            return bouquetId;
        }

        [WebMethod]
        public void UpdateBouquetName(string oldName, string newName)
        {
            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();
                string query = "UPDATE Bouquets SET Name = @NewName WHERE Name = @OldName";
                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    cmd.Parameters.AddWithValue("@NewName", newName);
                    cmd.Parameters.AddWithValue("@OldName", oldName);
                    cmd.ExecuteNonQuery();
                }
                myCon.Close();
            }
        }

        [WebMethod]
        public void UpdateFlowerStock(string flowerName, string flowerColor, int quantity)
        {
            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();

                string query = "UPDATE Flowers SET Stock = Stock - @Quantity WHERE Name = @FlowerName AND Color = @FlowerColor";

                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    cmd.Parameters.Add("@FlowerName", SqlDbType.VarChar, 50).Value = flowerName;
                    cmd.Parameters.Add("@FlowerColor", SqlDbType.VarChar, 50).Value = flowerColor;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;

                    cmd.ExecuteNonQuery();
                }

                myCon.Close();
            }
        }

        [WebMethod]
        public void UpdateSupplyStock(string supplyName, string supplyMaterial, int quantity)
        {
            using (SqlConnection myCon = new SqlConnection("Data Source=DESKTOP-4E2J2L9;Initial Catalog=FlowerShop;Integrated Security=True"))
            {
                myCon.Open();

                string query = "UPDATE Supplies SET Stock = Stock - @Quantity WHERE Name = @SupplyName AND Material = @SupplyMaterial";

                using (SqlCommand cmd = new SqlCommand(query, myCon))
                {
                    cmd.Parameters.Add("@SupplyName", SqlDbType.VarChar, 50).Value = supplyName;
                    cmd.Parameters.Add("@SupplyMaterial", SqlDbType.VarChar, 50).Value = supplyMaterial;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;

                    cmd.ExecuteNonQuery();
                }

                myCon.Close();
            }
        }

    }
}
