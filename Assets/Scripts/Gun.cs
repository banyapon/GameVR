using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebXR;

public class Gun : MonoBehaviour
{
    public WebXRController webXRController;
    public float fireRate = 0.3f;
    private float nextFire = 0.0f;
    public GameObject bullet, gunPosition;
    // Start is called before the first frame update
    void Start()
    {
        webXRController = GetComponent<WebXRController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(webXRController.GetAxis(WebXRController.AxisTypes.Trigger) > 0)
        {
            Fire();
        }
        if (webXRController.GetButton(WebXRController.ButtonTypes.ButtonA))
        {
            Debug.Log("Reloaded");
        }
    }
    public void Fire()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, gunPosition.transform.position, gunPosition.transform.rotation);
        }
    }
}
