using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Xml.Linq;

namespace BestOil_Winform
{
    public partial class Form1 : Form
    {
        FuelStation fuelStation = new FuelStation();
        List<Fuel> fuels = new List<Fuel> {
            new Fuel{Name="AI-92",Price=1.01},
            new Fuel{Name="AI-95",Price= 2.03},
            new Fuel{Name="AI-98",Price=2.33},
            new Fuel{Name="Diesel",Price=0.81}
        };

        MiniCafe miniCafe = new MiniCafe();
        List<Food> foods = new List<Food>
        {
            new Food{Name="Hot-Dog",Price=2.40},
            new Food{Name="Gamburger",Price=3.50},
            new Food{Name="Coca-Cola",Price=0.99},
            new Food{Name="Sprite",Price=0.99}
        };

        Fuel currentFuel; Food currentFood;
        string temp;
        List<string> productsName = new List<string>();
        List<string> productsPrice = new List<string>();
        List<string> productsCount = new List<string>();
        public Form1()
        {
            InitializeComponent();
            fuelStation.Fuels = fuels;
            miniCafe.Foods = foods;
            cmbFuel.DataSource = null;
            cmbFuel.DataSource = fuelStation.Fuels;
            cmbFuel.DisplayMember = nameof(Fuel.Name);
            cmbFuel.SelectedIndex = 0;
            txtLiter.Enabled = true;
            txtAzn.Enabled = false;
            InitializeFoodPrice();
            nudHotDogCount.Enabled = false;
            nudGamburgerCount.Enabled = false;
            nudCocaColaCount.Enabled = false;
            nudSpriteCount.Enabled = false;
            txtLiter.Text = "0,00";
            if (lblTotalAmount.Text == string.Empty) lblTotalAmount.Text = "0,00";
        }

        private void cmbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var fuel = cmbFuel.SelectedItem as Fuel;
                if (fuel != null)
                {

                    txtFuelPrice.Text = fuel.Price.ToString();
                    currentFuel = fuel;

                    if (rbAzn.Checked)
                    {
                        if (txtAzn.Text == string.Empty) { lblFuelAmount.Text = "0,00"; }
                        else lblFuelAmount.Text = txtAzn.Text;
                        if (Validation.CheckLiter(CalculateFunctions.CalculateFuelLiterByAzn(currentFuel, txtAzn.Text)))
                        {
                            txtLiter.Text = CalculateFunctions.CalculateFuelLiterByAzn(currentFuel, txtAzn.Text).ToString("0.00");
                            lblTotalAmount.Text = (Convert.ToDouble(lblFuelAmount.Text) + Convert.ToDouble(lblFoodAmount.Text)).ToString("0.00");
                        }

                    }
                    else if (rbLiter.Checked)
                    {
                        if (txtLiter.Text == string.Empty) temp = "0";
                        else temp = txtLiter.Text;
                        if (Validation.CheckLiter(Convert.ToDouble(temp)))
                        {
                            lblFuelAmount.Text = CalculateFunctions.CalculateFuelPriceByLiter(currentFuel, txtLiter.Text).ToString("0.00");
                            txtAzn.Text = lblFuelAmount.Text;
                            lblTotalAmount.Text = (Convert.ToDouble(lblFuelAmount.Text) + Convert.ToDouble(lblFoodAmount.Text)).ToString("0.00");
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
                // Log the error
                FileManage.LogError(ex);
            }


        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if (rb.Text == "Liter") { txtLiter.Enabled = true; txtAzn.Enabled = false; }
                else if (rb.Text == "AZN") { txtAzn.Enabled = true; txtLiter.Enabled = false; }
            }
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAzn.Checked)
                {
                    if (txtAzn.Text == string.Empty) lblFuelAmount.Text = "0,00";
                    else { double azn = Convert.ToDouble(txtAzn.Text); lblFuelAmount.Text = azn.ToString("0.00"); }
                    if (Validation.CheckLiter(CalculateFunctions.CalculateFuelLiterByAzn(currentFuel, txtAzn.Text)))
                    {
                        txtLiter.Text = CalculateFunctions.CalculateFuelLiterByAzn(currentFuel, txtAzn.Text).ToString("0.00");
                        lblTotalAmount.Text = (Convert.ToDouble(lblFuelAmount.Text) + Convert.ToDouble(lblFoodAmount.Text)).ToString("0.00");
                    }
                }
                else if (rbLiter.Checked)
                {
                    if (txtLiter.Text == string.Empty) temp = "0";
                    else temp = txtLiter.Text;
                    if (Validation.CheckLiter(Convert.ToDouble(temp)))
                    {
                        lblFuelAmount.Text = CalculateFunctions.CalculateFuelPriceByLiter(currentFuel, txtLiter.Text).ToString("0.00");
                        txtAzn.Text = lblFuelAmount.Text;
                        lblTotalAmount.Text = (Convert.ToDouble(lblFuelAmount.Text) + Convert.ToDouble(lblFoodAmount.Text)).ToString("0.00");
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
                // Log the error
                FileManage.LogError(ex);
            }
        }

