using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrystal : MonoBehaviour
{
    public grid gridArray;
    public int[] spawnArray;
    public int countCrystal=3;
    public GameObject objectCrystal;
    public Transform panel;
    void Start()
    {
        gridArray = GetComponent<grid>();
        spawnArray = new int[countCrystal];
        for (int i = 0; i < countCrystal; i++)
        {
            spawnArray[i] = Random.Range(0, gridArray.ground.Length);
            Debug.Log(gridArray.ground[spawnArray[i]].name);
        }
        //spawnerCrystal();
    }
    public void spawnerCrystal(int i)
    {
       //for (int i = 0; i < spawnArray.Length; i++)
       // {
            Vector3 spawnPointCrystal = gridArray.ground[spawnArray[i]].transform.position;
            Instantiate(objectCrystal, spawnPointCrystal, Quaternion.identity).transform.SetParent(panel);
       // }
    }
}
