using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTreeFactory : MonoBehaviour
{
    public GameObject firTreePrefab;
    public GameObject oakTreePrefab;
    public GameObject palmTreePrefab;

    private GameObject treeToGrow;

    public GameObject GrowTree(string treeType)
    {
        treeToGrow = null;

        if (treeType.Equals("Fir Tree"))
        {
            treeToGrow = firTreePrefab;
        }
        else if (treeType.Equals("Oak Tree"))
        {
            treeToGrow = oakTreePrefab;
        }
        else if (treeType.Equals("Palm Tree"))
        {
            treeToGrow = palmTreePrefab;
        }

        return treeToGrow;
    }
}
