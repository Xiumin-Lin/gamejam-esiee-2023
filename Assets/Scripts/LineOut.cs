using System.Collections;
using UnityEngine;

public class LineOut : MonoBehaviour
{
    private SpriteRenderer _sprite;
    
    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        GameManager.Instance.DecreaseHp();
        Destroy(other.gameObject, 1);
        _sprite.enabled = true;
        StartCoroutine(DesableSprite());
    }
    
    private IEnumerator DesableSprite()
    {
        yield return new WaitForSeconds(0.1f);
        _sprite.enabled = false;
    }
}
