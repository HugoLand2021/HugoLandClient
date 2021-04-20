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
        private readonly WorldServiceClient wsc = new WorldServiceClient();

        public HugoWorld(HeroDetailsDTO hero)
        {
            //Setup the form
            //Startup the game state
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


            //Force the next Paint()
            this.Invalidate();

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
        }
    }
}