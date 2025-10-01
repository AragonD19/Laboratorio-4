using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;

    [Header("UI References")]
    public Transform inventoryPanel;
    public GameObject inventorySlotPrefab;

    private List<PickupData> items = new List<PickupData>();
    private Dictionary<PickupData, GameObject> itemSlots = new Dictionary<PickupData, GameObject>();

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void AddItem(PickupData data)
    {
        if (inventorySlotPrefab == null || inventoryPanel == null)
        {
            Debug.LogError("InventoryUI: No se asignó el prefab o el panel en el Inspector.");
            return;
        }

        GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel);

        Transform iconTransform = slot.transform.Find("Icon");
        Transform nameTransform = slot.transform.Find("Name");

        if (iconTransform == null || nameTransform == null)
        {
            Debug.LogError("InventorySlot prefab necesita hijos llamados 'Icon' y 'Name'");
            return;
        }

        iconTransform.GetComponent<Image>().sprite = data.icon;
        nameTransform.GetComponent<Text>().text = data.pickupName;
    }


    public bool HasItem(PickupData data)
    {
        return items.Contains(data);
    }

    public void RemoveItem(PickupData data)
    {
        if (items.Contains(data))
        {
            items.Remove(data);

            if (itemSlots.ContainsKey(data))
            {
                Destroy(itemSlots[data]);
                itemSlots.Remove(data);
            }
        }
    }
}
