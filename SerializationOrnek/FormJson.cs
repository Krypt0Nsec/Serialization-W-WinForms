using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializationOrnek
{
	public partial class FormJson : Form
	{
		BinaryFormatter formatter = new BinaryFormatter();
		public FormJson()
		{
			InitializeComponent();
		}

		private void btnDosyayaYaz_Click(object sender, EventArgs e)
		{
			try
			{
				Product product = new Product();

				product.Name = "Apple";
				product.ExpireDate = new DateTime(2008, 12, 28);

				JsonSerializer serializer = new JsonSerializer();
				using (StreamWriter sw = new StreamWriter(@"C:\Users\alper\source\repos\JsonOrnek\json.json"))
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, product);
					MessageBox.Show("Serilize Edildi");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnDosyadanOku_Click(object sender, EventArgs e)
		{
			try
			{
				JsonSerializer serializer = new JsonSerializer();
				using (StreamReader file = File.OpenText(@"C:\Users\alper\source\repos\JsonOrnek\json.json"))
				using (JsonReader reader = new JsonTextReader(file))
				{
					try
					{
						Product product = (Product)serializer.Deserialize(reader, typeof(Product));
						MessageBox.Show(product.Name + ", " + Convert.ToString(product.ExpireDate));
					}
					catch (Exception ex)
					{

						MessageBox.Show("Hata Oluştu:" + ex.Message);
					}
					
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				
			}
		}
	}
}
