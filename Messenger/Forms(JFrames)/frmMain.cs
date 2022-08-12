using MaterialSkin;
using MaterialSkin.Controls;

namespace Messenger
{
    
    
    public partial class frmMain : MaterialForm
    {
        private static frmMain _instance;

        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }
        public frmMain()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }
        public Panel Content
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            _instance = this;
             mainPanel.Controls.Add(new UserControl1() { Dock = DockStyle.Fill});
             //mainPanel.Controls.Add(new RegisterFrame() { Dock = DockStyle.Fill });  

        }
    }
}