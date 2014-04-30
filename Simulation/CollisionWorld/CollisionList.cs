using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollisionWorld
{
    public class CollisionList
    {
        public ArrayList collisions = new ArrayList();

        public int Count
        {
            get { return collisions.Count;}
        }

        public void Add(CollisionPair cp) 
        {
            collisions.Add(cp);
        }

        public CollisionPair get(int i)
        {
            return (CollisionPair)collisions[i];
        }
    }
}
