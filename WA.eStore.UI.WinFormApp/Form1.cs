using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WA.eStore.ValueObjects;

namespace WA.eStore.UI.WinFormApp
{
	public partial class Form1 : Form
	{
		private CitiesProvider citiesProvider;
		
		public Form1()
		{
			InitializeComponent();

			citiesProvider = new StaticCitiesProvider();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			initForm();
		}

		private void initForm()
		{
			this.City.DataSource = this.citiesProvider.GetCities();
			SyncVillageGroup();
		}

		private void SyncVillageGroup()
		{
			this.Village.DataSource = citiesProvider.GetVillages(this.City.SelectedItem as City);
			this.ZipCode.Text = (this.Village.SelectedItem as Village)?.ZipCode;
		}

		private void City_SelectedIndexChanged(object sender, EventArgs e)
		{
			SyncVillageGroup();
		}

		private void Village_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ZipCode.Text = (this.Village.SelectedItem as Village).ZipCode;
		}

		
	}
}
