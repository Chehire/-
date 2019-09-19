using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace DryCleaning
{
    public partial class MainForm : Form
    {
        DatabaseConnection database = new DatabaseConnection();
        public MainForm()
        {
            InitializeComponent();//Добавление иконки приложения
            Icon iconForm = new Icon(Application.StartupPath + "\\img\\DryCleaning.ico");
            Icon = iconForm;
            this.Text = "Dry Cleaning";
            DataGridLocation();
            Dolj();
            lblSearch.Text = "Поиск";
            dataGridView1.RowHeadersVisible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            DataGridLocation();
        }

        private void DataGridLocation()
        {
            dataGridView1.Top = 50;
            dataGridView1.Left = 12;
            dataGridView1.Width = ClientSize.Width - 22;
            dataGridView1.Height = ClientSize.Height - 60;
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SigOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
        }


        private void Dolj()
        {
            if (Program.ID_Dolj == 2) //Администратор
            {
                Restriction();
            }
            if (Program.ID_Dolj == 1) //Генеральный директор
            {
                Restriction();
            }
            if (Program.ID_Dolj == 3) //Главный бухгалтер
            {
                Restriction();
            }
            if (Program.ID_Dolj == 4) //Кассир
            {
                Restriction();
                doljToolStripMenuItem.Visible = false;
                employeeListToolStripMenuItem.Visible = false;
                companyToolStripMenuItem.Visible = false;
                licenziaToolStripMenuItem.Visible = false;
                cardToolStripMenuItem.Visible = false;
                licenziatToolStripMenuItem.Visible = false;
                licdocToolStripMenuItem.Visible = false;

            }
            if (Program.ID_Dolj == 5) //Работник С НМА
            {
                Restriction();
                doljToolStripMenuItem.Visible = false;
                employeeListToolStripMenuItem.Visible = false;
                serviceToolStripMenuItem.Visible = false;
                clientToolStripMenuItem.Visible = false;
                checkToolStripMenuItem.Visible = false;

            }
            if (Program.ID_Dolj == 6) //Кадровик
            {
                Restriction();
                serviceToolStripMenuItem.Visible = false;
                clientToolStripMenuItem.Visible = false;
                checkToolStripMenuItem.Visible = false;
                companyToolStripMenuItem.Visible = false;
                licenziaToolStripMenuItem.Visible = false;
                cardToolStripMenuItem.Visible = false;
                licenziatToolStripMenuItem.Visible = false;
                licdocToolStripMenuItem.Visible = false;
            }
        }

        private void Restriction()
        {
            doljToolStripMenuItem.Visible = true;
            employeeListToolStripMenuItem.Visible = true;
            clientToolStripMenuItem.Visible = true;
            serviceToolStripMenuItem.Visible = true;
            checkToolStripMenuItem.Visible = true;
            companyToolStripMenuItem.Visible = true;
            cardToolStripMenuItem.Visible = true;
            licenziatToolStripMenuItem.Visible = true;
            licenziaToolStripMenuItem.Visible = true;   
            licdocToolStripMenuItem.Visible = true;
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.Text == "DryCleaning")
            {
                AddToolStripMenuItem.Visible = false;
            }
            else
            {
                AddToolStripMenuItem.Visible = true;
            }
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right)) //Выделение всей строки ПКМ
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void EmployeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFillEmployeeList();
        }

        private void DetailsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicDoc();
        }

        private void DoljToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDolj();
        }

        private void CardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCard();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClient();
        }

        private void ServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowService();
        }

        private void CompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCompany();
        }

        private void LicenziatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenziat();
        }

        private void LicenziaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenzia();
        }

        private void licdocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicDoc();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCheck();
        }

        private void ShowFillEmployeeList()
        {
            try
            {
                this.Text = "DryCleaning | Список сотрудников";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect) 
                {
                   dataGridView1.DataSource = database.TableFill("select * from View_Sotr", sqlConnect).Tables[0];
                }
            }
            catch { }

        }

        private void ShowCheck()
        {
            try
            {
                this.Text = "DryCleaning | Чеки";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("Select * from View_Check", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowDolj()
        {
            try
            {
                this.Text = "DryCleaning | Должности";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select [ID_Dolj] as 'ID' ,[Dolj] as 'Название дожности', [Oklad] as 'Оклад' from [dbo].[Dolj]", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowService()
        {
            try
            {
                this.Text = "DryCleaning | Прейскурант";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select [ID_Service] as 'ID' ,[Service_Name] as 'Услуга', [Price] as 'Цена'from [dbo].[Price_List]", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowCard()
        {
            try
            {
                this.Text = "DryCleaning | Карты учета НМА";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select *  from [dbo].[View_Card]", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowCompany()
        {
            try
            {
                this.Text = "DryCleaning | Организация";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select ID_Organization as 'ID' ,Name as 'Название компании',Full_Name as 'Полное название'," +
                        "Adres_Rigisrt as 'Адрес регистрации',Fact_Adres as 'Фактический адрес', INN as 'ИНН', " +
                        "Nomer_Organization as 'Номер',e_mail as 'e-mail' from Organization", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowClient()
        {
            try
            {
                this.Text = "DryCleaning | Клиенты";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select ID_Client as 'ID' ,Fam_Client as 'Фамилия', Name_Client as 'Имя', Otch_Client as 'Отчество',Nomer_Client as 'Моб. номер'  from [dbo].[Client]", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowLicenziat()
        {
            try
            {
                this.Text = "DryCleaning | Лицензиаты";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select [ID_Licenziat] as [ID], [INN_Licenziat] as [ИНН]," +
                    "[Fam_Licenziat] as [Фамилия],[Name_Licenziat]as [Имя], [Otch_Licenziat] as [Отчество], [Adres_Licenziat] as [Адрес]," +
                    " [Fact_Adres] as [Фактический адрес], [Nomer_Licenziat] as [Моб. номер], [e_mail_Licenziat] as [E-mail] from [dbo].[Licenziat]", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowLicenzia()
        {
            try
            {
                this.Text = "DryCleaning | Лицензии";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select [ID_Licenzia] as 'ID' ,[Licenzia_Name] as 'Название лицензии' from [dbo].[Licenzii]", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void ShowLicDoc()
        {
            try
            {
                this.Text = "DryCleaning | Лицензионные договора";
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    dataGridView1.DataSource = database.TableFill("select * from [dbo].[View_LicDoc]", sqlConnect).Tables[0];
                }
            }
            catch { }
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddConMenuStripButton();
        }

        private void AddConMenuStripButton()
        {
            try
            {
                if (this.Text == "DryCleaning | Чеки")
                {
                    CheckForm Check = new CheckForm();
                    Check.btnUpdate.Enabled = false;
                    Check.btnDelete.Enabled = false;
                    Check.ShowDialog();

                }
                if (this.Text == "DryCleaning | Должности")
                {
                    DoljForm Dolj = new DoljForm();
                    Dolj.btnUpdate.Enabled=false;
                    Dolj.btnDelete.Enabled = false;
                    Dolj.ShowDialog();
                }
                if (this.Text == "DryCleaning | Прейскурант")
                {
                    PriceListForm PriceList = new PriceListForm();
                    PriceList.btnUpdate.Enabled = false;
                    PriceList.btnDelete.Enabled = false;
                    PriceList.ShowDialog();
                }
                if (this.Text == "DryCleaning | Список сотрудников")
                {
                    SigUpForm Employee = new SigUpForm();
                    Employee.btnUpdate.Enabled = false;
                    Employee.btnDelete.Enabled = false;
                    Employee.ShowDialog();
                }
                if (this.Text == "DryCleaning | Карты учета НМА")
                {
                    CardForm Card = new CardForm();
                    Card.btnUpdate.Enabled = false;
                    Card.btnDelete.Enabled = false;
                    Card.ShowDialog();
                }
                if (this.Text == "DryCleaning | Организация")
                {
                    CompanyForm company = new CompanyForm();
                    company.btnUpdate.Enabled = false;
                    company.btnDelete.Enabled = false;
                    company.ShowDialog();
                }
                if (this.Text == "DryCleaning | Клиенты")
                {
                    ClientForm Client = new ClientForm();
                    Client.btnUpdate.Enabled = false;
                    Client.btnDelete.Enabled = false;
                    Client.ShowDialog();
                }
                if (this.Text == "DryCleaning | Лицензиаты")
                {
                    LicenziatForm Licenziat = new LicenziatForm();
                    Licenziat.btnUpdate.Enabled = false;
                    Licenziat.btnDelete.Enabled = false;
                    Licenziat.ShowDialog();
                }
                if (this.Text == "DryCleaning | Лицензии")
                {
                    LicenziaForm Licenzia = new LicenziaForm();
                    Licenzia.btnUpdate.Enabled = false;
                    Licenzia.btnDelete.Enabled = false;
                    Licenzia.ShowDialog();
                }
                if (this.Text == "DryCleaning | Лицензионные договора")
                {
                    LicDocForm LicDoc = new LicDocForm();
                    LicDoc.btnUpdate.Enabled = false;
                    LicDoc.btnDelete.Enabled = false;
                    LicDoc.ShowDialog();
                }
            }
            catch { }
        }

        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeConMenuStripButton();
        }

        private void ChangeConMenuStripButton()
        {
            try
            {
                if (this.Text == "DryCleaning | Должности")
                {
                    DoljForm position = new DoljForm();
                    Program.ID_Position = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    position.tbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    position.tbOklad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    position.btnAdd.Enabled = false;
                    position.ShowDialog();
                }
                if (this.Text == "DryCleaning | Прейскурант")
                {
                    PriceListForm PriceList = new PriceListForm();
                    Program.ID_Service = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    PriceList.tbNameService.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    PriceList.tbPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    PriceList.btnAdd.Enabled = false;
                    PriceList.ShowDialog();
                }
                if (this.Text == "DryCleaning | Список сотрудников")
                {
                    SigUpForm Employee = new SigUpForm();
                    Program.ID_Sotr = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    Employee.tbFam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Employee.tbName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    Employee.tbOtch.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Employee.mtbSer.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    Employee.mtbNum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    Employee.cbDolj.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    Employee.dtpNaim.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value);
                    Employee.mtbYvol.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    Employee.btnAdd.Enabled = false;
                    Employee.ShowDialog();
                }
                try
                {
                    if (this.Text == "DryCleaning | Чеки")
                    {
                        CheckForm Check = new CheckForm();
                        Program.ID_Check = (int)dataGridView1.CurrentRow.Cells[0].Value;
                        Check.cbFIOKas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        Check.cbService.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        Check.nudKolichecstvo.Value = (int)dataGridView1.CurrentRow.Cells[4].Value;
                        Check.tbSum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        Check.cbFIOCln.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        Check.btnAdd.Enabled = false;
                        Check.ShowDialog();
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (this.Text == "DryCleaning | Карты учета НМА")
                {
                    CardForm Card = new CardForm();
                    Program.ID_Card = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    Card.cbLicenzia.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Card.cbOrganization.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    Card.tbCena.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Card.mtbDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    Card.btnAdd.Enabled = false;
                    Card.ShowDialog();
                }
                if (this.Text == "DryCleaning | Организация")
                {
                    CompanyForm company = new CompanyForm();
                    Program.ID_Company = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    company.tbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    company.tbFullName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    company.tbAdresRegs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    company.tbAdresFact.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    company.mtbINN.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    company.mtbNum.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    company.tbEmail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    company.btnAdd.Enabled = false;
                    company.Show();

                }
                if (this.Text == "DryCleaning | Клиенты")
                {
                    ClientForm Client= new ClientForm();
                    Program.ID_Client = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    Client.tbFam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Client.tbName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    Client.tbOtch.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Client.mtbNum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    Client.btnAdd.Enabled = false;
                    Client.ShowDialog();
                }
                if (this.Text == "DryCleaning | Лицензиаты")
                {
                    LicenziatForm Licenziat = new LicenziatForm();
                    Program.ID_Licenziat = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    Licenziat.btnAdd.Enabled = false;
                    Licenziat.mtbINN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Licenziat.tbFam.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    Licenziat.tbName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Licenziat.tbOtch.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    Licenziat.tbAdresRegs.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    Licenziat.tbAdresFact.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    Licenziat.mtbNum.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    Licenziat.tbEmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    Licenziat.ShowDialog();
                }
                if (this.Text == "DryCleaning | Лицензии")
                {
                    LicenziaForm Licenzia = new LicenziaForm();
                    Program.ID_Licenzia = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    Licenzia.tbLicenzia.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    Licenzia.btnAdd.Enabled = false;
                    Licenzia.ShowDialog();
                }
                if (this.Text == "DryCleaning | Лицензионные договора")
                {
                    LicDocForm licDoc = new LicDocForm();
                    licDoc.btnAdd.Enabled = false;
                    licDoc.ShowDialog();
                }
            }
            catch { }

        }



        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    switch (this.Text)
                    {
                        case "DryCleaning | Чеки":
                           dataGridView1.DataSource = database.TableFill($"select * from [dbo].[View_Check] where [Клиент]  like  '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Должности":
                            dataGridView1.DataSource = database.TableFill($"select [ID_Dolj], [Dolj], [Oklad] from [dbo].[Dolj] where [Dolj] like '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Прейскурант":
                            dataGridView1.DataSource = database.TableFill($"select [ID_Service], [Service_Name],[Price] from [dbo].[Price_List] where [Service_Name] like  '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Карты учета НМА":
                            dataGridView1.DataSource = database.TableFill($"select * from [dbo].[View_Card] where [Лицензия] like '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Организация":
                            dataGridView1.DataSource = database.TableFill($"select [ID_Organization] as 'ID' ,Name as 'Название компании',Full_Name as 'Полное название',Adres_Rigisrt as 'Адрес регистрации',Fact_Adres as 'Фактический адрес', INN as 'ИНН', Nomer_Organization as 'Номер',e_mail as 'e-mail' from Organization where Full_Name like '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Клиенты":
                            dataGridView1.DataSource = database.TableFill($"select [ID_Client],[Fam_Client],[Name_Client],[Otch_Client],[Nomer_Client] from [dbo].[Client] where [Fam_Client]+' '+[Name_Client]+' '+[Otch_Client] like '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Лицензиаты":
                            dataGridView1.DataSource = database.TableFill($"select [ID_Licenziat] as [ID], [INN_Licenziat] as [ИНН],[Fam_Licenziat] as [Фамилия],[Name_Licenziat]as [Имя], [Otch_Licenziat] as [Отчество], [Adres_Licenziat] as [Адрес],[Fact_Adres] as [Фактический адрес], [Nomer_Licenziat] as [Моб. номер], [e_mail_Licenziat] as [E-mail] from [dbo].[Licenziat] where [Fam_Licenziat]+' '+[Name_Licenziat]+' '+[Otch_Licenziat] like '%{tbSearch.Text}%' ", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Лицензии":
                            dataGridView1.DataSource = database.TableFill($"select [ID_Licenzia] as 'ID' ,[Licenzia_Name] as 'Название лицензии' from [dbo].[Licenzii] where [Licenzia_Name] like '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Список сотрудников":
                            dataGridView1.DataSource = database.TableFill($"select * from [dbo].[View_Sotr] where [Фамилия]+' '+[Имя]+' '+[Отчество] like '%{tbSearch.Text}%'", sqlConnect).Tables[0];
                            break;
                        case "DryCleaning | Лицензионные договора":
                            //
                            break;
                    }
                }
            }
            catch { }
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ExportExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void AllBorders(Excel.Borders _borders)
        {
            _borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            _borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            _borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            _borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            _borders.Color = Color.Black;
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlConnect = database.DatabaseSQL();
                using (sqlConnect)
                {
                    switch (this.Text)
                    {
                        case "DryCleaning | Чеки":
                            ShowCheck();
                            break;
                        case "DryCleaning | Должности":
                            ShowDolj();
                            break;
                        case "DryCleaning | Прейскурант":
                            ShowService();
                            break;
                        case "DryCleaning | Карты учета НМА":
                            ShowCard();
                            break;
                        case "DryCleaning | Организация":
                            ShowCompany();
                            break;
                        case "DryCleaning | Клиенты":
                            ShowClient();
                            break;
                        case "DryCleaning | Лицензиаты":
                            ShowLicenziat();
                            break;
                        case "DryCleaning | Лицензии":
                            ShowLicenzia();
                            break;
                        case "DryCleaning | Список сотрудников":
                            ShowFillEmployeeList();
                            break;
                        case "DryCleaning | Лицензионные договора":
                            ShowLicDoc();
                            break;
                    }
                }
            }
            catch { }
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet1;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[2, 1];


                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xlWorkSheet1.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    xlWorkSheet.Columns[i].ColumnWidth = 18;
                    for (int j = 1; j < dataGridView1.Rows.Count + 1; j++)
                    {
                        AllBorders(xlWorkSheet.Cells[j, i].Borders);
                        xlWorkSheet.Cells[j, i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                }
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
            catch { }
        }

        private void WordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd =  new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";


            switch (this.Text)
            {
                case "DryCleaning | Чеки":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список чеков");
                    }
                    break;
                case "DryCleaning | Должности":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список должностей");
                    }
                    break;
                case "DryCleaning | Прейскурант":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список услуг");
                    }
                    break;
                case "DryCleaning | Карты учета НМА":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список карт учета НМА");
                    }
                    break;
                case "DryCleaning | Организация":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список компаний");
                    }
                    break;
                case "DryCleaning | Клиенты":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список клиентов");
                    }
                    break;
                case "DryCleaning | Лицензиаты":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список лицензиатов");
                    }
                    break;
                case "DryCleaning | Лицензии":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список лицензий");
                    }
                    break;
                case "DryCleaning | Список сотрудников":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список сотрудников");
                    }
                    break;
                case "DryCleaning | Лицензионные договора":
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Export_Data_To_Word(dataGridView1, sfd.FileName, "Список лицензионных договоров");
                    }
                    break;
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename, string headerTable)
        {
            try
            {
                if (DGV.Rows.Count != 0)
                {
                    int RowCount = DGV.Rows.Count;
                    int ColumnCount = DGV.Columns.Count;
                    Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                    //add rows
                    int r = 0;
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        for (r = 0; r <= RowCount - 1; r++)
                        {
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                        } //end row loop
                    } //end column loop

                    Word.Document oDoc = new Word.Document();
                    oDoc.Application.Visible = true;

                    //page orintation
                    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                    dynamic oRange = oDoc.Content.Application.Selection.Range;
                    string oTemp = "";
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {
                            oTemp = oTemp + DataArray[r, c] + "\t";

                        }
                    }

                    //table format
                    oRange.Text = oTemp;

                    object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                    object ApplyBorders = true;
                    object AutoFit = true;
                    object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                    oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                          Type.Missing, Type.Missing, ref ApplyBorders,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                    oRange.Select();

                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    //header row style
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //add header row manually
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                    }

                    //table style 
                    oDoc.Application.Selection.Tables[1].set_Style("Классическая таблица 1");
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    //header text
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = headerTable;
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                    //save the file
                    oDoc.SaveAs2(filename);

                    //NASSIM LOUCHANI
                }
            }
            catch { }

        }

        private async void PDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            PdfClass pdfClass = new PdfClass();
            await Task.Run(() => pdfClass.ExportWordToPdf(fileDialog.FileName));

        }

    }
}

