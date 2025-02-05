using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon
{
    public enum SceneType
    {
        Start,
        Status,
        Inventory,
        Equipment,
        Shop,
    }

    public class SceneManager : Singleton<SceneManager>
    {
        private Dictionary<SceneType, Scene> sceneDict;

        public SceneManager()
        {
            sceneDict = new Dictionary<SceneType, Scene>();
        }

        public void AddScene(SceneType type, Scene scene)
        {
            sceneDict.Add(type, scene);
        }

        public void TransitionScene(SceneType sceneType)
        {
            Console.Clear();
            if (sceneDict.TryGetValue(sceneType, out Scene scene))
            {
                scene.Start();
            }
        }
    }
}
