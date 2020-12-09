using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShootingStar.Game;
using ShootingStar.Properties;

namespace ShootingStar
{
    public partial class GameForm : Form
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

        public GameForm()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            _buffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            _graphics = Graphics.FromImage(_buffer);
            _graphics.Clear(Color.Black);
            Invalidate();

            tickTimer.Start();

            _random = new Random();

            _player = new PlayerUnit(this)
            {
                MaxHp = 1,
                Speed = 10,
                FireRate = 5,
                UnitImage = Resources.fighter0,
            };
            _player.SetInitialPosition();
            _player.Reset();

            _playerBulletType = new PlayerBullet(this)
            {
                MaxHp = 1,
                Speed = 20,
                UnitImage = Resources.fighter_bullet,
            };

            var enemyA = Resources.enemy0_0;
            enemyA.RotateFlip(RotateFlipType.Rotate180FlipX);
            _enemyTypeA = new EnemyUnit(this)
            {
                EnemyType = 0,
                MaxHp = 2,
                Speed = 2,
                FireRate = 40,
                UnitImage = enemyA,
            };

            var enemyB = Resources.enemy1_0;
            enemyB.RotateFlip(RotateFlipType.Rotate180FlipX);
            _enemyTypeB = new EnemyUnit(this)
            {
                EnemyType = 1,
                MaxHp = 1,
                Speed = 4,
                FireRate = 80,
                UnitImage = enemyB,
            };

            var enemyC = Resources.enemy2_0;
            enemyC.RotateFlip(RotateFlipType.Rotate180FlipX);
            _enemyTypeC = new EnemyUnit(this)
            {
                EnemyType = 2,
                MaxHp = 1,
                Speed = 6,
                FireRate = 50,
                UnitImage = enemyC,
            };

            var enemyBulletImage = Resources.enemy_bullet;
            enemyBulletImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            _enemyBulletType = new EnemyBullet(this)
            {
                MaxHp = 1,
                Speed = 10,
                UnitImage = enemyBulletImage,
            };
        }

        private void MainGame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_buffer, 0, 0);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            _graphics.Clear(Color.Black);

            if (!_player.IsAlive)
            {
                tickTimer.Stop();
                MessageBox.Show("You dead!");
                MainForm.Instance.SetForm<MainMenuForm>();
            }

            if (_player.IsAlive)
            {
                // User Input
                var direction = 0;
                if (GetKeyState((int)Keys.Left) < 0)
                {
                    direction--;
                }
                if (GetKeyState((int)Keys.Right) < 0)
                {
                    direction++;
                }
                _player.SetDirection(direction);

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
                        newEnemy.Init(_enemyTypeA);
                        break;
                    case 1:
                        newEnemy.Init(_enemyTypeB);
                        break;
                    case 2:
                        newEnemy.Init(_enemyTypeC);
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
                newBullet.Init(_playerBulletType);
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
                        newBullet.Init(_enemyBulletType);
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
                unitBaseA.Position.X - (unitBaseA.UnitImage.Width / 2),
                unitBaseA.Position.Y - (unitBaseA.UnitImage.Height / 2),
                unitBaseA.UnitImage.Width,
                unitBaseA.UnitImage.Height);

            var unitBRect = new Rectangle(
                unitBaseB.Position.X - (unitBaseB.UnitImage.Width / 2),
                unitBaseB.Position.Y - (unitBaseB.UnitImage.Height / 2),
                unitBaseB.UnitImage.Width,
                unitBaseB.UnitImage.Height);

            var result = Rectangle.Intersect(unitARect, unitBRect);
            return !result.IsEmpty;
        }
    }
}
