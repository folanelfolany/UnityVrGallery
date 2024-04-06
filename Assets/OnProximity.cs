using UnityEngine;

public class OnProximity : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;

    [SerializeField]
    private GameObject playerObject;

    [SerializeField]
    private float proximityDistance = 5f; // Default distance

    void Start()
    {
        // Activate Card 1 and deactivate Card 2 on start
        ActivateCard(card1);
        DeactivateCard(card2);
    }

    void Update()
    {
        // Check if playerObject is not null
        if (playerObject == null)
        {
            Debug.LogWarning("Player object is not assigned in the inspector.");
            return;
        }

        // Check distance between player and CoachingCardRoot
        float distance = Vector3.Distance(transform.position, playerObject.transform.position);

        // If player is close (e.g., within proximityDistance units), swap card states
        if (distance < proximityDistance)
        {
            DeactivateCard(card1);
            ActivateCard(card2);
        }
        else
        {
            // If player is not close, ensure Card 1 is active and Card 2 is inactive
            ActivateCard(card1);
            DeactivateCard(card2);
        }
    }

    void ActivateCard(GameObject card)
    {
        if (card != null)
        {
            card.SetActive(true);
        }
    }

    void DeactivateCard(GameObject card)
    {
        if (card != null)
        {
            card.SetActive(false);
        }
    }
}
