using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real seconds one full day lasts")]
    public float dayDuration = 120f;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees divided by the number of seconds in a day
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the directional light every frame
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}