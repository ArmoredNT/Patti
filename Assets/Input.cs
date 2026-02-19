using UnityEngine;

public class Input : MonoBehaviour
{
    [SerializeField] Rigidbody a;   
    [SerializeField] Rigidbody b;   

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.A))
        {
            a.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.D))
        {
            b.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }
}