        private void txtBox_Click(object sender, EventArgs e)
        {
            if (rbAzn.Checked) { txtAzn.Text = ""; }
            else if (rbLiter.Checked) { txtLiter.Text = ""; }
        }


        private void cbCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var cb = (CheckBox)sender;
                currentFood = miniCafe.GetFood(cb.Text);
                if (cb.Checked)
                {
                    if (cb.Text == "Hot-Dog")
                    {
                        nudHotDogCount.Text = "1";
                        nudHotDogCount.Value = 1;
                        nudHotDogCount.Enabled = true;
                    }
                    else if (cb.Text == "Gamburger")
                    {

                        nudGamburgerCount.Text = "1";
                        nudGamburgerCount.Value = 1;
                        nudGamburgerCount.Enabled = true;
                    }
                    else if (cb.Text == "Coca-Cola")
                    {
                        nudCocaColaCount.Text = "1";
                        nudCocaColaCount.Value = 1;
                        nudCocaColaCount.Enabled = true;
                    }
                    else if (cb.Text == "Sprite")
                    {
                        nudSpriteCount.Text = "1";
                        nudSpriteCount.Value = 1;
                        nudSpriteCount.Enabled = true;
                    }
                }
                else
                {
                    if (cb.Text == "Hot-Dog")
                    {
                        nudHotDogCount.Text = "0";
                        nudHotDogCount.Value = 0;
                        nudHotDogCount.Enabled = false;
                    }
                    else if (cb.Text == "Gamburger")
                    {
                        nudGamburgerCount.Text = "0";
                        nudGamburgerCount.Value = 0;
                        nudGamburgerCount.Enabled = false;
                    }
                    else if (cb.Text == "Coca-Cola")
                    {
                        nudCocaColaCount.Text = "0";
                        nudCocaColaCount.Value = 0;
                        nudCocaColaCount.Enabled = false;
                    }
                    else if (cb.Text == "Sprite")
                    {
                        nudSpriteCount.Text = "0";
                        nudSpriteCount.Value = 0;
                        nudSpriteCount.Enabled = false;
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
                // Log the error
                FileManage.LogError(ex);
            }
        }


        private void InitializeFoodPrice()
        {
            try
            {
                txtHotDogPrice.Text = miniCafe.GetFoodPrice(cbHotDog.Text).ToString("0.00");
                txtGamburgerPrice.Text = miniCafe.GetFoodPrice(cbGamburger.Text).ToString("0.00");
                txtCocaColaPrice.Text = miniCafe.GetFoodPrice(cbCocaCola.Text).ToString("0.00");
                txtSpritePrice.Text = miniCafe.GetFoodPrice(cbSprite.Text).ToString("0.00");
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
                // Log the error
                FileManage.LogError(ex);
            }
        }

