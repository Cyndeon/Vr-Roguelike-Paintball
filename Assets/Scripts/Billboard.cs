using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public bool disappearAfterSecond = false;
    private void Start()
    {
        if (disappearAfterSecond) StartCoroutine(Disappear());
    }
    void Update()
    {
        transform.LookAt(Camera.main.transform.position, -Vector3.up);
        transform.localEulerAngles += new Vector3(180, 0, 0);
    }

    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
