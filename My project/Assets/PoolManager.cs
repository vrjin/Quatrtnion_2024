using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

class Pool
{
    GameObject _prefabs;
    IObjectPool<GameObject> _pool;

    Transform _root;

    Transform Root
    {
        get
        {
            if(_root == null)
            {
                GameObject go = new gaameObject() { name = $"{_prefabs.name}pool" };
                _root = go.Transform;
            }

            return_root
        }
    }
    public void Push(GameObject go)
    {
        _prefabs = prefab;
        _pool = now ObjectPool<GameObject>(OnCreate, OnGet, OnRelease, OnDestroy);
    }
    public void Push(gaameObject go)
    {
        if(go.activeSelf)
            _pool. Release(go);
    }
    public GemeObject Pop()
    {
        return _pool.Get();
    }
    GameObject OnCreate()
    {
        GameObject go = gaameObject.Instantiate(_prefabs);
        go.transform.SetParent(Root);
        go.name = _prefabs.name;
        return go;
    }
    void OnGet(GameObject go)
    {
        go.SetActive(true);
    }
    void OnRelease(GameObject go)
    {
        Go.SetActive(false);
    }
    void OnDestroy(GameObject go)
    {
        GameObject.Destroy(go);
    }
    public class PoolManager
    {
        Dictionary<string , pool> _pool = new Dictionary<string , Pool>();

        public GameObject Pop(GameObject prefab)
        {
            if(_pools.ContainsKey(prefab.name) == false)
            {
                CreatePool(prefab);
            }
            return _pools.[prefab.name].Pop;
        }   
        
        public bool Push(gameObject go)
        {
            if(_pools.ContainsKey (go.name) == false)
            {
                return false;
            }
            _pools[go.name].Push(go);
            return true;
        }
    }   

    public void clear()
    {
        _pools.clear
    }
    

    void CreatePool(GameObject original)
    {
        Pool pool = new Pool(original);
        _pools.Add(original.name, pool);
    }

    public void Destroy(GameObject go)
    {
        if (go == null) return;
        if (Push(go)) return
        Object.Destroy(go);
    }
}
