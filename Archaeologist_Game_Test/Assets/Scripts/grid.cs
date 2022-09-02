using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{
    public int widthGrid = 5; // ширина сетки земли
    public int heightGrid = 5; //высота сетки земли
    //public GameObject[,] ground; //массив €чеек земли
    public GameObject[] ground; //массив €чеек земли
    public GameObject cellGround; //€чейка земли
    public RectTransform groundParent; //родительский объект,хран€щий все €чейки земли
    public Transform startPosition;
    void Start()
    {
        ground = new GameObject[widthGrid * heightGrid];
        Vector2 startPoint = new Vector2(groundParent.anchoredPosition.x, groundParent.anchoredPosition.y);
        addGround(startPoint);
    }
    void addGround(Vector2 spawnStartPoint)
    {
        int k = 0;
        Vector2 spawnPosition = startPosition.position;
        for (int i = 0; i < heightGrid; i++)
        {
            for (int j = 0; j < widthGrid; j++)
            {
                GameObject cellGroundSpawn = Instantiate(cellGround, new Vector2(0,0), Quaternion.identity);
                cellGroundSpawn.transform.SetParent(groundParent);
                cellGroundSpawn.transform.position = spawnPosition;
                //print(groundParent.position.x);
                //print(groundParent.position.y);

                ground[k] = cellGroundSpawn;
                ground[k].name = "CellGround" + "[" + i.ToString() + "," + j.ToString() + "]";
                spawnPosition.x++;
                k++;
            }
            spawnPosition.x = startPosition.position.x;
            spawnPosition.y++;
        }
    }
}
