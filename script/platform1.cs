using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class platform1 : MonoBehaviour
{
    public int scene;
    public int nextscene;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.right, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("candy"))
        {
            SceneManager.LoadScene(nextscene);
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
