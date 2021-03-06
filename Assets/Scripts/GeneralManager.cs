using UnityEngine;
using TMPro;
using System.Globalization;

public class GeneralManager : MonoBehaviour
{
    public GameObject people;
    public bool is_people=false;
    public GameObject levelBar;
    public GameObject healthBar;
    public GameObject animal;
    public int time;
    public float levelScore;
    public float health;
      private Animator m_animator;
    public TextMeshProUGUI _scoreTxt;
    // Start is called before the first frame update
    void Start()
    { 
        //levelScore = GameObject.Find("Canvas/txtScore").GetComponent<TextMeshProUGUI>().text);
        ////InvokeRepeating("people_coming", 0.0f, 1.0f);

    }
    
    // Update is called once per frame
    void Update()
    {
        levelScore = float.Parse(_scoreTxt.text, CultureInfo.InvariantCulture.NumberFormat);
        _scoreTxt = GameObject.Find("Canvas/txtScore").GetComponent<TextMeshProUGUI>();
        if (levelScore / 100 >= 1)
        {
            Debug.Log("Congragulations!");
        }
        else
        {
           // levelScore += 0.1f;
            _scoreTxt.text = levelScore.ToString();
            levelBar.transform.localScale = new Vector3(levelScore / 100, 1, 1);
        }

   
        //if (is_people)
        //{
        //    Vector3 position = people.transform.position;
        //    position.z += 0.05f;
        //    if (position.z >= 5.0f)
        //    {
        //        Destroy(people);
        //    }
        //    people.transform.position = position;

        //}

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Animal")
        {
            Debug.Log("carpisma");
            levelScore += 10;
        }
        else if (other.gameObject.name=="Obstacle")
        {
            levelScore += 10;
        }
      
    }

}
