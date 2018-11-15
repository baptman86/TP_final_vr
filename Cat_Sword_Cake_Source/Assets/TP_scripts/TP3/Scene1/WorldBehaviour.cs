using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class WorldBehaviour : MonoBehaviour
{
    public GameObject Player;
    public GameObject cat;
    GameObject instantiateCat;
    Text coinsText;
    int coins = 0;
    GameObject canvasObj;
    GameObject catSpawn;
    Transform child;
    bool catSpawned = false;

    void Start()
    {
        GameVariables.coins = 0;
        canvasObj = GameObject.Find("Canvas");
        child = canvasObj.transform.Find("UI_coins");
        coinsText = child.GetComponent<Text>();
    }

    private void Update()
    {
        if (GameVariables.coins<GameVariables.max_coins && GameVariables.currentTime > 0)
        {
            coinsText.text = "Coins: " + GameVariables.coins;
        }
        else
        {
            coinsText.text = "RUN !";
            if (!catSpawned)
            {
                catSpawn = GameObject.Find("CatSpawn");
                instantiateCat = Instantiate(cat, catSpawn.transform.position, Quaternion.identity);
                instantiateCat.AddComponent<NavMeshAgent>();
                instantiateCat.AddComponent<BoxCollider>();
                //instantiateCat.transform.parent = catSpawn.transform;
                catSpawned = true;
            }
            instantiateCat.GetComponent<NavMeshAgent>().SetDestination(Player.transform.position);
            instantiateCat.tag = "cat";
        }
    }

    public void AddCoin()
    {
        GameVariables.coins++;
    }
}
