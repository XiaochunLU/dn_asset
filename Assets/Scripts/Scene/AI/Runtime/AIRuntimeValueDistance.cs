// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace AI.Runtime {
    using UnityEngine;
    
    
    public class AIRuntimeValueDistance : AIRunTimeBase {
        
        public GameObject mAIArgTarget;
        
        public float floatmAIArgMaxDistance;
        
        public override void Init(AI.Runtime.AIRuntimeTaskData data) {
			base.Init(data);
			floatmAIArgMaxDistance = 1;
        }
        
        public override AIRuntimeStatus OnTick(XEntity entity) {
			mAIArgTarget = (GameObject)_tree.GetVariable("target"); 
			return AITreeImpleted.ValueDistanceUpdate(entity, mAIArgTarget, floatmAIArgMaxDistance);
        }
    }
}
