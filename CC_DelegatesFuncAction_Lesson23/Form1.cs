namespace CC_DelegatesFuncAction_Lesson23
{

    public partial class Form1 : Form
    {
        public string MyFormName;
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnShwMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello from win form");
        }


    }
}