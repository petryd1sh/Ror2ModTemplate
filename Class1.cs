using BepInEx;
using RoR2;

namespace Ror2ModTemplate
{
    [BepInDependency("com.bepis.r2api")]
    //Change these
    [BepInPlugin("com.Ror2ModTemplate.Ror2ModTemplate", "Ror2ModTemplate", "1.0.0")]
    public class MyRor2Mod : BaseUnityPlugin
    {
        public void Awake()
        {
            Chat.AddMessage("Loaded Ror2ModTemplate!");
            On.EntityStates.Huntress.ArrowRain.OnEnter += (orig, self) =>
            {
                // [The code we want to run]

                // Call the original function (orig)
                // on the object it's normally called on (self)
                orig(self);
            };
        }
    }
}