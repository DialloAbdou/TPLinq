using System.Collections;

namespace MyAppLinq
{
    public class MaListeEnumerator : IEnumerator<int>
    {
        private int[] tableau;
        private readonly int Taille;
        int index = -1;

        public MaListeEnumerator(int taille)
        {
            Taille = taille;
            tableau = new int[Taille];
            for (int i = 0; i < Taille; i++)
            {
                tableau[i] = i + 1;
            }
        }
        public int Current => tableau[index];

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (index >= Taille - 1)
            {
                return false;
            }
            index = index + 1;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        { 
        }
    }
}