        private void numericUpDown_Enter(object sender, EventArgs e)
        {
            try
            {
                Guna.UI2.WinForms.Guna2NumericUpDown nud = (Guna.UI2.WinForms.Guna2NumericUpDown)sender;
                if (nud.Enabled)
                {
                    nud.Text = "";
                    if (nud.Text != "")
                        nud.Value = Convert.ToDecimal(nud.Text);
                    else nud.Value = Convert.ToDecimal(0);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
                // Log the error
                FileManage.LogError(ex);
            }


        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double totalFoodAmount = 0, hotdogAmount = 0, gamburgerAmount = 0, colaAmount = 0, spriteAmount = 0;
                if (cbHotDog.Checked)
                {
                    if (nudHotDogCount.Text == string.Empty) nudHotDogCount.Value = 0;
                    hotdogAmount = CalculateFunctions.CalculateFoodPrice(miniCafe.GetFood("Hot-Dog"),
                        Convert.ToInt32(nudHotDogCount.Value));
                }
                if (cbGamburger.Checked)
                {
                    if (nudGamburgerCount.Text == string.Empty) nudGamburgerCount.Value = 0;
                    gamburgerAmount = CalculateFunctions.CalculateFoodPrice(miniCafe.GetFood("Gamburger"),
                        Convert.ToInt32(nudGamburgerCount.Value));
                }
                if (cbCocaCola.Checked)
                {
                    if (nudCocaColaCount.Text == string.Empty) nudCocaColaCount.Value = 0;
                    colaAmount = CalculateFunctions.CalculateFoodPrice(miniCafe.GetFood("Coca-Cola"),
                        Convert.ToInt32(nudCocaColaCount.Value));
                }
                if (cbSprite.Checked)
                {
                    if (nudSpriteCount.Text == string.Empty) nudSpriteCount.Value = 0;
                    spriteAmount = CalculateFunctions.CalculateFoodPrice(miniCafe.GetFood("Sprite"),
                        Convert.ToInt32(nudSpriteCount.Value));
                }
                totalFoodAmount = hotdogAmount + gamburgerAmount + colaAmount + spriteAmount;

                lblFoodAmount.Text = totalFoodAmount.ToString("0.00");
                lblTotalAmount.Text = (Convert.ToDouble(lblFuelAmount.Text) + Convert.ToDouble(lblFoodAmount.Text)).ToString("0.00");
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message
                MessageBox.Show($"Warning : {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearOrDefault();
                // Log the error
                FileManage.LogError(ex);
            }

        }

        private void numericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void ClearOrDefault()
        {
            cmbFuel.Focus();
            txtAzn.Text = "0,00";
            txtLiter.Text = "0,00";
            lblTotalAmount.Text = "0,00";
            lblFoodAmount.Text = "0,00";
            lblFuelAmount.Text = "0,00";
            rbLiter.Checked = true;
            rbAzn.Checked = false;
            cbHotDog.Checked = false;
            cbGamburger.Checked = false;
            cbCocaCola.Checked = false;
            cbSprite.Checked = false;
        }

        private void btnPayAmount_Click(object sender, EventArgs e)
        {
            if (lblTotalAmount.Text == "0,00")
            {
                MessageBox.Show("You haven't purchased anything yet, there is no amount to pay. Please choose the product you want to buy.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                productsName.Add(currentFuel.Name);
                productsCount.Add(txtLiter.Text);
                productsPrice.Add(txtAzn.Text);

                if (cbHotDog.Checked)
                {
                    AddProductToList("Hot-Dog");
                }
                if (cbGamburger.Checked)
                {
                    AddProductToList("Gamburger");
                }
                if (cbCocaCola.Checked)
                {
                    AddProductToList("Coca-Cola");
                }
                if (cbSprite.Checked)
                {
                    AddProductToList("Sprite");
                }

                Document doc = new Document();
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                DateTime currentDateTime = DateTime.Now;

               
                string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd_HH-mm-ss");

               
                string pdfName = "Purchase_Summary_" + formattedDateTime + ".pdf";
                string pdfFilePath = Path.Combine(desktopPath, pdfName);

                try
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));

                    // Create a custom class for adding a logo
                    LogoHandler logoEvent = new LogoHandler();
                    writer.PageEvent = logoEvent;

                    doc.Open();

                    // Add content to the PDF
                    // Add a title
                    // Add a head

                    Paragraph title = new Paragraph("B E S T    O I L");
                    title.Alignment = Element.ALIGN_CENTER;
                    title.Font.Size = 40f; // Increase the font size for the title

                    Paragraph head = new Paragraph("Purchase Summary");
                    head.Alignment = Element.ALIGN_CENTER;
                    head.Font.Size = 20f; // Increase the font size for the head

                    // Add purchase information
                    PdfPTable table = new PdfPTable(4); // Create a 4-column table
                    table.DefaultCell.Padding = 4; // Set cell padding
                    table.WidthPercentage = 100; // Set table width

                    // Add column headers
                    string[] columnHeaders = { "Product Name", "Price", "Quantity", "Total Amount" };
                    foreach (var header in columnHeaders)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = new BaseColor(192, 192, 192); // Add a gray background
                        table.AddCell(cell);
                    }

                    // Add product information
                    table.AddCell(productsName[0]);
                    table.AddCell(currentFuel.Price.ToString("0.00") + " AZN");
                    table.AddCell(productsCount[0] + " liters");
                    table.AddCell(productsPrice[0] + " AZN");
                    for (int i = 1; i < productsName.Count; i++)
                    {
                        var food = miniCafe.GetFood(productsName[i]);
                        table.AddCell(productsName[i]);
                        table.AddCell(food.Price.ToString("0.00") + " AZN");
                        table.AddCell(productsCount[i] + " pieces");
                        table.AddCell(productsPrice[i] + " AZN");
                    }

                    // Calculate and add the total amount
                    double totalAmount = Convert.ToDouble(lblTotalAmount.Text);
                    PdfPCell totalAmountCell = new PdfPCell(new Phrase("Total Amount"));
                    totalAmountCell.Colspan = 3;
                    table.AddCell(totalAmountCell);
                    table.AddCell(totalAmount.ToString("0.00") + " AZN");

                    // Add the title and table to the document

                    doc.Add(title);
                    doc.Add(new Paragraph("\n\n\n"));
                    doc.Add(head);
                    doc.Add(new Paragraph("\n\n"));
                    doc.Add(table);
                    doc.Add(new Paragraph("\n\n"));

                    // Close the document
                    doc.Close();

                    ClearProductFromList();
                    ClearOrDefault();
                    MessageBox.Show("PDF created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while creating the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FileManage.LogError(ex);
                }
            }
        }



