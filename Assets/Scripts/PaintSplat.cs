using System.Collections;
using UnityEngine;
public class PaintSplat : MonoBehaviour
{
    [SerializeField] GameObject paintPrefab;
    GameObject splat;
    private void OnCollisionEnter(Collision collision)
    {
        splat = Instantiate(paintPrefab, transform.position, Quaternion.Euler(gameObject.transform.forward));
        splat.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<Renderer>().sharedMaterial.color;
        gameObject.SetActive(false);
    }

    IEnumerator countdown()
    {
        yield return new WaitForSeconds(2);
        Destroy(splat);
        Destroy(gameObject);
    }
}