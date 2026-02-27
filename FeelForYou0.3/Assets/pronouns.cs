using UnityEngine;

public static class PronounData
{
    public static string SelectedPronouns = "They/Them";
}

public class PronounDropdown : MonoBehaviour
{
    // Add any necessary references
    public GameObject pronounDropdownObject;

    public void SetPronouns(int index)
    {
        // Check if object is still valid before interacting with it
        if (pronounDropdownObject != null)
        {
            switch (index)
            {
                case 0:
                    PronounData.SelectedPronouns = "He/Him";
                    break;
                case 1:
                    PronounData.SelectedPronouns = "She/Her";
                    break;
                case 2:
                    PronounData.SelectedPronouns = "They/Them";
                    break;
                default:
                    Debug.LogWarning("Invalid pronoun selection index.");
                    break;
            }
        }
        else
        {
            Debug.LogWarning("PronounDropdown object has been destroyed or not assigned.");
        }
    }

    // You can optionally use OnDestroy() to clean up
    void OnDestroy()
    {
        pronounDropdownObject = null; // Reset or clean references when destroyed
    }
}