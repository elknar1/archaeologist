using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CellGroundController : MonoBehaviour, IPointerClickHandler
{
    public Color[] colorGround;
    public int depth = 3;
    public int digCount = 0;
    public int shovel = 20;
    //int currentCountCoin = 0;
    //int countCoin = 3;
    public int depthSpawn;
    public SpawnCrystal spawn;
    public grid ground;
    void Awake()
    {
        spawn = GameObject.FindGameObjectWithTag("Ground").GetComponent<SpawnCrystal>();
        ground = GameObject.FindGameObjectWithTag("Ground").GetComponent<grid>();
        this.gameObject.GetComponent<Image>().color = colorGround[0];
        depthSpawn = Random.Range(0, depth);
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        //Debug.Log();
        if (digCount < depth && shovel > 0)
        {
            for (int i = 0; i < spawn.spawnArray.Length; i++)
            {
                if (eventData.pointerClick.name == ground.ground[spawn.spawnArray[i]].name)
                {
                    if (digCount == depthSpawn)
                    {
                        spawn.spawnerCrystal(i);
                    }
                    
                    break;
                }
            }
                gameObject.GetComponent<Image>().color = colorGround[digCount + 1];
                digCount++;
                --shovel;
        }
    }
}
