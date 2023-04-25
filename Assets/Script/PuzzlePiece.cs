using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class PuzzlePiece : MonoBehaviour
{
    //[SerializeField] private AudioSource _audio;
  // [SerializeField] private AudioClip _click;
    [SerializeField] private GameObject[] _shadows;
    private SortingGroup Sorting;
    private Vector2 _originalPosition;
  


    End end_script;
    private void Start()
    {

        _shadows = GameObject.FindGameObjectsWithTag("shadow");
        //baslangic pozisyonumuzu belirlemek icin yapiyoruz.
        transform.position = new Vector3(Random.Range(2.8f, 8f), Random.Range(3f, -3));
        end_script = GameObject.Find("Puzzle Piece").GetComponent<End>();
        Sorting = GetComponent<SortingGroup>();
    }
    // objeyi surukle  anlamina geliyor.
    private void OnMouseDrag()
    {
        Vector3 _pozition = GetMousePos();//Dokundugumuz yerleri bize verir.
        _pozition.z = 0;

        // dokundugumuz yerle esitliyoruz posizyona.
        transform.position = _pozition;
        Sorting.sortingOrder = 10;
    }

    private void Update()
    {
        MouseUp();

    }
    /*
     * Fareyi biraktigimizda calisacak fonksiyonumuz.
     * */
    private void MouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {

            foreach (GameObject shadow in _shadows)
            {
                if (gameObject.name == shadow.name)//ust üste gelirse
                {
                    float distance = Vector3.Distance(shadow.transform.position, transform.position);// Mesafe ölcmek icin kullaniliyor.
                    if (distance <= 0.5f)
                    {
                        transform.position = shadow.transform.position;
                       // _audio.PlayOneShot(_click); 
                        Destroy(this);
                        end_script.LevelEnd();
                        Sorting.sortingOrder = 2;

                    }
                    
                }
            }
        }
    }



   public Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

}
