using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using PhysicsWorld;
using GraphicsWorld;
using CollisionWorld;

namespace EntityWorld
{
    public partial class Form1 : Form
    {
        EntityWorld.EWorld eworld;
        GraphicsWorld.GraphicsWorld gworld;
        CollisionWorld.CollisionWorld cworld;
        PhysicsWorld.PhysicsWorld pworld;

        int tick = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            gworld = new GraphicsWorld.GraphicsWorld();
            pworld = new PhysicsWorld.PhysicsWorld();
            cworld = new CollisionWorld.CollisionWorld();

            eworld = new EWorld(gworld, pworld, cworld);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            eworld.Render(g);
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            eworld.Step(1);
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Entity ent1, ent2, ent3, ent4;

            eworld.Step(.10f);
            this.tick++;
            if ((tick % 20) == 0)
            {
                ent1 = new Circle(eworld, new Vec2(100, 100), new Vec2(25, -25), 12, 1.2f, Color.Blue);
                eworld.Add(ent1);
                ent2 = new Circle(eworld, new Vec2(300, 200), new Vec2(-10, -25), 15, 2, Color.Green);
                eworld.Add(ent2);
                ent3 = new Circle(eworld, new Vec2(100, 300), new Vec2(55, -85), 10, 0.8f, Color.Red);
                eworld.Add(ent3);
                ent4 = new Circle(eworld, new Vec2(200, 100), new Vec2(-15, -15), 16, 2.1f, Color.Purple);
                eworld.Add(ent4);
            }
            this.Refresh();
        }
    }
}
