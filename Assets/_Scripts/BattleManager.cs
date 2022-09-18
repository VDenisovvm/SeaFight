using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager
{
    public List<Ship> PlayerShips = new List<Ship>();
    public List<Ship> EnemyShips = new List<Ship>();
    public int actionPoints = 3;
    public bool playerTurn = true;
    public BattleState battleState;
    public BattleField battleField;
}

public class BattleField
{
    BattlePoint[,] Field = new BattlePoint[14,28];      
}

public class BattlePoint 
{
    public int x;
    public int y;
}

public class ShipPoint: BattlePoint
{
    public bool damaged = false;
    public bool gun = false;
    public BattleField battleField;
    public Ship Ship;
}

public class ObstacklePoint: BattlePoint
{
    public int Type;
}

public enum BattleState
{
    Started = 1,
    Paused = 2,
    Searhing = 3,
    Finished = 4    
}
