using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace CollisionWorld
{
    public class CollisionWorld
    {
        ArrayList shellList = new ArrayList();

        public void Add(CollisionShell Shell)
        {
            shellList.Add(Shell);
        }
        public void Remove(CollisionShell Shell)
        {
            shellList.Remove(Shell);
        }

        //Only working for Circles at the moment
        public List<CollisionPair> GetCollisions()
        {
            List<CollisionPair> collisions = new List<CollisionPair>();
            for (int i = 0; i < shellList.Count; i++)
            {
                for (int j = i + 1; j < shellList.Count; j++)
                {
                    //will add to the list if there is a collision
                    collide(collisions, (CircleShell)shellList[i], (CircleShell)shellList[j]);
                }
            }

            return collisions;
        }

        protected bool collide(List<CollisionPair> collisions, CircleShell a, CircleShell b)
        {
            //for future use: will have conditionals here for the different shell types


            float collision = a.radius + b.radius;

            //calc current distance
            Vec2 distance = new Vec2((b.position.x - a.position.x), (b.position.y - a.position.y));

            //check if they overlap
            float overlap = collision - distance.GetMag();

            //if they overlap, create a new pair and add it to the list
            if (overlap <= collision && overlap >= 0.0f)
            {
                CollisionPair cpair = new CollisionPair(a, b, (distance * overlap));
                collisions.Add(cpair);
                return true;
            }

            else
            {
                return false;
            }
        }
        
    }
}
