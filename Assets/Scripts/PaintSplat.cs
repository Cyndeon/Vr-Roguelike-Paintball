using UnityEngine;
public class PaintSplat : MonoBehaviour
{
    [SerializeField] GameObject paintPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(paintPrefab, transform.position, Quaternion.Euler(collision.gameObject.transform.forward));
        paintPrefab.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<Renderer>().sharedMaterial.color;
        gameObject.SetActive(false);
    }
}