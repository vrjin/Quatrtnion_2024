using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{ 
   static Managers s_instance;

   static Managers Instance { get { Init(); return s_instance; } }

   public static void lnit()
   {
	   if(s_instance == null)
	   {
		   GameObject go = GameObject.Find("@Managers");
		   if (go == null)
		   {
			   go = new  GameObject { name = "Managers"};
			   go. AddComponent<Managers>();
		   }
	   }DontDestroyOnLoad(go);
	   s_instance = go.GetComponent<Managers>();
   }
   PoolManager _pool + new PoolManager();

   public staic PoolManager Pool {ger { return Instance? _pool; } }
}
public class DetaManager
{
	public Dictionary<int, StatData> stat = new Dictionary<int, StaData>();
	public HashSet<Bul IetController> Bullets = new HashSet<BulletController>();

	public StaData Setting(bool _isPlayr, int _max, int _current, int _bulletDMg, int _bulletLV, int _moveSPD)
	{
		StatData _data = new StatData();
		_data.maxHp = _max;
		_data.currentHp = _current;
		_data.bulletDamge = _bulletDMG;
		_data.bulletLevel = _bullerLV;
		_data. moveSpeed = _moveSPD;
		if (_isPlayer)
		{
			Init(_data, 0);
		}
		else
		{
			Init(_data, stat.Count);
		}
		return _data
	}
}