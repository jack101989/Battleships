using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class AIEasyPlayer : AIPlayer
{
	//Generates an appropriate coordinate (within boundaries and has not already been shot at)
	protected override void GenerateCoords (ref int row, ref int column)
	{
		do {
			SearchCoords (ref row, ref column);
		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid [row, column] != TileView.Sea));
	}

	//AI always searches, always firing randomly
	private void SearchCoords (ref int row, ref int column)
	{
		row = _Random.Next (0, EnemyGrid.Height);
		column = _Random.Next (0, EnemyGrid.Width);
	}

	public AIEasyPlayer (BattleShipsGame controller) : base (controller)
	{ }

	//Doesn't need to process the shot
	protected override void ProcessShot(int row, int col, AttackResult result)
	{}
}
