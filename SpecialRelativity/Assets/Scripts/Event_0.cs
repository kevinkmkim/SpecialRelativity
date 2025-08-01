using System.Collections;
using UnityEngine;

public class Event_0 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(EventCoroutine());
    }

    private IEnumerator EventCoroutine()
    {
        DialogueManager.Instance.Train.transform.position = new Vector3(25f, -0.57f, -1.32f);
        StartCoroutine(DialogueManager.Instance.MoveTrainSmooth(new Vector3(-27f, 0f, 0f), 3f));
        yield return new WaitForSeconds(3f);
        DialogueManager.Instance.EinsteinAnimator.SetTrigger("Walk Start");
        yield return new WaitForSeconds(3f);
        DialogueManager.Instance.EinsteinAnimator.SetTrigger("Walk Stop");

        DialogueManager.Instance.StartNextNode();
        Destroy(gameObject);
    }
}
