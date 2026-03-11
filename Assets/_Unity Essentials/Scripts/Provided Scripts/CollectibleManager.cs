using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;
    public TMP_Text collectibleText;
    public int totalCollectibles = 5;
    private int collected = 0;

    void Awake() { Instance = this; }
    public void AddCollectible()
{
    collected++;
    if (collectibleText != null)
        collectibleText.text = $"Collected: {collected}";  
    
    Debug.Log($"Collected: {collected}/{totalCollectibles}");
    
    if (collected >= totalCollectibles) 
        Debug.Log("VICTORY!");
}

}
