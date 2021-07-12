using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Inventory/Items")]
public class Items : ScriptableObject
{
    public int id;
    public string nameItems;
    public string description;
    public int price;
    public Sprite image;
    public int hpGiven;
    public int speedGiven;
    public float speedDuration;
    public int jumpGiven;
}
