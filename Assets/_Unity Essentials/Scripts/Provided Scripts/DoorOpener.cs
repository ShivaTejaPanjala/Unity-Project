using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public float openAngle = 90f;
    public float openSpeed = 2f;
    public float triggerDistance = 3f;
    private bool isOpen = false;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        bool shouldOpen = distance < triggerDistance;

        float targetAngle = shouldOpen && !isOpen ? openAngle : 0f;
        Quaternion targetRotation = Quaternion.Euler(0, targetAngle, 0);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, openSpeed * Time.deltaTime);
        
        if (Mathf.Abs(targetAngle - transform.localEulerAngles.y) < 1f)
            isOpen = shouldOpen;
    }
}
