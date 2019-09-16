using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_With_Arrey
{
    public partial class Home_UI : Form
    {
        const int size = 10;
        int index = 0;

        string[] customerName = new string[size];
        string[] contact = new string[size];
        string[] address = new string [size];
        string[] order = new string[size];
        Int32[] quantity = new Int32[size];

                
        public Home_UI()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            int totalPrice = 0;

           


            if(size>index)
            {
                customerName[index] = nametextbox.Text;
                contact[index] = contacttextbox.Text;
                address[index] = addresstextbox.Text;
                order[index] = ordercombox.Text;
                quantity[index] = Convert.ToInt32(quantitytextbox.Text);

            }

            if (order[index] == "Black")
            {
                totalPrice = quantity[index] * 120;
            }
            else if (order[index] == "Cold")
            {
                totalPrice = quantity[index] * 100;
            }
            else if (order[index] == "Hot")
            {
                totalPrice = quantity[index] * 90;
            }
            else if (order[index] == "Regular")
            {
                totalPrice = quantity[index] * 80;
            }
            //else
            //{
            //    MessageBox.Show("Please Select An Item");
            //}


            showrichbox.AppendText("\n\nCustomarName: " + customerName[index] + "\nContact Number:" +
                contact[index] + "\nAddress: " + address[index] + "\nOrder Name: " +
                order[index] + "\nQuantity: " + quantity[index] + "\nTotal price: " + totalPrice);


            nametextbox.Text = "";
            contacttextbox.Text = "";
            addresstextbox.Text="";
            ordercombox.Text = "Select An Item";
            quantitytextbox.Text = "";






        }

    }
}
