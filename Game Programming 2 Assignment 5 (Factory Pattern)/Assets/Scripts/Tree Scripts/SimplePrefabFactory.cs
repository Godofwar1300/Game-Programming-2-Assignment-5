using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePrefabFactory : MonoBehaviour
{

    public GameObject firTreePrefab;
    public GameObject oakTreePrefab;
    public GameObject palmTreePrefab;

    private GameObject treeToGrow;
    

    public GameObject GrowTree(string treeType)
    {
        treeToGrow = null;

        if(treeType.Equals("Fir Tree"))
        {
            treeToGrow = firTreePrefab;
            Score.score += 10;
            Score.woodCost += Random.Range(20, 40);
        }
        else if(treeType.Equals("Oak Tree"))
        {
            treeToGrow = oakTreePrefab;
            Score.score += 20;
            Score.woodCost += Random.Range(40, 60);
        }
        else if(treeType.Equals("Palm Tree"))
        {
            treeToGrow = palmTreePrefab;
            Score.score += 30;
            Score.woodCost += Random.Range(60, 80);
        }
        Score.treeTotal += 1;
        return treeToGrow;
    }

}
