using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TreeSpawner : MonoBehaviour
{
    private GameController gameController;

    public SimpleTreeFactory treeFactory;
    public SimplePrefabFactory prefabFactory;

    private GameObject tree;

    public List<GameObject> treeSpawnLocations = new List<GameObject>();
    private List<string> treeTypes = new List<string> { "Fir Tree", "Oak Tree", "Palm Tree" };

    public int totalWoodIncomeNum;
    public int treeSpawnIndex;
    private int treeStringIndex;

    private void Start()
    {

        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        treeSpawnIndex = 0;
        treeStringIndex = 0;

    }

    private void Update()
    {
        if(gameController.isTutorialDone)
        {
            SwitchTrees();
            IndexForward();
            IndexBack();
            InstantiateTree();
            ClearTrees();
        }
    }

    public void SpawnTree(string treeType)
    {

        tree = prefabFactory.GrowTree(treeType);

        tree = treeFactory.AddTreeScript(tree, treeType);
        Debug.Log("The type of tree that was grown was a: " + treeType);

        Vector3 spawnPos = treeSpawnLocations[treeSpawnIndex].transform.position;

        //tree = Instantiate(tree, spawnPos, treeSpawnLocations[treeSpawnIndex].transform.rotation);
        Instantiate(tree, spawnPos, treeSpawnLocations[treeSpawnIndex].transform.rotation);

    }

    public void SwitchTrees()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (treeStringIndex < 2)
            {
                treeStringIndex++;
            }
            else if (treeStringIndex >= 2)
            {
                treeStringIndex = 0;
            }
        }
    }

    public void IndexForward()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            if (treeSpawnIndex < 8)
            {
                treeSpawnIndex++;
            }
            else if (treeSpawnIndex >= 8)
            {
                treeSpawnIndex = 0;
            }
        }
    }

    public void IndexBack()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (treeSpawnIndex > 0)
            {
                treeSpawnIndex--;
            }
            else if (treeSpawnIndex == 0)
            {
                treeSpawnIndex = 8;
            }
        }
    }

    public void InstantiateTree()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnTree(treeTypes[treeStringIndex]);
        }
    }

    public void ClearTrees()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            var firClones = GameObject.FindGameObjectsWithTag("Fir");
            var oakClones = GameObject.FindGameObjectsWithTag("Oak");
            var palmClones = GameObject.FindGameObjectsWithTag("Palm");

            foreach (var clones in firClones)
            {
                Destroy(clones);
            }
            foreach (var clones in oakClones)
            {
                Destroy(clones);
            }
            foreach (var clones in palmClones)
            {
                Destroy(clones);
            }

            totalWoodIncomeNum += Score.woodCost;

            //Score.treeTotal = 0;

        }
    }
}
