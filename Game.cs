using System;
using System.Collections.Generic;
using System.Linq;

namespace morpionGUI // Note: actual namespace depends on the project name.
{

    public class Game
    {
        public char[,] grid;
        public char currentPlayer;
        
        public Game(){  
            this.grid = new char[,] {{' ',' ',' '}, //tableau dans un tableau
                                    {' ',' ',' '},
                                    {' ',' ',' '}};
            this.currentPlayer= 'O';
        }
        public void displayGrid() //Affiche la grille
        {
            for(int i=0; i<grid.GetLength(0); i++)// boucle qui va parcourir les lignes
            { 
                for(int j=0; j<grid.GetLength(1); j++)// boucle qui va parcourir les colonnes
                { 
                    Console.Write(grid[i,j]);
                    if(j!=2)  // Creer la grille avec des |
                    { 
                        Console.Write("|");
                    }
                }
                Console.Write("\n"); // retour a la ligne 
            }
        }
        public void changeCurrentPlayer() //Fait alterner les joueurs O et X
        { 
            if(currentPlayer=='O')
            { 
                currentPlayer='X';
            }
            else
            {
                currentPlayer='O';
            }   
        }
        private int getPlayerValue(String text) //Le joueur écrit une valeur
        { 
            Console.Write(text); //Le joueur écrit
            string value = Console.ReadLine(); //Affiche le texte 
            try
            {
                int i = System.Convert.ToInt32(value); //conversion en entier
                if (i>3)
                {
                    return getPlayerValue(text); 
                }
                return i;
            }
            catch (FormatException)
            {
                return getPlayerValue(text); 
            }

        }
        public int getPlayerValueX() //Ecrire le numero de la colonne à jouer
        {
            return getPlayerValue("Entrer la colonne de la case à jouer");
        }
         public int getPlayerValueY() //Ecrire le numero de la ligne à jouer
        {
             return getPlayerValue("Entrer la ligne de la case à jouer");
        }
    
        public bool isWin()
        {
            
            for(int i=0; i<3; i++)
            {
                if(grid[1,0]==grid[1,1] && grid[1,1]==grid[1,2] && grid[1,0]!=' ')
                {
                 return true;
                }
            }
            for(int i=0; i<3; i++)
            if(grid[0,1]==grid[1,1] && grid[1,1]==grid[2,1] && grid[0,1]!=' ')
            {
                return true;
            }
            if(grid[0,0]==grid[1,1] && grid[1,1]==grid[2,2] && grid[0,0]!=' ')
            {
                return true;
            }
            if(grid[0,2]==grid[1,1] && grid[1,1]==grid[2,0] && grid[0,2]!=' ')
            {
                return true;
            }
            return false;
        }
        public bool isNull()
        {
            for(int i=0; i<grid.GetLength(0); i++)
            {
                for(int j=0;j<grid.GetLength(1); j++)
                {
                    if(grid[i,j]==' ')
                    {
                        return false; 

                    }
                }
            }
            return true;
        }         
    }
}