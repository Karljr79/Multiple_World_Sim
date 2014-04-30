using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GraphicsWorld;
using PhysicsWorld;
using Utilities;
using CollisionWorld;

namespace EntityWorld
{
    public class EWorld
    {
        GraphicsWorld.GraphicsWorld gworld;
        PhysicsWorld.PhysicsWorld pworld;
        CollisionWorld.CollisionWorld cworld;

        ArrayList entities = new ArrayList();

        public EWorld(GraphicsWorld.GraphicsWorld graphicsworld, PhysicsWorld.PhysicsWorld physicsworld, CollisionWorld.CollisionWorld collisionworld)
        {
            this.gworld = graphicsworld;
            this.pworld = physicsworld;
            this.cworld = collisionworld;
        }

        public PhysicsWorld.PhysicsWorld Pworld
        {
            get { return pworld; }
            set { pworld = value; }
        }

        public GraphicsWorld.GraphicsWorld Gworld
        {
            get { return gworld; }
            set { gworld = value; }
        }

        public CollisionWorld.CollisionWorld Cworld
        {
            get { return cworld; }
            set { cworld = value; }
        }

        public void Add(Entity entity)
        {
            entities.Add(entity);
        }

        public void Delete(Entity entity)
        {
            entities.Remove(entity);
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void Step(float dt)
        {
            List<CollisionWorld.CollisionPair> collisions = cworld.GetCollisions();
            GenerateCollisionForces(collisions);

            pworld.Step(dt);

            foreach (Entity o in entities)
            {
                o.UpdateCollisionShell();
                o.UpdateGraphics();

            }
        }

        public void GenerateCollisionForces(List<CollisionPair> collisions)
        {
            foreach (CollisionPair pair in collisions)
            {
                CollisionShell obj1 = pair.a;
                CollisionShell obj2 = pair.b;

                Entity ent1 = (obj1.userData as Entity);
                Entity ent2 = (obj2.userData as Entity);

                Vec2 force1 = pair.userData * ent2.pm.mass * -1;
                Vec2 force2 = pair.userData * ent1.pm.mass * 1;

                ent1.pm.AddForce(force1);
                ent2.pm.AddForce(force2);
            }
        }

        public void Render(Graphics g)
        {
            this.gworld.drawAll(g);
        }
    }
}
