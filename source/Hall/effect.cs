using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    namespace abilities
    {
        public class effect
        {
            private string name, actionname;
            private int effduration;
            private List<player> affectedplayers = new List<player>();

            public float duration
            {
                get
                {
                    return effduration / Program.framerate;
                }
                set
                {
                    effduration = (int)(value * Program.framerate);
                }
            }


            public virtual string apply(player p)
            {
                if (!affectedplayers.Contains(p))
                { affectedplayers.Add(p); }
                return actionname;
            }
        }
    }
}