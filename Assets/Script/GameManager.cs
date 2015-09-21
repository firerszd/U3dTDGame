using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    public ArrayList m_PathNodes;
    public bool m_debug;
    public GameObject newt;

    void Awake()
    {
        Instance = this;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    [ContextMenu("BuildPath")]
    void BuildPath()
    {
        
        m_PathNodes = new ArrayList();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("pathnode");
            for (int i=0;i<objs.Length;i++)
            {
                PathNode node=objs[1].GetComponent<PathNode>();
                m_PathNodes.Add(node);
            }
    }

    [ContextMenu("find")]
    void newmath()
    {
        newt = new GameObject();
        newt = GameObject.Find("GameObject");
    }

    void onDrawGizmos()
    {
        Gizmos.DrawIcon(newt.transform.position, "hbs.tif"); 
        //if (!m_debug || m_PathNodes == null)
        //{
        //    return;
        //}
        //foreach(PathNode node in m_PathNodes)
        //{
        //    if (node.m_next != null)
        //    {
        //        Gizmos.DrawLine(node.transform.position, node.m_next.transform.position);
        //    }
        //}
    }
}
