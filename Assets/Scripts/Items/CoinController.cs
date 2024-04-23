using UnityEngine;

public class CoinController : MonoBehaviour
{
    [SerializeField] private int points = 10;

    private void OnTriggerEnter()
    {
        EventManager.RaiseAddPoints(points);
        Destroy(gameObject);
    }
}