        private void AddProductToList(string name)
        {
            var product = miniCafe.GetFood(name);
            productsName.Add(product.Name);
            if (product.Name == "Hot-Dog")
            {
                productsCount.Add(Convert.ToInt32(nudHotDogCount.Value).ToString());
                productsPrice.Add((Convert.ToInt32(nudHotDogCount.Value) * product.Price).ToString("0.00"));
            }
            else if (product.Name == "Gamburger")
            {
                productsCount.Add(Convert.ToInt32(nudGamburgerCount.Value).ToString());
                productsPrice.Add((Convert.ToInt32(nudGamburgerCount.Value) * product.Price).ToString("0.00"));
            }
            else if (product.Name == "Coca-Cola")
            {
                productsCount.Add(Convert.ToInt32(nudCocaColaCount.Value).ToString());
                productsPrice.Add((Convert.ToInt32(nudCocaColaCount.Value) * product.Price).ToString("0.00"));
            }
            else if (product.Name == "Sprite")
            {
                productsCount.Add(Convert.ToInt32(nudSpriteCount.Value).ToString());
                productsPrice.Add((Convert.ToInt32(nudSpriteCount.Value) * product.Price).ToString("0.00"));
            }


        }

        private void ClearProductFromList()
        {
            productsName.Clear();
            productsCount.Clear();
            productsPrice.Clear();
        }

    }
}
