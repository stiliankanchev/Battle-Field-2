﻿namespace BattleFieldGame.GameObjects
{
    public interface IGameField
    {
        int FieldSize
        {
            get;
        }

        int DetonatedMines
        {
            get;
        }

        int MinesCount
        {
            get;
        }

        int GetRowsCount();

        int GetColumnsCount();

        IFieldTile this[int col, int row]
        {
            get;
            //set; Uncomment if you need public setter
        }

        void DetonateMine(int xCoord, int yCoord);
    }
}
