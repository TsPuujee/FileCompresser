using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    class daraalal
    {
        BinaryTree a;
        int hemj;
        daraalal deed, dood, next, prev;
        public daraalal() { deed = null; dood = null; next = null; prev = null; hemj = 0; }
        ~daraalal() { }

        public void oruul(BinaryTree aq)
        {
            daraalal oroh = deed, anew = new daraalal();
            anew.a = aq;
            if (deed == null && dood == null)
            {
                dood = anew;
                deed = anew;
            }
            else
            {
                if (anew.a.root1().hus().Item2 < deed.a.root1().hus().Item2) oroh = null;
                else
                {
                    while (oroh.a.root1().hus().Item2 < anew.a.root1().hus().Item2)
                    {
                        if (oroh == dood) break;
                        if (oroh.next.a.root1().hus().Item2 > anew.a.root1().hus().Item2) break;
                        oroh = oroh.next;
                    }
                }
                //oroh=oroh.prev;
                if (oroh == null) { anew.next = deed; deed.prev = anew; deed = anew; }
                else if (oroh == dood) { anew.prev = dood; dood.next = anew; dood = anew; }
                else
                {
                    anew.next = oroh.next;
                    oroh.next.prev = anew;
                    oroh.next = anew;
                    anew.prev = oroh;
                }

            }
            hemj++;
        }
        public BinaryTree garga()
        {
            // Console.WriteLine("sdf");
            if (deed == null) return null;
            // Console.WriteLine("sdf");
            BinaryTree temp = deed.a;
            if (dood == deed)
            {
                dood = deed = null;
            }
            else
            {
                deed = deed.next;
                deed.prev = null;
            }
            // System.Console.WriteLine("sdf  "+temp.root1().hus().Item1 + "\t" + temp.root1().hus().Item2);
            //            cout << temp << endl;
            hemj--;
            return temp;
        }
        public BinaryTree minext()
        {
            BinaryTree buts = new BinaryTree();
            if (hemj >= 2)
            {
                // garga();
                BinaryTree t1 = garga();
                //  Console.WriteLine(t1.root1().hus().Item1 + "\t" + t1.root1().hus().Item2);
                BinaryTree t2 = garga();
                buts.insert(Tuple.Create(t1.root1().hus().Item1 + t2.root1().hus().Item1, t1.root1().hus().Item2 + t2.root1().hus().Item2));
                buts.root1().leftLeaf = t1.root1();
                buts.root1().rightLeaf = t2.root1();
            }
            return buts;
        }

        public void print()
        {
            daraalal dood1 = dood;
            while (dood1 != null)
            {
                System.Console.WriteLine(dood1.a.root1().hus().Item1 + "\t" + dood1.a.root1().hus().Item2);
                //               cout << dood.a << "\n";
                dood1 = dood1.prev;
            }
        }

        public BinaryTree asdqwe()
        {
            daraalal dood1 = dood;
            return dood1.a;
        }

        public void Uusge()
        {
            while (hemj >= 2)
            {
                oruul(minext());
            }
        }
    }

}
