using System.Collections;
using IL_TabView;
using UnityEditor;
using UnityEngine;
namespace IL_EditorScripts {
	[CustomEditor (typeof (TabViewScroll),true), CanEditMultipleObjects]
	// Start is called before the first frame update
	public class GraphValidator : Editor {
		public override void OnInspectorGUI () {
			GUIStyle style=new GUIStyle(GUI.skin.button);
			style.normal.textColor=Color.blue;
			TabViewScroll tabView=(TabViewScroll)target;
			base.OnInspectorGUI();
			if (GUILayout.Button ("Set Panel For TabView",style)) {
				tabView.SetInspector();
			}
		}
	}
}