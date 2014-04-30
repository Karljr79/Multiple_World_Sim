using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace PhysicsWorld
{
    public class PointMass : PhysicsObject
    {
        public float mass;
        public Vec2 vel;
        public Vec2 forceAccumulator = new Vec2();
        public object userData;

        public PointMass(float mass)
        {
            this.mass = mass;
            this.vel = new Vec2();
            pos = new Vec2();
        }

        public PointMass(float mass, Vec2 pos, Vec2 vel)
        {
            //parameterized constructor
            this.mass = mass;
            this.pos = pos;
            this.vel = vel;
        }

        public void AddForce(Vec2 f) //add the force vector to the current force
        {
            forceAccumulator += f;
        }

        public override void Step(float dt) //each timestep, do this.
        {
            Vec2 a = (1.0f/mass) * forceAccumulator;
            Vec2 v = a * dt + vel;
            pos = vel * dt + Pos;
            vel = v;
            forceAccumulator = new Vec2(); //zero out the force
        }

    }
}
