using System;
using NUnit.Framework;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyGame.tests
{
	[TestFixture]
	public class DestroyerTests
	{
		[Test]
		public void TestDestroyerDirection ()
		{
			Ship testDestroyer = new Ship (ShipName.Destroyer);
			Tile tile1 = new Tile (1, 1, null);
			Tile tile2 = new Tile (1, 2, null);
			Tile tile3 = new Tile (1, 3, null);
			Tile tile4 = new Tile (1, 4, null);
			testDestroyer.AddTile (tile1);
			testDestroyer.AddTile (tile2);
			testDestroyer.AddTile (tile3);
			//testDestroyer.AddTile (tile4);
			Assert.That (testDestroyer.Direction == Direction.LeftRight);
		}

		[Test]
		public void TestDestroyerHit ()
		{
			Ship testDestroyer = new Ship (ShipName.Destroyer);
			Tile tile1 = new Tile (1, 1, null);
			Tile tile2 = new Tile (1, 2, null);
			Tile tile3 = new Tile (1, 3, null);
			Tile tile4 = new Tile (1, 4, null);
			testDestroyer.AddTile (tile1);
			testDestroyer.AddTile (tile2);
			testDestroyer.AddTile (tile3);
			testDestroyer.Hit ();
			testDestroyer.Hit ();
			//testDestroyer.AddTile (tile4);
			Assert.That (testDestroyer.Hits == 2);
		}

		[Test]
		public void TestDestroyerName ()
		{
			Ship testDestroyer = new Ship (ShipName.Destroyer);
			Tile tile1 = new Tile (1, 1, null);
			Tile tile2 = new Tile (1, 2, null);
			Tile tile3 = new Tile (1, 3, null);
			Tile tile4 = new Tile (1, 4, null);
			testDestroyer.AddTile (tile1);
			testDestroyer.AddTile (tile2);
			testDestroyer.AddTile (tile3);
			testDestroyer.Hit ();
			testDestroyer.Hit ();
			//testDestroyer.AddTile (tile4);
			Assert.That (testDestroyer.Name == "Destroyer");
		}

		[Test]
		public void TestDestroyerDeployed ()
		{
			Ship testDestroyer = new Ship (ShipName.Destroyer);
			Tile tile1 = new Tile (1, 1, null);
			Tile tile2 = new Tile (1, 2, null);
			Tile tile3 = new Tile (1, 3, null);
			Tile tile4 = new Tile (1, 4, null);
			testDestroyer.AddTile (tile1);
			testDestroyer.AddTile (tile2);
			testDestroyer.AddTile (tile3);
			testDestroyer.Hit ();
			testDestroyer.Hit ();
			//testDestroyer.AddTile (tile4);
			Assert.That (testDestroyer.IsDeployed);
		}

		[Test]
		public void TestDestroyerDestroyed ()
		{
			Ship testDestroyer = new Ship (ShipName.Destroyer);
			Tile tile1 = new Tile (1, 1, null);
			Tile tile2 = new Tile (1, 2, null);
			Tile tile3 = new Tile (1, 3, null);
			Tile tile4 = new Tile (1, 4, null);
			testDestroyer.AddTile (tile1);
			testDestroyer.AddTile (tile2);
			testDestroyer.AddTile (tile3);
			testDestroyer.Hit ();
			testDestroyer.Hit ();
			//testDestroyer.AddTile (tile4);
			Assert.That (!testDestroyer.IsDestroyed);
			testDestroyer.Hit ();
			Assert.That (testDestroyer.IsDestroyed);
		}


	}
}


