using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace PhysicsWorld
{
    public class PhysicsWorld
    {
        ArrayList pobjects = new ArrayList();

        public void Add(PhysicsObject pobj)
        {
            pobjects.Add(pobj);
        }

        public void Delete(PhysicsObject pobj)
        {
            pobjects.Remove(pobj);
        }

        public void Step(float dt)
        {
            foreach (object o in pobjects)
            {

                PointMass pobj = (PointMass)o;
                pobj.AddForce(new Vec2(0, 9));
                pobj.Step(dt);
                //you could also do ((PhysicsObject)o).Step(dt);
            }

        }
    }
}
