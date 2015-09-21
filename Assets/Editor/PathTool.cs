using UnityEngine;
using System.Collections;
using UnityEditor; 

public class PathTool : ScriptableObject {

    // 存放路点
    static PathNode selectNode = null;

    //在编辑器中添加菜单PathTool
    //设置父路点菜单 快捷键 Ctrl+q;
    [MenuItem("PathTool/Set Parent %q")]
    static void SetParent()
    {
        //如果没有选择任何物体，或者选择物体大于1。返回
        if (!Selection.activeGameObject || Selection.GetTransforms(SelectionMode.Unfiltered).Length > 1)
        {
            return;
        }
        if(Selection.activeGameObject.tag == "pathnode")
        {
            selectNode = Selection.activeGameObject.GetComponent<PathNode>();//增加脚本
        }
    }

    //如果什么都没选择将禁用菜单功能
    [MenuItem("PathTool/Set Parent %q",true)]
    static bool ValidateSelection()
    {
        if (Selection.activeGameObject == null || Selection.activeGameObject.tag != "pathnode")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //设置子路点菜单 快捷键 ctrl+w
    [MenuItem("PathTool/Set next %w")]
    static void SetNextChild()
    {
        if (!Selection.activeGameObject || selectNode == null || Selection.GetTransforms(SelectionMode.Unfiltered).Length > 1)
        {
            return;
        }
        if (Selection.activeGameObject.tag=="pathnode")
        { 
            selectNode.SetNext(Selection.activeGameObject.GetComponent<PathNode>());
            selectNode = null;
        }
    }

    //选择的物品不是路点时禁用
    [MenuItem("PathTool/Set next %w", true)]
    static bool ValidateSelection1()
    {
        if (Selection.activeGameObject == null || Selection.activeGameObject.tag != "pathnode" || selectNode == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
