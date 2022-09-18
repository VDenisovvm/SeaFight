using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public int Size;
    public int Sight;
    public int FireRange;
    public int Cost;
    public string Type;
    public BattleField BattleField;
    public List<ShipPoint> shipPoints = new List<ShipPoint> ();  

    private void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector2(mousePos.x, mousePos.y);
    }
}
