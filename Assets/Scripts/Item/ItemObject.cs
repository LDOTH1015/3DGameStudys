using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iinteractable
{
    public string GetInteractPrompt();
    public void OnInteract();
}

public class ItemObject : MonoBehaviour, Iinteractable
{
    public ItemData itemData;

    public string GetInteractPrompt()
    {
        string str = $"{itemData.displayName}\n{itemData.description}";
        return str;
    }

    public void OnInteract()
    {
        CharacterManager.Instance.Player.itemData = itemData;
        CharacterManager.Instance.Player.addItem?.Invoke();
        Destroy(gameObject);
    }
}