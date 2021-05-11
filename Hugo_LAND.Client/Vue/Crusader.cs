using Hugo_LAND.Client.HugoLandServices;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Hugo_LAND.Client
{
    public partial class HugoWorld : Form
    {
        private Stopwatch _timer = new Stopwatch();
        private double _lastTime;
        private long _frameCounter;
        private GameState _gameState;
        private WorldDetailsDTO _currentWorld;
        private HeroDetailsDTO currHero;
        private readonly WorldServiceClient wsc = new WorldServiceClient();
        private readonly HeroServiceClient hsc = new HeroServiceClient();
        bool buttonDisconnectPressed = false;

        public HugoWorld(HeroDetailsDTO hero)
        {
            //Setup the form
            //Startup the game state
            currHero = hero;
            _currentWorld = wsc.GetWorldByName(hero.World);
            if (_currentWorld != null)
            {
                InitializeComponent();
                SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
                _gameState = new GameState(ClientSize, hero);
                initialize();
            }
            else
            {
                MessageBox.Show("An error has occured while loading the map.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void initialize()
        {
            _gameState.Initialize();

            //Initialise and start the timer
            _lastTime = 0.0;
            _timer.Reset();
            _timer.Start();
            this.KeyPreview = true;
        }

        private void Crusader_Paint(object sender, PaintEventArgs e)
        {
            //Work out how long since we were last here in seconds
            double gameTime = _timer.ElapsedMilliseconds / 1000.0;
            double elapsedTime = gameTime - _lastTime;
            _lastTime = gameTime;
            _frameCounter++;


            //Perform any animation and updates
            _gameState.Update(gameTime, elapsedTime);


            //Draw everything
            _gameState.Draw(e.Graphics);


            if (!buttonDisconnectPressed)
            {
                //Force the next Paint()
                this.Invalidate();
            }
        }

        private void Crusader_KeyDown(object sender, KeyEventArgs e)
        {
            _gameState.KeyDown(e.KeyCode);
        }


        private void Crusader_Shown(object sender, EventArgs e)
        {
            Form help = new helpform();
            help.Show();
            help.Focus();
            btnDisconnect.Refresh(); //Fix bug white overlay on button
        }

        private void HugoWorld_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //This and the "this.KeyPreview = true;" fixes the problem
            //of arrow keys not detected!!
            e.IsInputKey = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HugoWorld_FormClosing(object sender, FormClosingEventArgs e)
        {
            buttonDisconnectPressed = true;
            DialogResult dr = MessageBox.Show("Are you sure you want to leave us?", "Disconnect", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                buttonDisconnectPressed = false;
                this.Invalidate(); //Draw form again
            }
            else
            {
                bool result = DisconnectUser();
                if (!result)
                {
                    e.Cancel = true;
                    buttonDisconnectPressed = false;
                    this.Invalidate(); //Draw form again
                }
            }
        }

        private bool DisconnectUser()
        {
            if (hsc.DisconnectHero(currHero.Id, false) == "SUCCESS")
                return true;
            else
            {
                MessageBox.Show("There was an error while trying to disconnect!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnDisconnect_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if bug button is selected
            e.IsInputKey = true;
        }

    }
}