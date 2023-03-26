using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManage : MonoBehaviour
{
    public static QuestManage instance;

    [Header("Main Menu Panel List")]
    public GameObject Quest;
    public GameObject Quest1;
    public GameObject Quest1F;
    public GameObject Mision;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Q()
    {
        if(Quest != null)
        {
            Quest.SetActive(true);
        }
        else if( Quest1 != null)
        {
            Quest1.SetActive(true);
        }
        else if (Quest1F != null)
        {
            Quest1F.SetActive(true);
        }
    }
    public void Q1()
    {
        Destroy(Quest.gameObject);
        Quest1.SetActive(true);
    }

    public void Exit()
    {
        Destroy(Quest.gameObject);
        Quest1.SetActive(false);
        Quest1F.SetActive(false);
    }

    public void Finis()
    {
        Quest1F.SetActive(true);
    }


}
