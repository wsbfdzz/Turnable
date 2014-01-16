﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurnItUp.Locations;

namespace Tests.Locations
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void Board_ConstructionFromTmxTileMap_IsSuccessful()
        {
            Board board = new Board("../../Fixtures/FullExample.tmx");

            Assert.IsNotNull(board.Map);
        }

        [TestMethod]
        public void Board_DeterminingObstacles_TakesIntoAccountLayersHavingTrueForIsCollisionProperty()
        {
            Board board = new Board("../../Fixtures/FullExample.tmx");

            // The example board has a "wall" around the entire 15x15 level
            Assert.IsTrue(board.IsObstacle(0, 0, 1));
            Assert.IsTrue(board.IsObstacle(0, 1, 1));
            Assert.IsTrue(board.IsObstacle(1, 0, 1));
            Assert.IsTrue(board.IsObstacle(2, 0, 1));

            Assert.IsFalse(board.IsObstacle(1, 1, 1));
        }

        [TestMethod]
        public void Board_DeterminingObstacles_TakesIntoAccountObstaclesOnLayerAboveIt()
        {
            Board board = new Board("../../Fixtures/FullExample.tmx");

            // The example board has a "wall" around the entire 15x15 level
            Assert.IsTrue(board.IsObstacle(0, 0, 0));
            Assert.IsTrue(board.IsObstacle(0, 1, 0));
            Assert.IsTrue(board.IsObstacle(1, 0, 0));
            Assert.IsTrue(board.IsObstacle(2, 0, 0));

            Assert.IsFalse(board.IsObstacle(1, 1, 0));
        }
    }
}
