using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float number1 = 2.5f;
    private int number2 = 5;
    private string message = "Hello, Unity!";
    private bool doðrumu = true;

    private void Awake()
    {
        Debug.Log("awake");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("start");
    }

    private void Update()
    {
        Debug.Log("update");

    }
    void FixedUpdate()

    {
        Debug.Log("fixedupdate");
    }

    void LateUpdate()
    {
        Debug.Log("lateupdate");
    }


}


