using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    public static InventoryUI Instance;

    [Header("UI References")]
    public Transform inventoryPanel;       
    public GameObject inventorySlotPrefab; 

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }


    public void AddItem(PickupData data)
    {
        GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel);

        slot.transform.Find("Icon").GetComponent<Image>().sprite = data.icon;
        slot.transform.Find("Name").GetComponent<Text>().text = data.pickupName;
    }
}
