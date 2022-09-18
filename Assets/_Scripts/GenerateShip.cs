using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateShip : MonoBehaviour
{    
    private void OnMouseDown()
    {
        Debug.Log("MouseDown");
        string resourceName = "";
        int i = Random.Range(1, 4);
        if (i == 1) resourceName = "SmallShip";
        if (i == 2) resourceName = "MiddleShip";
        if (i == 3) resourceName = "BigShip";
        GameObject gameObject = Instantiate(Resources.Load(resourceName), new Vector2(Random.Range(-2.5f, 2.5f), -3f), Quaternion.identity) as GameObject;
        
    }
}
