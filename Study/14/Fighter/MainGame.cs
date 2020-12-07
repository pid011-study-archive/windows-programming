using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fighter
{
    public partial class MainGame : Form
    {
        [DllImport("User32.dll")]
        private static extern short GetKeyState(int nVirtualKey);

        private Bitmap _buffer;
        private Graphics _graphics;

        private PlayerUnit _player;
        private EnemyUnit _enemyTypeA;
        private EnemyUnit _enemyTypeB;
        private EnemyUnit _enemyTypeC;
        private PlayerBullet _playerBulletType;
        private EnemyBullet _enemyBulletType;

        private List<EnemyUnit> _enemies = new List<EnemyUnit>();
        private List<PlayerBullet> _playerBullets = new List<PlayerBullet>();
        private List<EnemyBullet> _enemyBullets = new List<EnemyBullet>();

        private Random _random;
        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, System.EventArgs e)
        {
            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            tickTimer.Start();

            _random = new Random();

            _player = new PlayerUnit(this)
            {
                MaxHp = 1,
                Speed = 10,
                FireRate = 10,
                UnitImage = Image.FromFile("resources/fighter.png")
            };
            _player.SetInitialPosition();
            _player.Reset();

            _playerBulletType = new PlayerBullet(this)
            {
                MaxHp = 1,
                Speed = 7,
                UnitImage = Image.FromFile("resources/fbullet.png")
            };

            _enemyTypeA = new EnemyUnit(this)
            {
                EnemyType = 0,
                MaxHp = 2,
                Speed = 2,
                FireRate = 40,
                UnitImage = Image.FromFile("resources/enemy1.png")
            };

            _enemyTypeB = new EnemyUnit(this)
            {
                EnemyType = 1,
                MaxHp = 1,
                Speed = 4,
                FireRate = 80,
                UnitImage = Image.FromFile("resources/enemy2.png")
            };

            _enemyTypeC = new EnemyUnit(this)
            {
                EnemyType = 2,
                MaxHp = 1,
                Speed = 6,
                FireRate = 50,
                UnitImage = Image.FromFile("resources/enemy3.png")
            };

            _enemyBulletType = new EnemyBullet(this)
            {
                MaxHp = 1,
                Speed = 5,
                UnitImage = Image.FromFile("resources/ebullet.png")
            };
        }

        private void MainGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_buffer, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void tickTimer_Tick(object sender, System.EventArgs e)
        {
            _graphics.Clear(Color.Black);

            if (_player.IsAlive)
            {
                // User Input
                _player.SetDirection(0);
                if (GetKeyState((int)Keys.Left) < 0)
                {
                    _player.SetDirection(-1);
                }
                if (GetKeyState((int)Keys.Right) < 0)
                {
                    _player.SetDirection(1);
                }
                if (GetKeyState((int)Keys.Space) < 0)
                {
                    SpawnPlayerBullet();
                }

                // Update player
                _player.Update();

                // Spawn enemies
                SpawnEnemy();
                SpawnEnemyBullets();
            }

            // Update enemies
            foreach (var enemy in _enemies)
            {
                enemy.Update();
            }

            // Update player bullets
            foreach (var bullet in _playerBullets)
            {
                bullet.Update();
            }

            // Update enemies bullets
            foreach (var bullet in _enemyBullets)
            {
                bullet.Update();
            }

            if (_player.IsAlive)
            {
                DetectPlayerBulletCollision();
                DetectEnemyBulletCollision();
            }

            _enemies = _enemies.Where(x => x.IsAlive).ToList();
            _playerBullets = _playerBullets.Where(x => x.IsAlive).ToList();
            _enemyBullets = _enemyBullets.Where(x => x.IsAlive).ToList();

            // Draw player
            if (_player.IsAlive)
            {
                _player.Draw(_graphics);
            }

            // Draw enemies
            foreach (var enemy in _enemies)
            {
                enemy.Draw(_graphics);
            }

            // Draw player bullets
            foreach (var bullet in _playerBullets)
            {
                bullet.Draw(_graphics);
            }

            // Draw enemies bullets
            foreach (var bullet in _enemyBullets)
            {
                bullet.Draw(_graphics);
            }

            Invalidate();
        }

        private void SpawnEnemy()
        {
            if (_enemies.Count < 10)
            {
                var newEnemy = new EnemyUnit(this);
                var enemyType = _random.Next(3);
                switch (enemyType)
                {
                    case 0:
                        newEnemy.CopyFrom(_enemyTypeA);
                        break;
                    case 1:
                        newEnemy.CopyFrom(_enemyTypeB);
                        break;
                    case 2:
                        newEnemy.CopyFrom(_enemyTypeC);
                        break;
                    default:
                        break;
                }
                newEnemy.Reset();
                newEnemy.SetInitialPosition(enemyType);
                _enemies.Add(newEnemy);
            }
        }

        private void SpawnPlayerBullet()
        {
            if (_player.Tick > _player.FireRate)
            {
                var newBullet = new PlayerBullet(this);
                newBullet.CopyFrom(_enemyBulletType);
                newBullet.Reset();
                newBullet.SetInitialPosition(_player);
                _playerBullets.Add(newBullet);
                _player.Tick = 0;
            }
        }

        private void SpawnEnemyBullets()
        {
            foreach (var enemy in _enemies)
            {
                if (enemy.Tick > enemy.FireRate)
                {
                    if (_random.Next(100) < 10)
                    {
                        var newBullet = new EnemyBullet(this);
                        newBullet.CopyFrom(_playerBulletType);
                        newBullet.Reset();
                        newBullet.SetInitialPosition(enemy);
                        _enemyBullets.Add(newBullet);
                        enemy.Tick = 0;
                    }
                }
            }
        }

        private void DetectPlayerBulletCollision()
        {
            foreach (var bullet in _playerBullets)
            {
                foreach (var enemy in _enemies)
                {
                    if (DetectCollision(bullet, enemy))
                    {
                        bullet.IsAlive = false;
                        enemy.Hp--;
                        if (enemy.Hp <= 0)
                        {
                            enemy.IsAlive = false;
                        }
                    }
                }
            }
        }

        private void DetectEnemyBulletCollision()
        {
            foreach (var bullet in _enemyBullets)
            {
                if (DetectCollision(bullet, _player))
                {
                    bullet.IsAlive = false;
                    _player.Hp--;
                    if (_player.Hp <= 0)
                    {
                        _player.IsAlive = false;
                    }
                }
            }
        }

        private bool DetectCollision(UnitBase unitBaseA, UnitBase unitBaseB)
        {
            var unitARect = new Rectangle(
                unitBaseA.XPos - (unitBaseA.UnitImage.Width / 2),
                unitBaseA.YPos - (unitBaseA.UnitImage.Height / 2),
                unitBaseA.UnitImage.Width,
                unitBaseA.UnitImage.Height);

            var unitBRect = new Rectangle(
                unitBaseB.XPos - (unitBaseB.UnitImage.Width / 2),
                unitBaseB.YPos - (unitBaseB.UnitImage.Height / 2),
                unitBaseB.UnitImage.Width,
                unitBaseB.UnitImage.Height);

            var result = Rectangle.Intersect(unitARect, unitBRect);
            return !result.IsEmpty;
        }
    }
}
