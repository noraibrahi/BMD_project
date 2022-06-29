using System.Data;
using MySql.Data.MySqlClient;
using Doctor_View.models;

namespace TBD
{
    public partial class add_apatient_record : Form
    {
        public add_apatient_record()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("DataSource=localhost;database=TBD4;uid=root;pwd=123456789");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Doctor f6 = new Add_Doctor();
            f6.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_patient f3 = new add_patient();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_appointment f4 = new add_appointment();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionest_view f2 = new receptionest_view();
            f2.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_apatient_record_Load(object sender, EventArgs e)
        {

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            PATIENT Patient = new PATIENT();
            Patient.F_NAME = F_NAME.Text;
            Patient.PATIENT_PHONE = PATIENT_PHONE.Text;
            Patient.PATIENT_EMAIL = PATIENT_EMAIL.Text;
            Patient.BLOOD_TYPE = BLOOD_TYPE.Text;
            Patient.PATIENT_CURRENT_ILLNESS = PATIENT_CURRENT_ILLNESS.Text;
            Patient.NationalID = NATIONALID.Text;
            Patient.PATIENT_ADDRES = ADRESS.Text;
            Patient.HISTROY_OF_ILLNESS = HISTROY_OF_ILLNESS.Text;
            Patient.gender = gender.Text;
            Patient.EMERGANCY_NUMBER = EMERGANCY_NUMBER.Text;
            Patient.PATIENT_ADDRES_COUNTRY = PATIENT_ADDRES_COUNTRY.Text;
            Patient.PATIENT_ADDRES_STATE = PATIENT_ADDRES_STATE.Text;
            Patient.PATIENT_ADDRES_CITY = PATIENT_ADDRES_CITY.Text;
            Patient.PATIENT_ADDRES_STREET = PATIENT_ADDRES_STREET.Text;


            MySqlConnection conn = new MySqlConnection("server=localhost;database=TBD5;uid=root;pwd=123456789");
            MySqlCommand comd = null;

            conn.Open();

            string comdString = "Insert into PATIENT (F_NAME, PATIENT_PHONE, PATIENT_EMAIL," +
                    " BLOOD_TYPE, PATIENT_CURRENT_ILLNESS, NationalID, " +
                    "HISTROY_OF_ILLNESS , gender, EMERGANCY_NUMBER,PATIENT_ADDRES_COUNTRY, " +
                    "PATIENT_ADDRES_STATE , PATIENT_ADDRES_CITY,  PATIENT_ADDRES_STREET) VALUES(@param1, @param2 , " +
                    "@param22 ,@param3, @param4 , @param5 , @param7  , @param8 , @param9, " +
                    "@param10 , @param11  , @param12 , @param13 );";
            comd = new MySqlCommand(comdString, conn);

            comd.Parameters.Add("@param1", MySqlDbType.VarChar);
            comd.Parameters["@param1"].Value = Patient.F_NAME.ToString();
            comd.Parameters.Add("@param2", MySqlDbType.VarChar);
            comd.Parameters["@param2"].Value = Patient.PATIENT_PHONE.ToString();
            comd.Parameters.Add("@param22", MySqlDbType.VarChar);
            comd.Parameters["@param22"].Value = Patient.PATIENT_EMAIL.ToString();
            comd.Parameters.Add("@param3", MySqlDbType.VarChar);
            comd.Parameters["@param3"].Value = Patient.BLOOD_TYPE.ToString();
            comd.Parameters.Add("@param4", MySqlDbType.VarChar);
            comd.Parameters["@param4"].Value = Patient.PATIENT_CURRENT_ILLNESS.ToString();
            comd.Parameters.Add("@param5", MySqlDbType.VarChar);
            comd.Parameters["@param5"].Value = Patient.NationalID.ToString();
            //comd.Parameters.Add("@param6", MySqlDbType.VarChar);
            //comd.Parameters["@param6"].Value = Patient.address.ToString();
            comd.Parameters.Add("@param7", MySqlDbType.VarChar);
            comd.Parameters["@param7"].Value = Patient.HISTROY_OF_ILLNESS.ToString();
            comd.Parameters.Add("@param8", MySqlDbType.VarChar);
            comd.Parameters["@param8"].Value = Patient.gender.ToString();
            comd.Parameters.Add("@param9", MySqlDbType.VarChar);
            comd.Parameters["@param9"].Value = Patient.EMERGANCY_NUMBER.ToString();
            comd.Parameters.Add("@param10", MySqlDbType.VarChar);
            comd.Parameters["@param10"].Value = Patient.PATIENT_ADDRES_COUNTRY.ToString();
            comd.Parameters.Add("@param11", MySqlDbType.VarChar);
            comd.Parameters["@param11"].Value = Patient.PATIENT_ADDRES_STATE.ToString();
            comd.Parameters.Add("@param12", MySqlDbType.VarChar);
            comd.Parameters["@param12"].Value = Patient.PATIENT_ADDRES_CITY.ToString();
            comd.Parameters.Add("@param13", MySqlDbType.VarChar);
            comd.Parameters["@param13"].Value = Patient.PATIENT_ADDRES_STREET.ToString();
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.InsertCommand = comd;
            adp.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("Data Stored Successfully");
        }
    }
}
