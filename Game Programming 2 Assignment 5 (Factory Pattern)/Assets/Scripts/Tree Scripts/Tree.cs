using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    protected int treeHeight { get; set; }

    protected int woodCost { get; set; }

    protected string treeType { get; set; }


    public int GetWoodCost()
    {
        Debug.Log("The cost of the wood bundle is: $" + this.woodCost);
        return this.woodCost;
    }

    public int GetTreeHeight()
    {
        Debug.Log("The height of the tree is: " + this.treeHeight);
        return this.treeHeight;
    }

    public string GetTreeType()
    {
        Debug.Log("The type of the tree is: $" + this.treeType);
        return this.treeType;
    }
}
