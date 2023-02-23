namespace Adapter
{
    public partial class Form1 : Form
    {
        ToBicycle toBicycle = new ToBicycle(new Bicycle());
        ToBoat toBoat = new ToBoat(new Boat());
        ToBlob _toBlob= new ToBlob(new Giant_Slime());
        ToSkate _toSkate = new ToSkate(new Skate());
        Change_Transport Player = new Change_Transport();
        bool active = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (active) {label1.Text+= Player.UseTransport()+"\n"; }      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player.set_transport(toBicycle);
            label2.Text = Player.Get_info();
            active = true;
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.set_transport(_toSkate);
            label2.Text = Player.Get_info();
            active = true;
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.set_transport(toBoat);
            label2.Text = Player.Get_info();
            active = true;
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.set_transport(_toBlob);
            label2.Text = Player.Get_info();
            active = true;
            label1.Text = "";
        }
    }
}