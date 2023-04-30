using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_shooping
{
    public partial class Form1 : Form
    {
        private Dictionary<string,Product> products = new Dictionary<string,Product>();

		private int qty;
		private Product selectedProduct = null;//目前選擇的商品
		private Dictionary<string,Shooping>shoopinglist = new Dictionary<string,Shooping>();

		public Form1()
        {
            InitializeComponent();
			products.Add("熟成紅茶", new Product { ProductName = "熟成紅茶", Price = 35 });
			products.Add("熟成歐蕾", new Product { ProductName = "熟成歐蕾", Price = 55 });
			products.Add("春芽冷露", new Product { ProductName = "春芽冷露", Price = 35 });
			
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (selectedProduct==null)
            {
                MessageBox.Show("請選擇商品");
                return;
            }
			// 根據目前選擇的商品，找到購買數量
			switch(selectedProduct.ProductName) 
			{
				case "熟成紅茶":
					qty = (int)tbQuantity1.Value;
					break;
				case "熟成歐蕾":
					qty = (int)tbQuantity2.Value;
					break;
				case "春芽冷露":
					qty = (int)tbQuantity3.Value;
					break;
			}
			UpdateShoppingCart(selectedProduct, qty);

			DisplayInfo();
		}


		private void tbQuantity1_ValueChanged(object sender, EventArgs e)
		{
			selectedProduct = tbQuantity1.Value == 0 ? null : products["熟成紅茶"];
			
		}

		
		private void tbQuantity2_ValueChanged(object sender, EventArgs e)
		{
			selectedProduct =tbQuantity2.Value == 0 ? null : products["熟成歐蕾"];
			
		}


		
		private void tbQuantity3_ValueChanged(object sender, EventArgs e)
		{
			selectedProduct = tbQuantity3.Value == 0 ? null :products["春芽冷露"];
			
		}
		private void UpdateShoppingCart(Product product, int qty) 
		{
			

			if (shoopinglist.ContainsKey(product.ProductName))
			{
				if (qty == 0)
					shoopinglist.Remove(product.ProductName);
				else
					shoopinglist[product.ProductName].Quantity = qty;
			}
			else
			{
				var item = new Shooping(product, qty);
				shoopinglist.Add(product.ProductName, item);
			}
		}
		private void DisplayInfo()
		{
			pbcat.Text = "";
			tbQuantity1.Value = 0;
			tbQuantity2.Value = 0;
			tbQuantity3.Value = 0;
			

			tbresult.Text = "";
			var totalCost = 0;
			foreach (var item in shoopinglist.Values)
			{
				totalCost += item.SubTotal;

				tbresult.Text += item.Product.ProductName + ": " + item.Quantity + " X " + item.Product.Price + " = " + item.SubTotal + Environment.NewLine;
			}
			tbresult.Text += "---------------" + Environment.NewLine;
			tbresult.Text += "總共花費: " + totalCost;
		}






	}


}


