using UnityEngine;

[CreateAssetMenu(fileName = "NewPickup", menuName = "Pickups/New Pickup")]
public class PickupData : ScriptableObject
{
    public string pickupName;
    public Sprite icon;
    public PickupEffectType effectType;
    public int value; 
}

public enum PickupEffectType
{
    Heal,
    Damage,
    AddScore,
    Unlock,
    AddArmor,
    None
}
