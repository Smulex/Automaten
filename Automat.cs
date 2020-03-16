using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Automat
    {
        private int faxeKondiCount = 0;
        private int pepsiMaxCount = 0;
        private int fantaOrangeCount = 0;
        public Snack[] faxeKondi = new Snack[10];
        public Snack[] pepsiMax = new Snack[10];
        public Snack[] fantaOrange = new Snack[10];

        public Snack[] FillFaxeKondi()
        {
            faxeKondiCount = 0;

            for (int i = 0; i < faxeKondi.Length; i++)
            {
                faxeKondi[i] = new Snack("Faxe Kondi", 10);
            }
            return faxeKondi;
        }

        public string FaxeKondiFilled()
        {
            string filled;

            for (int i = 0; i < faxeKondi.Length; i++)
            {
                if (faxeKondi[i] == null)
                {
                    filled = "(Not filled)";

                    return filled;
                }
            }
            filled = "(Filled)";

            return filled;
        }

        public Snack[] FillPepsiMax()
        {
            pepsiMaxCount = 0;

            for (int i = 0; i < pepsiMax.Length; i++)
            {
                pepsiMax[i] = new Snack("Pepsi Max", 10);
            }
            return pepsiMax;
        }

        public string PepsiMaxFilled()
        {
            string filled;

            for (int i = 0; i < pepsiMax.Length; i++)
            {
                if (pepsiMax[i] == null)
                {
                    filled = "(Not filled)";

                    return filled;
                }
            }
            filled = "(Filled)";

            return filled;
        }

        public Snack[] FillFantaOrange()
        {
            fantaOrangeCount = 0;

            for (int i = 0; i < fantaOrange.Length; i++)
            {
                fantaOrange[i] = new Snack("Fanta Orange", 10);
            }
            return fantaOrange;
        }

        public string FantaOrangeFilled()
        {
            string filled;

            for (int i = 0; i < fantaOrange.Length; i++)
            {
                if (fantaOrange[i] == null)
                {
                    filled = "(Not filled)";

                    return filled;
                }
            }
            filled = "(Filled)";

            return filled;
        }

        public Snack[] BuyingFaxeKondi()
        {
            faxeKondi[faxeKondiCount] = null;

            if (faxeKondiCount < faxeKondi.Length - 1)
            {
                faxeKondiCount++;
            }

            return faxeKondi;
        }

        public Snack[] BuyingPepsiMax()
        {
            pepsiMax[pepsiMaxCount] = null;

            if (pepsiMaxCount < pepsiMax.Length - 1)
            {
                pepsiMaxCount++;
            }

            return pepsiMax;
        }

        public Snack[] BuyingFantaOrange()
        {
            fantaOrange[fantaOrangeCount] = null;

            if (fantaOrangeCount < fantaOrange.Length - 1)
            {
                fantaOrangeCount++;
            }

            return fantaOrange;
        }
    }
}
