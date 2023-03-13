using System.Xml.Serialization;

namespace SerializationOrnek
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnSerialized_Click(object sender, EventArgs e)
		{
			Employee emp = new Employee
			{
				Name = txtAdi.Text,
				Phone = txtTelefon.Text,
				DoB = dateTimeDogum.Value,
				Department = txtDepartman.Text,
				Salary = Convert.ToInt32(txtMaas.Text),
				additonalInfo = "Serileşme İstemiyoruz"
			};
			XmlSerializer xs = new XmlSerializer(typeof(Employee));
			FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write,
				 FileShare.None);
			try
			{
				using (fsout)
				{
					xs.Serialize(fsout, emp);
					SonucLabel.Text = "Bilgiler Serilize Edildi";
					SonucLabel.Visible = true;
					txtAdi.Text = "";
					txtTelefon.Text = "";
					txtDepartman.Text = "";
					txtMaas.Text = "";
				}
			}
			catch (Exception ex)
			{
				ex.Message.ToString();
				SonucLabel.Text = "Bir sorun oluştu";
				SonucLabel.Visible= true;
				
			}

		}

		private void btnDeSerialized_Click(object sender, EventArgs e)
		{
			Employee emp = new Employee();

			XmlSerializer xs = new XmlSerializer(typeof(Employee));
			FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);

			try
			{
				using (fsin)
				{
					emp	= (Employee)xs.Deserialize(fsin);
					SonucLabel.Text = "Object DeSerilize Edildi";
					SonucLabel.Visible = true;
					txtAdi.Text = emp.Name;
					txtTelefon.Text = emp.Phone;
					dateTimeDogum.Value= emp.DoB;
					txtDepartman.Text = emp.Department;
					txtMaas.Text = Convert.ToString(emp.Salary);
				}
			}
			catch (Exception ex)
			{
				ex.Message.ToString();
				SonucLabel.Text = "Bir Hata Oluştu";
				SonucLabel.Visible = true;
			}
		}
	}
}