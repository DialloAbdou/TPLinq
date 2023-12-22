using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLinq
{
    public class MaListe : IEnumerable<int>
    {
        private MaListeEnumerator enumerator;
        public MaListe(int Taille)
        {
            enumerator = new MaListeEnumerator(Taille);
        }
        public IEnumerator<int> GetEnumerator()
        {
           return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
