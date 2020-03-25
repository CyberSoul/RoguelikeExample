using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MapManager
{
    public static Tile[,] m_map;


}

[Serializable]
public class Tile
{
    /*public int PositionX;
    public int PositionY;*/
    public Position m_position;

    [NonSerialized] public GameObject m_baseObject;
}

[Serializable]
public class Position
{
    public int x;
    public int y;
}

[Serializable]
public class Wall
{
    public List<Position> m_positions;
    public string m_direction;
    public int m_length;
    public bool m_hasFearure = false;
}

[Serializable]
public class Feature
{
    public List<Position> m_positions;
    public Wall[] m_walls;
    public string m_type;
    public int m_width;
    public int m_height;
}
