using System;
using System.Collections.Generic;
using System.Text;

namespace Puissance4
{
    class Connect4
    {
        char[,] Tableau;
        // TODO : Compléter cette classe pour implémenter les règles du puissance 4
        // Etape 1
        public Connect4(){
            Tableau = new char[ColCount, LineCount];

            for (int y = 0; y < Tableau.GetLength(0); y++)
            {
                for (int x = 0; x < Tableau.GetLength(1); x++)
                {
                    Tableau[y, x] = ' ';
                }
            }
        }
        public int LineCount
        {
            get { return 6; }
        }
        public int ColCount => 7;

        
        // Etape 2
        // TODO : Utiliser un tableau à deux dimensions
        public char GetPawn(int col, int line) {
            return Tableau[col, line];
        }

        // Etape 3
        // Remplir la colonne jouée et changer de joueur
        public int PlayerNumber = 1;

        
        public void Play(int column)
        {
            for(int i = 0; i < Tableau.GetLength(1) ; i++){

                try{
                     if (Tableau[column,i+1] != 'x' && Tableau[column,i+1] != 'o'){
                    continue;
                    }
                if(PlayerNumber == 1){
                    Tableau[column,i] = 'x';
                    PlayerNumber = 2;
                }
                else if (PlayerNumber == 2){
                    Tableau[column,i] = 'o';
                    PlayerNumber = 1;
                }

                }catch(System.IndexOutOfRangeException){
                   if(PlayerNumber == 1){
                        Tableau[column,i] = 'x';
                        PlayerNumber = 2;
                    }
                    else if (PlayerNumber == 2){
                        Tableau[column,i] = 'o';
                        PlayerNumber = 1;
                    }
                }
            }
        }

        // Etape 4 
        // Améliorer le Play pour qu'il détecte la victoire/nul et implémenter Winner et Ended
        public int Winner => 0;

        public bool Ended => false;
       
    }
}
