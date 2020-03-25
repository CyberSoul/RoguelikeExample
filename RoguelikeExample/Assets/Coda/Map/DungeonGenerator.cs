using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    public int m_mapWidth;
    public int m_mapHeight;

    public int m_roomWidthMin;
    public int m_roomWidthMax;
    public int m_roomHeightMin;
    public int m_roomHeightMax;

    public int m_corridorMaxLength;
    public int m_maxFeatures;

    public void InitializeDungeon()
    {
        MapManager.m_map = new Tile[m_mapWidth, m_mapHeight];
    }

    private void FirstRoom()
    {
        Feature room = new Feature();
        room.m_positions = new List<Position>();
    }
}
