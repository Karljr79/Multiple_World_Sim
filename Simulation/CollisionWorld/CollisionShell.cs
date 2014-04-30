using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace CollisionWorld
{
    public class CollisionShell
    {
        public Vec2 position;
        public Object userData; //will be used in the future to help with encapsulation

        public CollisionShell(Vec2 pos, Object userData)
        {
            position = new Vec2(pos.x, pos.y);
            this.userData = userData;
        }

        public CollisionShell(Vec2 pos)
        {
            this.position = pos;
        }
    }
}
