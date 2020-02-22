/*
 * (Christopher Green)
 * (SimpleTreeFactory.cs)
 * (Assignment 5)
 * (This factory handles adding scripts to prefabs if they don't already have one)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTreeFactory : MonoBehaviour
{

    private GameObject treeToGrow;

    public GameObject AddTreeScript(GameObject treePrefab, string treeType)
    {
        treeToGrow = treePrefab;

        if (treeType.Equals("Fir Tree"))
        {
            if (treeToGrow.GetComponent<Fir>() == null)
            {
                treeToGrow.AddComponent<Fir>();
            }
        }
        else if (treeType.Equals("Oak Tree"))
        {
            if (treeToGrow.GetComponent<Oak>() == null)
            {
                treeToGrow.AddComponent<Oak>();
            }
        }
        else if (treeType.Equals("Palm Tree"))
        {
            if (treeToGrow.GetComponent<Palm>() == null)
            {
                treeToGrow.AddComponent<Palm>();
            }
        }

        return treeToGrow;
    }
}
