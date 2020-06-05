using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {
           protected List<Point> pList;

            public virtual void Draw()
            {
                foreach (Point p in pList)
                {
                    p.Draw();
                }
            }
        }

    }
