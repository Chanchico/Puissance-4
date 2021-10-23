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
        public int PlayerNumber => 1;

        
        public void Play(int column)
        {
            for(int i = 0; i < 6; i++){

                try{
                     if (Tableau[column,i+1] != 'x' && Tableau[column,i+1] != 'o'){
                    continue;
                }
                else{
                    Tableau[column,i] = 'x';
                }

                }catch(System.IndexOutOfRangeException){
                   Tableau[column,i] = 'x';
                }
            }
        }

        // Etape 4 
        // Améliorer le Play pour qu'il détecte la victoire/nul et implémenter Winner et Ended
        public int Winner => 0;

        public bool Ended => false;

        public bool testFin(){
            for(int i = 0; i < 6 ; i++)
            {
                for(int j = 0; j < 7 ; j++)
                {
                   int compteur = 0;
                    while (compteur != 4){
                        try{
                             if(Tableau[i,j] == 'x'){
                                 compteur ++;
                             }
                        }catch(System.IndexOutOfRangeException){
                        continue;
                }

                        
                    }
                }
                
            }  
            return false;
        }
        
    }
}
