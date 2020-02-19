using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public SimpleTreeFactory treeFactory;

    private GameObject tree; 
    public List<GameObject> treeSpawnLocations = new List<GameObject>();
    public List<GameObject> trees = new List<GameObject>();
    private List<string> treeTypes = new List<string> { "Fir Tree", "Oak Tree", "Palm Tree" };

    private int treeSpawnIndex;
    private int treeStringIndex;

    private void Start()
    {
        treeSpawnIndex = 0;
        treeStringIndex = 0;

        Debug.Log("The total amount of tree spawn locations is: " + treeSpawnLocations.Count);
    }

    private void Update()
    {
        // Debug.Log("The current index is: " + index); //treeSpawnLocations[index]);
        // Debug.Log("The current index is: " + treeSpawnLocations[treeSpawnIndex]);

        Debug.Log("The current index for treeStrings is: " + treeStringIndex);

        Debug.Log("The current name for the current index for treeSpawn is: " + treeSpawnLocations[treeSpawnIndex]);

        Debug.Log("The current index number in treeSpawn is: " + treeSpawnIndex);

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


        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Debug.Log("The next index is: " + index); //treeSpawnLocations[index]);
            // Debug.Log("The next index is: " + treeSpawnLocations[treeSpawnIndex]);

            if (treeSpawnIndex < 8)
            {
                treeSpawnIndex++;
            }
            else if (treeSpawnIndex >= 8)
            {
                treeSpawnIndex = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Debug.Log("The previous index was: " + index); //treeSpawnLocations[index]);
            // Debug.Log("The previous index was: " + treeSpawnLocations[treeSpawnIndex]);

            if (treeSpawnIndex > 0)
            {
                treeSpawnIndex--;
            }
            else if (treeSpawnIndex == 0)
            {
                treeSpawnIndex = 8;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnTree(treeTypes[treeStringIndex]);

            

            trees.Add(tree);
        }

    }

    public void SpawnTree(string treeType)
    {

        tree = treeFactory.GrowTree(treeType);
        Debug.Log("The type of tree that was grown was a: " + treeType);

        Vector3 spawnPos = treeSpawnLocations[treeSpawnIndex].transform.position;

        tree = Instantiate(tree, spawnPos, treeSpawnLocations[treeSpawnIndex].transform.rotation);

    }

}
