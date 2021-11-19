using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinthLab
{
    class Checkpoint
    {
        public int MaskCount { get; set; } = 1;
        public int DesinfectCount { get; set; } = 10;

        public List<IVisitor> VisitorsWantToISIT { get; } = new List<IVisitor>();
        public List<IVisitor> VisitorsCanToISIT { get; } = new List<IVisitor>();

        public void Check()
        {
            List<IVisitor> passedVisitors = new List<IVisitor>();

            foreach (IVisitor vis in VisitorsWantToISIT)
            {

                if (vis is ICanDisenfectHand && vis is ICanPutOnMask && vis is ICanHaveQR)
                {
                    if (((ICanHaveQR)vis).IsHaveQR)
                    {
                        bool haveMask = ((ICanPutOnMask)vis).IsHaveMask;
                        if (DesinfectCount > 0 && haveMask)
                        {
                            passedVisitors.Add(vis);
                            DesinfectCount--;
                        }
                        else if (DesinfectCount > 0 && MaskCount > 0)
                        {
                            passedVisitors.Add(vis);
                            DesinfectCount--;
                            MaskCount--;
                        }
                    }

                }

            }

            VisitorsCanToISIT.AddRange(passedVisitors);
        }
    }
}
