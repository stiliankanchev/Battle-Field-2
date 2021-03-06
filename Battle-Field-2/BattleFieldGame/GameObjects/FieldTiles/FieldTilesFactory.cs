﻿namespace BattleFieldGame.GameObjects.FieldTiles
{
    using BattleFieldGame.Helpers;
    using BattleFieldGame.Interfaces;

    public class FieldTilesFactory : IFieldTilesFactory
    {
        /// <summary>
        /// Creates an empty tile
        /// </summary>
        /// <returns>An empty tile</returns>
        public IFieldTile GetEmptyTile()
        {
            return new EmptyFieldTile();
        }

        /// <summary>
        /// Creates a mine tile with detonation type and strategy.
        /// </summary>
        /// <param name="detonationType">The specified detonation type</param>
        /// <param name="detonationStrategy">The specified strategy if detonation</param>
        /// <returns>A new mine tile with the specified params</returns>
        public IMineTile GetMineTile(MineDetonationType detonationType, IMineDetonationStrategy detonationStrategy)
        {
            return new MineTile(detonationType, detonationStrategy);
        }
    }
}
